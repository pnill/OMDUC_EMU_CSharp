using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000572 RID: 1394
	public class PushPlayerAccount : BotNetMessage
	{
		// Token: 0x06002FA7 RID: 12199 RVA: 0x0001955C File Offset: 0x0001775C
		public PushPlayerAccount()
		{
			this.InitRefTypes();
			base.PacketType = 3872412131u;
		}

		// Token: 0x06002FA8 RID: 12200 RVA: 0x00019575 File Offset: 0x00017775
		public PushPlayerAccount(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3872412131u;
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06002FA9 RID: 12201 RVA: 0x00019595 File Offset: 0x00017795
		// (set) Token: 0x06002FAA RID: 12202 RVA: 0x0001959D File Offset: 0x0001779D
		public ulong AccountSUID { get; set; }

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06002FAB RID: 12203 RVA: 0x000195A6 File Offset: 0x000177A6
		// (set) Token: 0x06002FAC RID: 12204 RVA: 0x000195AE File Offset: 0x000177AE
		public string Name { get; set; }

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06002FAD RID: 12205 RVA: 0x000195B7 File Offset: 0x000177B7
		// (set) Token: 0x06002FAE RID: 12206 RVA: 0x000195BF File Offset: 0x000177BF
		public ulong GuildID { get; set; }

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06002FAF RID: 12207 RVA: 0x000195C8 File Offset: 0x000177C8
		// (set) Token: 0x06002FB0 RID: 12208 RVA: 0x000195D0 File Offset: 0x000177D0
		public string GuildName { get; set; }

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06002FB1 RID: 12209 RVA: 0x000195D9 File Offset: 0x000177D9
		// (set) Token: 0x06002FB2 RID: 12210 RVA: 0x000195E1 File Offset: 0x000177E1
		public string GuildTag { get; set; }

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06002FB3 RID: 12211 RVA: 0x000195EA File Offset: 0x000177EA
		// (set) Token: 0x06002FB4 RID: 12212 RVA: 0x000195F2 File Offset: 0x000177F2
		public uint SoftCurrency { get; set; }

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06002FB5 RID: 12213 RVA: 0x000195FB File Offset: 0x000177FB
		// (set) Token: 0x06002FB6 RID: 12214 RVA: 0x00019603 File Offset: 0x00017803
		public uint HardCurrency { get; set; }

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06002FB7 RID: 12215 RVA: 0x0001960C File Offset: 0x0001780C
		// (set) Token: 0x06002FB8 RID: 12216 RVA: 0x00019614 File Offset: 0x00017814
		public uint GibsCurrency { get; set; }

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06002FB9 RID: 12217 RVA: 0x0001961D File Offset: 0x0001781D
		// (set) Token: 0x06002FBA RID: 12218 RVA: 0x00019625 File Offset: 0x00017825
		public uint PlayerLevel { get; set; }

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06002FBB RID: 12219 RVA: 0x0001962E File Offset: 0x0001782E
		// (set) Token: 0x06002FBC RID: 12220 RVA: 0x00019636 File Offset: 0x00017836
		public uint ExperiencePoints { get; set; }

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06002FBD RID: 12221 RVA: 0x0001963F File Offset: 0x0001783F
		// (set) Token: 0x06002FBE RID: 12222 RVA: 0x00019647 File Offset: 0x00017847
		public eAccountDataEventCodes EventCode { get; set; }

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06002FBF RID: 12223 RVA: 0x00019650 File Offset: 0x00017850
		// (set) Token: 0x06002FC0 RID: 12224 RVA: 0x00019658 File Offset: 0x00017858
		public ulong Value { get; set; }

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06002FC1 RID: 12225 RVA: 0x00019661 File Offset: 0x00017861
		// (set) Token: 0x06002FC2 RID: 12226 RVA: 0x00019669 File Offset: 0x00017869
		public bool IsRobotEmployee { get; set; }

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06002FC3 RID: 12227 RVA: 0x00019672 File Offset: 0x00017872
		// (set) Token: 0x06002FC4 RID: 12228 RVA: 0x0001967A File Offset: 0x0001787A
		public ulong Avatar { get; set; }

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06002FC5 RID: 12229 RVA: 0x00019683 File Offset: 0x00017883
		// (set) Token: 0x06002FC6 RID: 12230 RVA: 0x0001968B File Offset: 0x0001788B
		public ulong Badge { get; set; }

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06002FC7 RID: 12231 RVA: 0x00019694 File Offset: 0x00017894
		// (set) Token: 0x06002FC8 RID: 12232 RVA: 0x0001969C File Offset: 0x0001789C
		public ulong Background { get; set; }

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06002FC9 RID: 12233 RVA: 0x000196A5 File Offset: 0x000178A5
		// (set) Token: 0x06002FCA RID: 12234 RVA: 0x000196AD File Offset: 0x000178AD
		public ulong Title { get; set; }

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06002FCB RID: 12235 RVA: 0x000196B6 File Offset: 0x000178B6
		// (set) Token: 0x06002FCC RID: 12236 RVA: 0x000196BE File Offset: 0x000178BE
		public bool IsDeckEditorAvailable { get; set; }

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06002FCD RID: 12237 RVA: 0x000196C7 File Offset: 0x000178C7
		// (set) Token: 0x06002FCE RID: 12238 RVA: 0x000196CF File Offset: 0x000178CF
		public List<MMREntry> PlayerMMR { get; set; }

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06002FCF RID: 12239 RVA: 0x000196D8 File Offset: 0x000178D8
		// (set) Token: 0x06002FD0 RID: 12240 RVA: 0x000196E0 File Offset: 0x000178E0
		public bool IsCertifiedStreamer { get; set; }

		// Token: 0x06002FD1 RID: 12241 RVA: 0x00101400 File Offset: 0x000FF600
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt32(ref newArray, ref newSize, base.PacketType);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, base.SessionToken);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, base.SecurityToken);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, base.RequestID);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, 0u);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, 0u);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.AccountSUID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Name);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.GuildID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GuildName);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GuildTag);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.SoftCurrency);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.HardCurrency);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.GibsCurrency);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.PlayerLevel);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.ExperiencePoints);
			ArrayManager.WriteeAccountDataEventCodes(ref newArray, ref newSize, this.EventCode);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.Value);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsRobotEmployee);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.Avatar);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.Badge);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.Background);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.Title);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsDeckEditorAvailable);
			ArrayManager.WriteListMMREntry(ref newArray, ref newSize, this.PlayerMMR);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsCertifiedStreamer);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002FD2 RID: 12242 RVA: 0x0010159C File Offset: 0x000FF79C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.Name = ArrayManager.ReadString(data, ref num);
			this.GuildID = ArrayManager.ReadUInt64(data, ref num);
			this.GuildName = ArrayManager.ReadString(data, ref num);
			this.GuildTag = ArrayManager.ReadString(data, ref num);
			this.SoftCurrency = ArrayManager.ReadUInt32(data, ref num);
			this.HardCurrency = ArrayManager.ReadUInt32(data, ref num);
			this.GibsCurrency = ArrayManager.ReadUInt32(data, ref num);
			this.PlayerLevel = ArrayManager.ReadUInt32(data, ref num);
			this.ExperiencePoints = ArrayManager.ReadUInt32(data, ref num);
			this.EventCode = ArrayManager.ReadeAccountDataEventCodes(data, ref num);
			this.Value = ArrayManager.ReadUInt64(data, ref num);
			this.IsRobotEmployee = ArrayManager.ReadBoolean(data, ref num);
			this.Avatar = ArrayManager.ReadUInt64(data, ref num);
			this.Badge = ArrayManager.ReadUInt64(data, ref num);
			this.Background = ArrayManager.ReadUInt64(data, ref num);
			this.Title = ArrayManager.ReadUInt64(data, ref num);
			this.IsDeckEditorAvailable = ArrayManager.ReadBoolean(data, ref num);
			this.PlayerMMR = ArrayManager.ReadListMMREntry(data, ref num);
			this.IsCertifiedStreamer = ArrayManager.ReadBoolean(data, ref num);
		}

		// Token: 0x06002FD3 RID: 12243 RVA: 0x00101710 File Offset: 0x000FF910
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.Name = string.Empty;
			this.GuildID = 0UL;
			this.GuildName = string.Empty;
			this.GuildTag = string.Empty;
			this.SoftCurrency = 0u;
			this.HardCurrency = 0u;
			this.GibsCurrency = 0u;
			this.PlayerLevel = 0u;
			this.ExperiencePoints = 0u;
			this.EventCode = eAccountDataEventCodes.AccountDataEventCodes_None;
			this.Value = 0UL;
			this.IsRobotEmployee = false;
			this.Avatar = 0UL;
			this.Badge = 0UL;
			this.Background = 0UL;
			this.Title = 0UL;
			this.IsDeckEditorAvailable = false;
			this.PlayerMMR = new List<MMREntry>();
			this.IsCertifiedStreamer = false;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001B46 RID: 6982
		public const uint cPacketType = 3872412131u;
	}
}
