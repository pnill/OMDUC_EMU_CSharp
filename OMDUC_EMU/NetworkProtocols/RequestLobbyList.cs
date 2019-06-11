using System;

namespace NetworkProtocols
{
	// Token: 0x02000691 RID: 1681
	public class RequestLobbyList : BotNetMessage
	{
		// Token: 0x06003AE1 RID: 15073 RVA: 0x00020BF8 File Offset: 0x0001EDF8
		public RequestLobbyList()
		{
			this.InitRefTypes();
			base.PacketType = 1943499147u;
		}

		// Token: 0x06003AE2 RID: 15074 RVA: 0x00020C11 File Offset: 0x0001EE11
		public RequestLobbyList(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1943499147u;
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x06003AE3 RID: 15075 RVA: 0x00020C31 File Offset: 0x0001EE31
		// (set) Token: 0x06003AE4 RID: 15076 RVA: 0x00020C39 File Offset: 0x0001EE39
		public eGameType GameType { get; set; }

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x06003AE5 RID: 15077 RVA: 0x00020C42 File Offset: 0x0001EE42
		// (set) Token: 0x06003AE6 RID: 15078 RVA: 0x00020C4A File Offset: 0x0001EE4A
		public DateTime SplitTime { get; set; }

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x06003AE7 RID: 15079 RVA: 0x00020C53 File Offset: 0x0001EE53
		// (set) Token: 0x06003AE8 RID: 15080 RVA: 0x00020C5B File Offset: 0x0001EE5B
		public eLobbyListSplitType SplitType { get; set; }

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x06003AE9 RID: 15081 RVA: 0x00020C64 File Offset: 0x0001EE64
		// (set) Token: 0x06003AEA RID: 15082 RVA: 0x00020C6C File Offset: 0x0001EE6C
		public int RequestCount { get; set; }

		// Token: 0x06003AEB RID: 15083 RVA: 0x0011191C File Offset: 0x0010FB1C
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
			ArrayManager.WriteeGameType(ref newArray, ref newSize, this.GameType);
			ArrayManager.WriteDateTime(ref newArray, ref newSize, this.SplitTime);
			ArrayManager.WriteeLobbyListSplitType(ref newArray, ref newSize, this.SplitType);
			ArrayManager.WriteInt32(ref newArray, ref newSize, this.RequestCount);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003AEC RID: 15084 RVA: 0x001119C8 File Offset: 0x0010FBC8
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.GameType = ArrayManager.ReadeGameType(data, ref num);
			this.SplitTime = ArrayManager.ReadDateTime(data, ref num);
			this.SplitType = ArrayManager.ReadeLobbyListSplitType(data, ref num);
			this.RequestCount = ArrayManager.ReadInt32(data, ref num);
		}

		// Token: 0x06003AED RID: 15085 RVA: 0x00111A5C File Offset: 0x0010FC5C
		private void InitRefTypes()
		{
			this.GameType = eGameType.None;
			this.SplitTime = default(DateTime);
			this.SplitType = eLobbyListSplitType.LobbyListSplit_Before;
			this.RequestCount = 0;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001F55 RID: 8021
		public const uint cPacketType = 1943499147u;
	}
}
