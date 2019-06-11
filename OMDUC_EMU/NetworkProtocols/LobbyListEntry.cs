using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020006AB RID: 1707
	public class LobbyListEntry
	{
		// Token: 0x06003BDD RID: 15325 RVA: 0x00021876 File Offset: 0x0001FA76
		public LobbyListEntry()
		{
			this.InitRefTypes();
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x06003BDE RID: 15326 RVA: 0x00021884 File Offset: 0x0001FA84
		// (set) Token: 0x06003BDF RID: 15327 RVA: 0x0002188C File Offset: 0x0001FA8C
		public DateTime TimeCreated { get; set; }

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06003BE0 RID: 15328 RVA: 0x00021895 File Offset: 0x0001FA95
		// (set) Token: 0x06003BE1 RID: 15329 RVA: 0x0002189D File Offset: 0x0001FA9D
		public ulong LobbyID { get; set; }

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06003BE2 RID: 15330 RVA: 0x000218A6 File Offset: 0x0001FAA6
		// (set) Token: 0x06003BE3 RID: 15331 RVA: 0x000218AE File Offset: 0x0001FAAE
		public ulong OwnerSessionToken { get; set; }

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06003BE4 RID: 15332 RVA: 0x000218B7 File Offset: 0x0001FAB7
		// (set) Token: 0x06003BE5 RID: 15333 RVA: 0x000218BF File Offset: 0x0001FABF
		public uint MemberCount { get; set; }

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06003BE6 RID: 15334 RVA: 0x000218C8 File Offset: 0x0001FAC8
		// (set) Token: 0x06003BE7 RID: 15335 RVA: 0x000218D0 File Offset: 0x0001FAD0
		public int LobbyCapacity { get; set; }

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06003BE8 RID: 15336 RVA: 0x000218D9 File Offset: 0x0001FAD9
		// (set) Token: 0x06003BE9 RID: 15337 RVA: 0x000218E1 File Offset: 0x0001FAE1
		public ulong GameMapGUID { get; set; }

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06003BEA RID: 15338 RVA: 0x000218EA File Offset: 0x0001FAEA
		// (set) Token: 0x06003BEB RID: 15339 RVA: 0x000218F2 File Offset: 0x0001FAF2
		public eGameType LobbyGameType { get; set; }

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06003BEC RID: 15340 RVA: 0x000218FB File Offset: 0x0001FAFB
		// (set) Token: 0x06003BED RID: 15341 RVA: 0x00021903 File Offset: 0x0001FB03
		public bool IsPasswordProtected { get; set; }

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06003BEE RID: 15342 RVA: 0x0002190C File Offset: 0x0001FB0C
		// (set) Token: 0x06003BEF RID: 15343 RVA: 0x00021914 File Offset: 0x0001FB14
		public string OwnerName { get; set; }

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06003BF0 RID: 15344 RVA: 0x0002191D File Offset: 0x0001FB1D
		// (set) Token: 0x06003BF1 RID: 15345 RVA: 0x00021925 File Offset: 0x0001FB25
		public string OwnerGuildTag { get; set; }

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06003BF2 RID: 15346 RVA: 0x0002192E File Offset: 0x0001FB2E
		// (set) Token: 0x06003BF3 RID: 15347 RVA: 0x00021936 File Offset: 0x0001FB36
		public string LobbyDescription { get; set; }

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06003BF4 RID: 15348 RVA: 0x0002193F File Offset: 0x0001FB3F
		// (set) Token: 0x06003BF5 RID: 15349 RVA: 0x00021947 File Offset: 0x0001FB47
		public ulong KeystoneProtoGUID { get; set; }

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06003BF6 RID: 15350 RVA: 0x00021950 File Offset: 0x0001FB50
		// (set) Token: 0x06003BF7 RID: 15351 RVA: 0x00021958 File Offset: 0x0001FB58
		public int KeystoneLevel { get; set; }

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06003BF8 RID: 15352 RVA: 0x00021961 File Offset: 0x0001FB61
		// (set) Token: 0x06003BF9 RID: 15353 RVA: 0x00021969 File Offset: 0x0001FB69
		public List<ulong> KeystoneModifierGUIDs { get; set; }

		// Token: 0x06003BFA RID: 15354 RVA: 0x001133FC File Offset: 0x001115FC
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteDateTime(ref newArray, ref newSize, this.TimeCreated);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.LobbyID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.OwnerSessionToken);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.MemberCount);
			ArrayManager.WriteInt32(ref newArray, ref newSize, this.LobbyCapacity);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.GameMapGUID);
			ArrayManager.WriteeGameType(ref newArray, ref newSize, this.LobbyGameType);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsPasswordProtected);
			ArrayManager.WriteString(ref newArray, ref newSize, this.OwnerName);
			ArrayManager.WriteString(ref newArray, ref newSize, this.OwnerGuildTag);
			ArrayManager.WriteString(ref newArray, ref newSize, this.LobbyDescription);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.KeystoneProtoGUID);
			ArrayManager.WriteInt32(ref newArray, ref newSize, this.KeystoneLevel);
			ArrayManager.WriteListUInt64(ref newArray, ref newSize, this.KeystoneModifierGUIDs);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003BFB RID: 15355 RVA: 0x001134EC File Offset: 0x001116EC
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.TimeCreated = ArrayManager.ReadDateTime(data, ref num);
			this.LobbyID = ArrayManager.ReadUInt64(data, ref num);
			this.OwnerSessionToken = ArrayManager.ReadUInt64(data, ref num);
			this.MemberCount = ArrayManager.ReadUInt32(data, ref num);
			this.LobbyCapacity = ArrayManager.ReadInt32(data, ref num);
			this.GameMapGUID = ArrayManager.ReadUInt64(data, ref num);
			this.LobbyGameType = ArrayManager.ReadeGameType(data, ref num);
			this.IsPasswordProtected = ArrayManager.ReadBoolean(data, ref num);
			this.OwnerName = ArrayManager.ReadString(data, ref num);
			this.OwnerGuildTag = ArrayManager.ReadString(data, ref num);
			this.LobbyDescription = ArrayManager.ReadString(data, ref num);
			this.KeystoneProtoGUID = ArrayManager.ReadUInt64(data, ref num);
			this.KeystoneLevel = ArrayManager.ReadInt32(data, ref num);
			this.KeystoneModifierGUIDs = ArrayManager.ReadListUInt64(data, ref num);
		}

		// Token: 0x06003BFC RID: 15356 RVA: 0x001135C0 File Offset: 0x001117C0
		private void InitRefTypes()
		{
			this.TimeCreated = default(DateTime);
			this.LobbyID = 0UL;
			this.OwnerSessionToken = 0UL;
			this.MemberCount = 0u;
			this.LobbyCapacity = 0;
			this.GameMapGUID = 0UL;
			this.LobbyGameType = eGameType.None;
			this.IsPasswordProtected = false;
			this.OwnerName = string.Empty;
			this.OwnerGuildTag = string.Empty;
			this.LobbyDescription = string.Empty;
			this.KeystoneProtoGUID = 0UL;
			this.KeystoneLevel = 0;
			this.KeystoneModifierGUIDs = new List<ulong>();
		}
	}
}
