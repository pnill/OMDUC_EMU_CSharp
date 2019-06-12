using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using NetworkProtocols;

namespace OMDUC_EMU
{
    public class StateObject
    {
        public Socket workSocket = null;
        public byte[] buffer;
        public byte[] packet_len = new byte[4];
        public utils.Crypto crypto = new utils.Crypto();
        public bool isEncrypted = false;
       
    }

    class Networking
    {
        private int port = 2302;

        public static ManualResetEvent allDone = new ManualResetEvent(false);
        public static ManualResetEvent recvDone = new ManualResetEvent(false);

        //MSDN - Asynchronous Server Socket example
        public void StartListening()
        {
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, this.port);  
            Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(100);

                Console.WriteLine("[-] Listening for connection...");

                while(true)
                {
                    allDone.Reset();
                    listener.BeginAccept(
                        new AsyncCallback(AcceptCallback), 
                        listener);

                    allDone.WaitOne();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("[!] Exception occurred in listener: " + e.ToString());
            }

            Console.WriteLine("\nProgram exiting, press ENTER to continue...");
            Console.Read();
        }


        public static void AcceptCallback(IAsyncResult ar)
        {
            allDone.Set();
            Socket listener = (Socket)ar.AsyncState;
            Socket handler = listener.EndAccept(ar);

            StateObject state = new StateObject();
            state.workSocket = handler;

            Console.WriteLine("[-] Got connection from {0}:{1}\r\n", ((IPEndPoint)(handler.RemoteEndPoint)).Address,((IPEndPoint)(handler.RemoteEndPoint)).Port);
            
            while (true)
            {
                recvDone.Reset();
                handler.BeginReceive(state.packet_len, 0, 4, 0,
                    new AsyncCallback(ReadCallback), state);
                recvDone.WaitOne();
            }
       }

        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }

        private static void SendCallback(IAsyncResult ar)
        {
            try
            {
                Socket handler = (Socket)ar.AsyncState;
                int bytesSent = handler.EndSend(ar);

                Console.WriteLine("[-] Sent {0} bytes to client.\r\n", bytesSent);
            
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void Send(Socket handler,StateObject state,byte[] data)
        {
            if (state.isEncrypted)
                data = state.crypto.EncryptPayload(data);

            data = BotNetBasePacket.SerializePacket(data, false);

            handler.BeginSend(data, 0, data.Length, 0,
          new AsyncCallback(SendCallback), handler);
        }

        public static void ReadCallback(IAsyncResult ar)
        {           
            StateObject state = (StateObject)ar.AsyncState;
            Socket handler = state.workSocket;

            int bytesRead = handler.EndReceive(ar);
            
            if(bytesRead > 0)
            {
                int packet_len = BitConverter.ToInt32(state.packet_len, 0);

                if (packet_len < 1)
                {
                    Console.WriteLine("[!] - Got bad packet length");
                    return;
                }

                Console.WriteLine("[-] Recieved packet with length: {0}", packet_len);

                state.buffer = new byte[packet_len];

                bytesRead = handler.Receive(state.buffer, packet_len, SocketFlags.None);

                //Repeat the same process now that we have the entire packet...
                if(bytesRead > 0)
                {
                    bool packetHandled = false;
                    if (state.isEncrypted)
                        state.buffer = state.crypto.DecryptPayload(state.buffer);

                    BotNetMessage message = MessageUtil.Deserialize(state.buffer);

                    if (message == null)
                    {
                        Console.WriteLine("[!] - Got invalid message");
                        return;
                    }

                    if (message.GetType() == typeof(RequestSecurityHandshake))
                    {
                        state.isEncrypted = true; // Because we're sent a security handshake future communication will be encrypted.

                        Console.WriteLine("[-] Got security handshake request!");

                        Console.WriteLine("[/] Decrypting and storing IV/Key in util.crypto");
                        state.crypto.DecryptSymmetricKeys((RequestSecurityHandshake)message);

                        ResponseSecurityHandshake handshake_resp = new ResponseSecurityHandshake();
                        handshake_resp.SecurityToken = message.SecurityToken;
                        handshake_resp.RequestID = message.RequestID;
                        handshake_resp.SessionToken = message.SessionToken;

                        Console.WriteLine("[-] Sending Security handshake response!");
                               
                        Send(handler, state, handshake_resp.SerializeMessage());

                        packetHandled = true;
                    }

                    if (message.GetType() == typeof(RequestClientHandshake))
                    {
                        Console.WriteLine("[-] Got Client handshake request!");


                        ResponseClientHandshake chandshake_resp = new ResponseClientHandshake();
                        chandshake_resp.SecurityToken = message.SecurityToken;
                        chandshake_resp.RequestID = message.RequestID;
                        chandshake_resp.SessionToken = message.SessionToken;

                        Console.WriteLine("[*] Client handshake ProtocolVersion: {0}", ((RequestClientHandshake)message).ProtocolVersion);

                        if( ((RequestClientHandshake)message).ProtocolVersion == 11118 )
                        {
                            chandshake_resp.Outcome = eClientHandshakeOutcome.ClientHandshake_Success;
                            chandshake_resp.Reason = "Success!";
                        }
                        else
                        {
                            chandshake_resp.Outcome = eClientHandshakeOutcome.ClientHandshake_VersionMismatch;
                            chandshake_resp.Reason = "Bad protocol version";
                        }

                        Console.WriteLine("[-] Sending Client handshake response");

                        Send(handler, state, chandshake_resp.SerializeMessage());

                        packetHandled = true;
                    }

                    if (message.GetType() == typeof(ClientPingRequest))
                    {
                        Console.WriteLine("[-] Got ClientPingRequest");
                        Console.WriteLine("[*] Last Average Ping: {0}", ((ClientPingRequest)message).LastAvgPing);
                        
                        ClientPingResponse ping_resp = new ClientPingResponse();
                        ping_resp.RequestID = message.RequestID;
                        ping_resp.SecurityToken = message.SecurityToken;
                        ping_resp.SessionToken = message.SessionToken;

                        Console.WriteLine("[-] Sending ClientPingResponse");

                        Send(handler, state, ping_resp.SerializeMessage());

                        packetHandled = true;
                    }

                    if(message.GetType() == typeof(RequestServerProtoData))
                    {
                        Console.WriteLine("[-] Got RequestServerProtoData\r\n");
                        #region Level Unlocks Response
                        ResponseLevelUnlocks mResponseLevelUnlocks = new ResponseLevelUnlocks();
                        mResponseLevelUnlocks.RequestID = message.RequestID;
                        mResponseLevelUnlocks.SecurityToken = message.SecurityToken;
                        mResponseLevelUnlocks.SessionToken = message.SessionToken;

                        NewAccount nBaseAwardItem = new NewAccount();
                        nBaseAwardItem.Awards.Add(new ItemAward { HardAwardType = HardAwardTypes.Skulls, Quantity = 200, AwardInventoryGUID = 0, TrapStrength = 1  });

                        PacketLevelUnlock pLevelUnlock = new PacketLevelUnlock
                        {
                            Title = "Test",
                            AllowedGameType = eGameType.Tutorial,
                            DefaultGameType = eGameType.Tutorial,
                            Description = "Test Description",
                            Portrait = "Test",
                            MaxTraitSlots = 1,
                            PlayerLevel = 100,
                            PlayerAward = nBaseAwardItem
                        };

                        PacketLevelUnlock pLevelUnlock2 = new PacketLevelUnlock
                        {
                            Title = "Test2",
                            AllowedGameType = eGameType.Tutorial,
                            DefaultGameType = eGameType.Tutorial,
                            Description = "Test2 Description",
                            Portrait = "Test2",
                            MaxTraitSlots = 1,
                            PlayerLevel = 1,
                            PlayerAward = nBaseAwardItem
                        };

                        PacketLevelUnlock pLevelUnlock3 = new PacketLevelUnlock
                        {
                            Title = "Test3",
                            AllowedGameType = eGameType.Tutorial,
                            DefaultGameType = eGameType.Tutorial,
                            Description = "Test3 Description",
                            Portrait = "Test3",
                            MaxTraitSlots = 1,
                            PlayerLevel = 2,
                            PlayerAward = nBaseAwardItem
                        };

                        PacketUnlockedCraftRecipe nUnlockedCraftRecipe = new PacketUnlockedCraftRecipe();
                        nUnlockedCraftRecipe.CraftRecipeGUID = 0;
                        pLevelUnlock.UnlockedCraftRecipes.Add(nUnlockedCraftRecipe);


                        mResponseLevelUnlocks.Unlocks.Add(pLevelUnlock);
                        mResponseLevelUnlocks.Unlocks.Add(pLevelUnlock2);
                        mResponseLevelUnlocks.Unlocks.Add(pLevelUnlock3);
                       
                        // mResponseLevelUnlocks.Unlocks.Add(new PacketLevelUnlock
                        //{

                        //});
                        #region Level_1 data
                        /*PacketLevelUnlock pLevelUnlock = new PacketLevelUnlock();

                        NewAccount bAward = new NewAccount();

                        SkullsCredit bAwardItem = new SkullsCredit();
                        bAwardItem.IsRefund = false;
                        bAwardItem.HardAwardType = HardAwardTypes.Skulls;
                        bAwardItem.Quantity = 200;

                        bAward.Awards.Add(bAwardItem);
                        

                        pLevelUnlock.AllowedGameType = eGameType.Tutorial;
                        pLevelUnlock.DefaultGameType = eGameType.Tutorial;
                        pLevelUnlock.Description = "Description filler data";
                        pLevelUnlock.MaxTraitSlots = 1;
                        pLevelUnlock.PlayerLevel = 1;
                        //pLevelUnlock.PlayerAward = bAward;
                        */

                        #endregion

                        Console.WriteLine("[-] Sending level unlocks");

                        Send(handler, state, mResponseLevelUnlocks.SerializeMessage());
                        #endregion

                        #region Level Curve Packet
                        ResponseLevelCurve rLevelCurve = new ResponseLevelCurve();
                        rLevelCurve.SessionToken = message.SessionToken;
                        rLevelCurve.SecurityToken = message.SecurityToken;
                        rLevelCurve.RequestID = message.RequestID;

                        PacketLevelCurveEntry pLevelCurveEntry = new PacketLevelCurveEntry();
                        pLevelCurveEntry.Level = 1;
                        pLevelCurveEntry.XP = 500;

                        PacketLevelCurveEntry pLevelCurveEntry2 = new PacketLevelCurveEntry();
                        pLevelCurveEntry2.Level = 2;
                        pLevelCurveEntry2.XP = 1000;

                        PacketLevelCurveEntry pLevelCurveEntry3 = new PacketLevelCurveEntry();
                        pLevelCurveEntry3.Level = 3;
                        pLevelCurveEntry3.XP = 1500;

                        rLevelCurve.LevelCurve.Add(pLevelCurveEntry);
                        rLevelCurve.LevelCurve.Add(pLevelCurveEntry2);
                        rLevelCurve.LevelCurve.Add(pLevelCurveEntry3);

                        Console.WriteLine("[-] Sending rLevelCurve");
                        Send(handler, state, rLevelCurve.SerializeMessage());
                        #endregion

                        #region DashboardConfigs
                        ResponseDashboardConfigs mDashBoardConfigs = new ResponseDashboardConfigs();
                        mDashBoardConfigs.SessionToken = message.SessionToken;
                        mDashBoardConfigs.SecurityToken = message.SecurityToken;
                        mDashBoardConfigs.RequestID = message.RequestID;
                        mDashBoardConfigs.ServerRegion = eServerRegion.NA;
                        mDashBoardConfigs.BaseCDNContentURL = "";
                        mDashBoardConfigs.CertifiedStreamersOnly = false;
                        mDashBoardConfigs.ChestContentsURL = "";
                        mDashBoardConfigs.CustomerServiceUrl = "";
                        mDashBoardConfigs.EnabledABTests.Add(eGameABTestType.None);
                        mDashBoardConfigs.EULAUrl = "";
                        mDashBoardConfigs.ForumsUrl = "";
                        mDashBoardConfigs.GFAccountRecoveryURL = "";
                        mDashBoardConfigs.LeaderboardUrl = "";
                        mDashBoardConfigs.LobbyInviteTimeoutSeconds = 2000;
                        mDashBoardConfigs.LoginUrl = "http://www.thedefaced.org/invalid_login_url/";

                        /*MatchmakingBonusXPConfig iMatchMakingBonusXPConfig = new MatchmakingBonusXPConfig();

                        iMatchMakingBonusXPConfig.GameType = eGameType.All;
                        iMatchMakingBonusXPConfig.BonusPercent = 0;

                        mDashBoardConfigs.MatchmakingBonusConfig.Add(iMatchMakingBonusXPConfig);
                        */

                        mDashBoardConfigs.MatchmakingDownLevelingLevelDifference = 0;
                        mDashBoardConfigs.MaxFriends = 1000;
                        mDashBoardConfigs.PartyInviteTimeoutSeconds = 2000;
                        mDashBoardConfigs.PlayerReportingUrl = "";
                        mDashBoardConfigs.ReferAFriendURL = "";
                        mDashBoardConfigs.RegisterUrl = "http://www.thedefaced.org/register_url/";
                        mDashBoardConfigs.ResetPasswordUrl = "http://www.thedefaced.org/reset_password_url/";
                        mDashBoardConfigs.SabotageUnlockAchievementGUID = 0;
                        mDashBoardConfigs.TermsOfServiceUrl = "";

                        /*TrapTier mTrapTier = new TrapTier();
                        mTrapTier.SlotAvailable = true;
                        mTrapTier.Strength = 1;

                        mDashBoardConfigs.TrapTiers.Add(mTrapTier);
                        */
                        Console.WriteLine("[-] Sending Dashboard Configs");
                        Send(handler, state, mDashBoardConfigs.SerializeMessage());
                        #endregion

                        #region GuildCreationRequirements
                        ResponseGuildCreationRequirements mGuildCreationRequirements = new ResponseGuildCreationRequirements();
                        mGuildCreationRequirements.SessionToken = message.SessionToken;
                        mGuildCreationRequirements.SecurityToken = message.SecurityToken;
                        mGuildCreationRequirements.RequestID = message.RequestID;

                        mGuildCreationRequirements.CreationRequirements.CostSkullsToCreateGuild = 5000;
                        mGuildCreationRequirements.CreationRequirements.MaximumRosterSize = 20;
                        mGuildCreationRequirements.CreationRequirements.MinLevelToCreateGuild = 3;

                        //Regexes not set.

                        Console.WriteLine("[-] Sending Guild Creation Requirements");
                        Send(handler, state, mGuildCreationRequirements.SerializeMessage());
                        #endregion

                        #region Campaign Definitions
                        ResponseCampaignDefinitions mCampaignDefinitions = new ResponseCampaignDefinitions();
                        mCampaignDefinitions.SessionToken = message.SessionToken;
                        mCampaignDefinitions.SecurityToken = message.SecurityToken;
                        mCampaignDefinitions.RequestID = message.RequestID;

                        PacketCampaign pCampaign = new PacketCampaign();
                        pCampaign.CampaignID = 1;
                        pCampaign.Name = "Test Campaign";

                        PacketCampaignMission pCampaignMission = new PacketCampaignMission();
                        pCampaignMission.PrerequisiteMissionID = 0;
                        pCampaignMission.GameMapID = 1;
                        pCampaignMission.GameType = eGameType.Tutorial;
                        pCampaignMission.NameLocKey = "Test";

                        PacketCampaignMission pCampaignMission2 = new PacketCampaignMission();
                        pCampaignMission2.PrerequisiteMissionID = 0;
                        pCampaignMission2.GameMapID = 2;
                        pCampaignMission2.GameType = eGameType.Tutorial;
                        pCampaignMission2.NameLocKey = "Test2";

                        PacketCampaignMission pCampaignMission3 = new PacketCampaignMission();
                        pCampaignMission3.PrerequisiteMissionID = 0;
                        pCampaignMission3.GameMapID = 3;
                        pCampaignMission3.GameType = eGameType.Tutorial;
                        pCampaignMission3.NameLocKey = "Test3";

                        PacketCampaignMission pCampaignMission4 = new PacketCampaignMission();
                        pCampaignMission4.PrerequisiteMissionID = 0;
                        pCampaignMission4.GameMapID = 4;
                        pCampaignMission4.GameType = eGameType.Tutorial;
                        pCampaignMission4.NameLocKey = "Test4";

                        PacketCampaignMission pCampaignMission5 = new PacketCampaignMission();
                        pCampaignMission5.PrerequisiteMissionID = 0;
                        pCampaignMission5.GameMapID = 5;
                        pCampaignMission5.GameType = eGameType.Tutorial;
                        pCampaignMission5.NameLocKey = "Test5";

                        PacketCampaignMission pCampaignMission6 = new PacketCampaignMission();
                        pCampaignMission6.PrerequisiteMissionID = 0;
                        pCampaignMission6.GameMapID = 6;
                        pCampaignMission6.GameType = eGameType.Tutorial;
                        pCampaignMission6.NameLocKey = "Test6";


                        pCampaign.SequentialMissions.Add(pCampaignMission);
                        pCampaign.SequentialMissions.Add(pCampaignMission2);
                        pCampaign.SequentialMissions.Add(pCampaignMission3);
                        pCampaign.SequentialMissions.Add(pCampaignMission4);
                        pCampaign.SequentialMissions.Add(pCampaignMission5);
                        pCampaign.SequentialMissions.Add(pCampaignMission6);

                        mCampaignDefinitions.Campaigns.Add(pCampaign);

                        Console.WriteLine("[-] Sending campaign definitions");
                        Send(handler, state, mCampaignDefinitions.SerializeMessage());
                        #endregion

                        #region BattleGround Bucket Definitions
                        ResponseBattlegroundBuckets mBattleGroundBuckets = new ResponseBattlegroundBuckets();
                        mBattleGroundBuckets.SessionToken = message.SessionToken;
                        mBattleGroundBuckets.SecurityToken = message.SecurityToken;
                        mBattleGroundBuckets.RequestID = message.RequestID;

                        /* PacketBattlegroundBucket pBattleGroundBucket = new PacketBattlegroundBucket();
                         pBattleGroundBucket.
                         mBattleGroundBuckets.Buckets.Add()
                         */

                        Console.WriteLine("[-] Sending BattleGround Bucket definitions");
                        Send(handler, state, mBattleGroundBuckets.SerializeMessage());
                        #endregion

                        #region Challenge Data
                        PushActiveChallenge mActiveChallenge = new PushActiveChallenge();
                        mActiveChallenge.SessionToken = message.SessionToken;
                        mActiveChallenge.SecurityToken = message.SecurityToken;
                        mActiveChallenge.RequestID = message.RequestID;
                        /*
                         * mActiveChallenge.Challenge.
                        */

                        Console.WriteLine("[-] Sending Challenge data");
                        Send(handler, state, mActiveChallenge.SerializeMessage());
                        #endregion

                        #region Event Chest Contents
                        ResponseEventChestContents mEventChestContents = new ResponseEventChestContents();
                        mEventChestContents.SecurityToken = message.SecurityToken;
                        mEventChestContents.SessionToken = message.SessionToken;
                        mEventChestContents.RequestID = message.RequestID;

                        /*
                         * EventChestProto pEventChest = new EventChestProto();
                         * pEventChest.
                         * mEventChestContents.EventChests.Add()
                        */

                        Console.WriteLine("[-] Sending Event Chest Contents");
                        Send(handler, state, mEventChestContents.SerializeMessage());
                        #endregion

                        #region Animatic Definitions
                        PushAnimaticDefinitions mAnimaticDefinitions = new PushAnimaticDefinitions();
                        mAnimaticDefinitions.SecurityToken = message.SecurityToken;
                        mAnimaticDefinitions.SessionToken = message.SessionToken;
                        mAnimaticDefinitions.RequestID = message.RequestID;

                        //AnimaticDefinitionPacket pAnimaticDefinition = new AnimaticDefinitionPacket();
                        //pAnimaticDefinition.Filename = "";
                        //pAnimaticDefinition.ID = 0;
                        //mAnimaticDefinitions.AnimaticDefitions.Add(pAnimaticDefinition)

                        Console.WriteLine("[-] Sending Animatic Definitions");
                        Send(handler, state, mAnimaticDefinitions.SerializeMessage());
                        #endregion

                        #region Sabotage BaseItems
                        PushBaseSabotageItems mPushBaseSabotageItems = new PushBaseSabotageItems();

                        mPushBaseSabotageItems.SecurityToken = message.SecurityToken;
                        mPushBaseSabotageItems.SessionToken = message.SessionToken;
                        mPushBaseSabotageItems.RequestID = message.RequestID;


                        Console.WriteLine("[-] Sending Sabotage Base Items");
                        Send(handler, state, mPushBaseSabotageItems.SerializeMessage());
                        #endregion

                        #region Sabotage Rankings
                        PushSabotageRankingDefinition mSabotageRankingDefinition = new PushSabotageRankingDefinition();
                        mSabotageRankingDefinition.SecurityToken = message.SecurityToken;
                        mSabotageRankingDefinition.SessionToken = message.SessionToken;
                        mSabotageRankingDefinition.RequestID = message.RequestID;

                        /*SabotageRankingDefinitionForNetwork nSabotageRankingdef = new SabotageRankingDefinitionForNetwork();
                        nSabotageRankingdef.GuildMaxMMR = 0;
                        nSabotageRankingdef.GuildMinMMR = 0;
                        nSabotageRankingdef.PlayerMaxMMR = 0;
                        nSabotageRankingdef.PlayerMinMMR = 0;
                        nSabotageRankingdef.TierID = 0;
                        nSabotageRankingdef.TierName = "";
                        nSabotageRankingdef.TierNumber = 0;
                        nSabotageRankingdef.TierType = eSabotageTiers.Bronze;
                        
                        mSabotageRankingDefinition.SabotageTierRankingDefinitions.Add(nSabotageRankingdef)
                        */

                        Console.WriteLine("[-] Sending Sabotage rankings");
                        Send(handler, state, mSabotageRankingDefinition.SerializeMessage());
                        #endregion

                        #region Sabotage Buckets
                        ResponseSabotageBuckets mSabotageBuckets = new ResponseSabotageBuckets();
                        mSabotageBuckets.SecurityToken = message.SecurityToken;
                        mSabotageBuckets.SessionToken = message.SessionToken;
                        mSabotageBuckets.RequestID = message.RequestID;

                        /* PacketSabotageBucket iSabotageBucket = new PacketSabotageBucket();
                         iSabotageBucket.AverageLevel = 0;
                         iSabotageBucket.AverageLevel = 0;
                         iSabotageBucket.GameMaps.Add(0);
                         mSabotageBuckets.Buckets.Add(iSabotageBucket);
                        */

                        Console.WriteLine("[-] Sending Sabotage Buckets");
                        Send(handler, state, mSabotageBuckets.SerializeMessage());
                        #endregion

                        packetHandled = true;
                    }

                    if(message.GetType() == typeof(SteamLoginRequest))
                    {
                       
                        Console.WriteLine("[-] Got SteamLoginRequest");
                        Console.WriteLine("[-] SteamID: {0}", ((SteamLoginRequest)message).SteamID);
                        Console.WriteLine("[-] Auth Token: {0}", ((SteamLoginRequest)message).AuthToken);
                        Console.WriteLine("[-] Remote EndPoint: {0}", ((SteamLoginRequest)message).RemoteEndpoint);

                        SteamLoginResponse mSteamLoginResponse = new SteamLoginResponse();
                        mSteamLoginResponse.SecurityToken = message.SecurityToken;
                        mSteamLoginResponse.SessionToken = message.SessionToken;
                        mSteamLoginResponse.RequestID = message.RequestID;

                        mSteamLoginResponse.Status = eAuthLoginUserStatus.AuthLoginUserStatus_Success;
                        mSteamLoginResponse.AccountSUID = 1;
                        mSteamLoginResponse.GameInProgress = false;
                        mSteamLoginResponse.GameType = eGameType.None;
                        mSteamLoginResponse.GuildID = 0;
                        mSteamLoginResponse.GuildName = "";
                        mSteamLoginResponse.GuildTag = "";
                        mSteamLoginResponse.PlayerCurrency = ePriceCurrencyType.USD;
                        mSteamLoginResponse.Username = "PermaNull";

                        Send(handler, state, mSteamLoginResponse.SerializeMessage());
                        packetHandled = true;
                    }

                    if(message.GetType() == typeof(RequestValidateEmail))
                    {
                        Console.WriteLine("[-] Got RequestValidateEmail");
                        Console.WriteLine("[-] Email: {0}", ((RequestValidateEmail)message).Email);

                        ResponseValidateEmail mResponseValidateEmail = new ResponseValidateEmail();
                        mResponseValidateEmail.SessionToken = message.SessionToken;
                        mResponseValidateEmail.SecurityToken = message.SecurityToken;
                        mResponseValidateEmail.RequestID = message.RequestID;
 
                        mResponseValidateEmail.Status = eRegistrationStatus.eRegistrationStatus_Success;

                        Send(handler, state, mResponseValidateEmail.SerializeMessage());

                        packetHandled = true;

                    }

                    if(message.GetType() == typeof(RequestValidateNickname))
                    {
                        Console.WriteLine("[-] Got RequestValidateNickname");
                        Console.WriteLine("[-] Nickname: {0}", ((RequestValidateNickname)message).Nickname);

                        ResponseValidateNickname mResponseValidateNickname = new ResponseValidateNickname();
                        mResponseValidateNickname.SecurityToken = message.SecurityToken;
                        mResponseValidateNickname.SessionToken = message.SessionToken;
                        mResponseValidateNickname.RequestID = message.RequestID;

                        mResponseValidateNickname.Status = eRegistrationStatus.eRegistrationStatus_Success;

                        Send(handler, state, mResponseValidateNickname.SerializeMessage());

                        packetHandled = true;
                    }

                    if(message.GetType() == typeof(RequestValidatePassword))
                    {
                        Console.WriteLine("[-] Got RequestValidatePassword");
                        Console.WriteLine("[-] Password?: {0} ", ((RequestValidatePassword)message).Password);

                        ResponseValidatePassword mResponseValidatePasssword = new ResponseValidatePassword();
                        mResponseValidatePasssword.SecurityToken = message.SecurityToken;
                        mResponseValidatePasssword.SessionToken = message.SessionToken;
                        mResponseValidatePasssword.RequestID = message.RequestID;

                        mResponseValidatePasssword.Status = eRegistrationStatus.eRegistrationStatus_Success;

                        Send(handler, state, mResponseValidatePasssword.SerializeMessage());

                        packetHandled = true;
                    }

                    if(message.GetType() == typeof(UserRegisterRequest))
                    {
                        
                        Console.WriteLine("[-] Got UserRegisterRequest");

                        UserRegisterResponse mUserRegisterResponse = new UserRegisterResponse();
                        mUserRegisterResponse.SecurityToken = message.SecurityToken;
                        mUserRegisterResponse.SessionToken = message.SessionToken;
                        mUserRegisterResponse.RequestID = message.RequestID;

                        mUserRegisterResponse.Status = eRegistrationStatus.eRegistrationStatus_Success;
                        mUserRegisterResponse.AccountSUID = 1;
                        mUserRegisterResponse.Username = "PermaNull";

                        Send(handler, state, mUserRegisterResponse.SerializeMessage());

                        packetHandled = true;
                    }

                    if(message.GetType() == typeof(RequestValidateAccountForSteam))
                    {
                        Console.WriteLine("[-] Got RequestValidateAccountForSteam");
                        ResponseValidateAccountForSteam mResponseValidateAccountForSteam = new ResponseValidateAccountForSteam();
                        mResponseValidateAccountForSteam.RequestID = message.RequestID;
                        mResponseValidateAccountForSteam.SecurityToken = message.SecurityToken;
                        mResponseValidateAccountForSteam.SessionToken = message.SessionToken;

                        mResponseValidateAccountForSteam.Status = eAuthLoginUserStatus.AuthLoginUserStatus_Success;

                        Send(handler, state, mResponseValidateAccountForSteam.SerializeMessage());
                        packetHandled = true;

                    }

                    if(message.GetType() == typeof(RequestPlayerMessages))
                    {
                        Console.WriteLine("[-] Got RequestPlayerMessage");
                        ResponsePlayerMessages mResponsePlayerMessages = new ResponsePlayerMessages();
                        mResponsePlayerMessages.RequestID = message.RequestID;
                        mResponsePlayerMessages.SecurityToken = message.SecurityToken;
                        mResponsePlayerMessages.SessionToken = message.SessionToken;

                        Send(handler, state, mResponsePlayerMessages.SerializeMessage());

                        packetHandled = true;
                    }


                    if (message.GetType() == typeof(RequestPlayerStats))
                    {
                        Console.WriteLine("[-] Got RequestPlayerStats");
                        ResponsePlayerStats mResponsePlayerStats = new ResponsePlayerStats();
                        mResponsePlayerStats.RequestID = message.RequestID;
                        mResponsePlayerStats.SessionToken = message.SessionToken;
                        mResponsePlayerStats.SecurityToken = message.SecurityToken;

                        mResponsePlayerStats.AccountSUID = 1;

                        Send(handler, state, mResponsePlayerStats.SerializeMessage());

                        packetHandled = true;

                    }

                    if(message.GetType() == typeof(RequestPlayerDecks))
                    {
                        Console.WriteLine("[-] Got RequsetPlayerDecks");
                        ResponsePlayerDecks mResponsePlayerDecks = new ResponsePlayerDecks();
                        mResponsePlayerDecks.RequestID = message.RequestID;
                        mResponsePlayerDecks.SessionToken = message.SessionToken;
                        mResponsePlayerDecks.SecurityToken = message.SecurityToken;

                        mResponsePlayerDecks.AccountSUID = 1;
                        mResponsePlayerDecks.Value = 0;

                        //DeckEntry deck = new DeckEntry();
                        //deck.
                        //mResponsePlayerDecks.Decks
                        Send(handler, state, mResponsePlayerDecks.SerializeMessage());

                        packetHandled = true;
                    }

                    if(message.GetType() == typeof(RequestStarAwardsEarned))
                    {
                        Console.WriteLine("[-] Got RequestStarAwardsEarned");
                        ResponseStarAwardsEarnedList mResponseStarAwardsEarned = new ResponseStarAwardsEarnedList();
                        mResponseStarAwardsEarned.RequestID = message.RequestID;
                        mResponseStarAwardsEarned.SessionToken = message.SessionToken;
                        mResponseStarAwardsEarned.SecurityToken = message.SecurityToken;

                        Send(handler, state, mResponseStarAwardsEarned.SerializeMessage());

                        packetHandled = true;
                    }

                    if(message.GetType() == typeof(RequestStoreData))
                    {
                        Console.WriteLine("[-] Got RequestStoreData");
                        ResponseStoreData mResponseStoreData = new ResponseStoreData();
                        mResponseStoreData.RequestID = message.RequestID;
                        mResponseStoreData.SecurityToken = message.SecurityToken;
                        mResponseStoreData.SessionToken = message.SessionToken;

                        Send(handler, state, mResponseStoreData.SerializeMessage());

                        packetHandled = true;
                    }

                    if(message.GetType() == typeof(RequestGetFriends))
                    {
                        Console.WriteLine("[-] RequestGetFriends");
                        ResponseGetFriends mResponseGetFriends = new ResponseGetFriends();
                        mResponseGetFriends.RequestID = message.RequestID;
                        mResponseGetFriends.SecurityToken = message.SecurityToken;
                        mResponseGetFriends.SessionToken = message.SessionToken;

                        mResponseGetFriends.Status = eGetFriendsStatus.GetFriends_Success;

                        Send(handler, state, mResponseGetFriends.SerializeMessage());

                        packetHandled = true;

                    }

                    if(message.GetType() == typeof(RequestGetFriendRequests))
                    {
                        Console.WriteLine("[-] Got RequestGetFriendRequests");
                        ResponseGetFriendRequests mResponseGetFriendRequest = new ResponseGetFriendRequests();
                        mResponseGetFriendRequest.RequestID = message.RequestID;
                        mResponseGetFriendRequest.SecurityToken = message.SecurityToken;
                        mResponseGetFriendRequest.SessionToken = message.SessionToken;

                        mResponseGetFriendRequest.Status = eGetFriendRequestsStatus.GetFriendRequests_Success;

                        Send(handler, state, mResponseGetFriendRequest.SerializeMessage());

                        packetHandled = true;

                    }

                    if (message.GetType() == typeof(RequestGetIncomingGuildInvites))
                    {
                        Console.WriteLine("[-] Got RequestGetIncomingGuildInvites");
                        ResponseGetIncomingGuildInvites mResponseGetIncomingGuildInvites = new ResponseGetIncomingGuildInvites();
                        mResponseGetIncomingGuildInvites.RequestID = message.RequestID;
                        mResponseGetIncomingGuildInvites.SessionToken = message.SessionToken;
                        mResponseGetIncomingGuildInvites.SecurityToken = message.SecurityToken;

                        mResponseGetIncomingGuildInvites.Status = eGuildOperationStatus.None;

                        Send(handler, state, mResponseGetIncomingGuildInvites.SerializeMessage());

                        packetHandled = true;
                    
                    }

                    if(message.GetType() == typeof(RequestChatFilterOptionChange))
                    {
                        Console.WriteLine("[-] Got RequestChatFilterOptionChange");
                        ResponseChatFilterOptionChange mResponseChatFilterOptionChange = new ResponseChatFilterOptionChange();
                        mResponseChatFilterOptionChange.RequestID = message.RequestID;
                        mResponseChatFilterOptionChange.SecurityToken = message.SecurityToken;
                        mResponseChatFilterOptionChange.SessionToken = message.SessionToken;

                        mResponseChatFilterOptionChange.ChatFilterDisabled = true;
                        mResponseChatFilterOptionChange.ResponseCode = eAccountDataEventCodes.Success_ChatFilterOptionChanged;

                        Send(handler, state, mResponseChatFilterOptionChange.SerializeMessage());

                        packetHandled = true;
                    }

                    if(message.GetType() == typeof(RequestDiscordAuthentication))
                    {
                        Console.WriteLine("[-] Got RequestDiscordAuthentication");
                        // unknown response
                        PushDiscordAccessToken mDiscordAccessToken = new PushDiscordAccessToken();
                        mDiscordAccessToken.RequestID = message.RequestID;
                        mDiscordAccessToken.SessionToken = message.SessionToken;
                        mDiscordAccessToken.SecurityToken = message.SecurityToken;

                        mDiscordAccessToken.AccessToken = "123456";

                        Send(handler, state, mDiscordAccessToken.SerializeMessage());
                        packetHandled = true;

                    }

                    if (message.GetType() == typeof(RequestMapList))
                    {
                        Console.WriteLine("[-] Got Request Map List");
                        GameMapList mGameMapList = new GameMapList();
                        mGameMapList.RequestID = message.RequestID;
                        mGameMapList.SecurityToken = message.SecurityToken;
                        mGameMapList.SessionToken = message.SessionToken;

                        mGameMapList.GameMaps.Add(new GameMap
                        {
                            ArrangedGame = false,
                            MapName = "NPE_1.umap",
                            MapID = 1,
                            MapDisplayName = "Test Display Name",
                            MapDescription = "Test map description",
                            SplashImage = "test_splash.jpg",
                            HeroGUID = 0,
                            DeckGUID = 0,
                            SuggestedLevel = 0,
                            GameType = eMapGameType.MapGameType_Tutorial,
                            LootText = "Test Loot Text",
                            MinionText = "Test Minion Text",
                            Leaderboard = false,
                            NumWaves = 5,
                            NormalParTime = 5,
                            EliteParTime = 10,
                            FlagBots = false,
                            FlagRifts = false,
                            FlagBarbarian = true,
                            FlagChinese = true,
                            FlagFireFiends = true,
                            FlagNorthernClan = true,
                            FlagOrder = true,
                            FlagPirate = true,
                            FlagUnchained = true,
                            PresentationStyle = eMapPresentationStyle.Default,
                            SubBucketSuggestedLevelRange = ""
                            //Mobs - LIST object
                            //Bots - LIST object
                            //EndlessWaveRatingThresholds - List Object

                        });

                       

                        Send(handler, state, mGameMapList.SerializeMessage());

                        packetHandled = true;
                    }

                    if(message.GetType() == typeof(RequestSceneContent))
                    {
                        ResponseSceneContent mResponseSceneContent = new ResponseSceneContent();
                        mResponseSceneContent.RequestID = message.RequestID;
                        mResponseSceneContent.SessionToken = message.SessionToken;
                        mResponseSceneContent.SecurityToken = message.SecurityToken;


                        Send(handler, state, mResponseSceneContent.SerializeMessage());

                        packetHandled = true;
                    }

                    if(message.GetType() == typeof(RequestFullPlayerAccountPush))
                    {
                        Console.WriteLine("[-] Got RequestFullPlayerAccountPush");
                        PushPlayerAccount mPlayerAccount = new PushPlayerAccount
                        {
                            AccountSUID = 1,
                            PlayerLevel = 1,
                            Name = "PermaNull",
                            GuildName = "",
                            GuildTag = "",
                            IsCertifiedStreamer = false,
                            GuildID = 0,
                            SoftCurrency = 0,
                            HardCurrency = 0,
                            GibsCurrency = 0,
                            ExperiencePoints = 0,
                            EventCode = eAccountDataEventCodes.AccountDataEventCodes_None,
                            Value = 0,
                            IsRobotEmployee = true,
                            Avatar = 0,
                            Badge = 0,
                            Background = 0,
                            Title = 0,
                            IsDeckEditorAvailable = true,
                        };

                        mPlayerAccount.RequestID = message.RequestID;
                        mPlayerAccount.SessionToken = message.SessionToken;
                        mPlayerAccount.SecurityToken = message.SecurityToken;

                        Send(handler, state, mPlayerAccount.SerializeMessage());

                        

                        PushPlayerInventoryUpdate mPushPlayerInventoryUpdate = new PushPlayerInventoryUpdate();
                        mPushPlayerInventoryUpdate.RequestID = message.RequestID;
                        mPushPlayerInventoryUpdate.SessionToken = message.SessionToken;
                        mPushPlayerInventoryUpdate.SecurityToken = message.SecurityToken;
                     
                        InventoryEntry testEntry = new InventoryEntry();
                        testEntry.IsBanned = false;
                        testEntry.AlwaysOwned = true;
                        testEntry.Count = 1;
                        testEntry.DoesOwn = true;
                        testEntry.InventoryProtoGUID = 100040;
                        testEntry.IsUpgradable = true;
                        testEntry.InventoryProtoType = eInventoryProtoType.Trap;
                        testEntry.NewItem = false;
                        testEntry.Slots.Add(1);


                        InventoryEntry potion = new InventoryEntry();
                        potion.IsBanned = false;
                        potion.AlwaysOwned = false;
                        potion.Count = 0;
                        potion.DoesOwn = false;
                        potion.InventoryProtoGUID = 100959;
                        potion.IsUpgradable = false;
                        potion.InventoryProtoType = eInventoryProtoType.Consumable;
                        potion.NewItem = false;

                        mPushPlayerInventoryUpdate.Items.Add(testEntry);
                        mPushPlayerInventoryUpdate.Items.Add(potion);


                        Send(handler, state, mPushPlayerInventoryUpdate.SerializeMessage());

                        PushPlayerBucketProgress mPushPlayerBucketProgress = new PushPlayerBucketProgress();
                        mPushPlayerBucketProgress.RequestID = message.RequestID;
                        mPushPlayerBucketProgress.SecurityToken = message.SecurityToken;
                        mPushPlayerBucketProgress.SessionToken = message.SessionToken;

                        mPushPlayerBucketProgress.CurrentBucketID = 0;

                        Send(handler, state, mPushPlayerBucketProgress.SerializeMessage());

                        PushPlayerCampaignProgress mPushPlayerCampaignProgress = new PushPlayerCampaignProgress();
                        mPushPlayerCampaignProgress.SessionToken = message.SessionToken;
                        mPushPlayerCampaignProgress.SecurityToken = message.SecurityToken;
                        mPushPlayerCampaignProgress.RequestID = message.RequestID;

                        PlayerMissionProgressForNetwork pmpfn = new PlayerMissionProgressForNetwork();
                        pmpfn.MissionID = 1;
                        pmpfn.StarsEarned = 0;
                        pmpfn.Status = eMissionStatus.Started;
                        pmpfn.DeckID = 1;
                        pmpfn.CampaignID = 1;


                        mPushPlayerCampaignProgress.IsSurvivalUnlocked = true;
                        mPushPlayerCampaignProgress.IsSiegeUnlocked = false;
                        mPushPlayerCampaignProgress.IsWorkshopTaskComplete = false;
                        mPushPlayerCampaignProgress.CampaignID = 1;
                        mPushPlayerCampaignProgress.CraftedItemGUID = 0;
                        mPushPlayerCampaignProgress.MissionProgress.Add(pmpfn);

                       Send(handler, state, mPushPlayerCampaignProgress.SerializeMessage());

                        PushTutorialProgress mPushTutorialProgress = new PushTutorialProgress();
                        mPushTutorialProgress.RequestID = message.RequestID;
                        mPushTutorialProgress.SessionToken = message.SessionToken;
                        mPushTutorialProgress.SecurityToken = message.SecurityToken;

                        PacketTutorialProgress pPacketTutorialProgress = new PacketTutorialProgress();
                        pPacketTutorialProgress.InProgress = true;
                        pPacketTutorialProgress.IsComplete = false;
                        pPacketTutorialProgress.NextSection = 0;
                        pPacketTutorialProgress.SceneID = eSceneID.ProloguePage;
                        pPacketTutorialProgress.TabID = 0;
            

                        mPushTutorialProgress.TutorialProgress.Add(pPacketTutorialProgress);

                        Send(handler, state, mPushTutorialProgress.SerializeMessage());

                        PushPlayerKeystone mPushPlayerKeystone = new PushPlayerKeystone();
                        mPushPlayerKeystone.RequestID = message.RequestID;
                        mPushPlayerKeystone.SessionToken = message.SessionToken;
                        mPushPlayerKeystone.SecurityToken = message.SecurityToken;

                        KeystoneDetailPacket eKeyStoneDetailPacket = new KeystoneDetailPacket();
                        eKeyStoneDetailPacket.ID = 1;
                        eKeyStoneDetailPacket.IsNew = false;
                        eKeyStoneDetailPacket.Level = 1;
                        eKeyStoneDetailPacket.LivesRemaining = 5;
                        eKeyStoneDetailPacket.MapGUID = 1;
                        //eKeyStoneDetailPacket.ModifierGUIDs = 1;
                        eKeyStoneDetailPacket.ProtoGUID = 1;
                        eKeyStoneDetailPacket.RerollsRemaining = 5;
                        eKeyStoneDetailPacket.RunningScore = 0;
                        //eKeyStoneDetailPacket.UpdatedOn = 0;
                        mPushPlayerKeystone.Keystones.Add(eKeyStoneDetailPacket);

                        Send(handler, state, mPushPlayerKeystone.SerializeMessage());


                        packetHandled = true;
                    }

                    if(packetHandled == false)
                    {
                        Console.WriteLine("Packet was never picked up by a function. {0}\r\n", message.GetType());
                    }



                }

                recvDone.Set();
            }
        }
    }
}
