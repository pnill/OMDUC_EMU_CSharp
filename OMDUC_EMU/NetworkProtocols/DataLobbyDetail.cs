using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020006AD RID: 1709
	public class DataLobbyDetail : BotNetMessage
	{
		// Token: 0x06003C04 RID: 15364 RVA: 0x000219D0 File Offset: 0x0001FBD0
		public DataLobbyDetail()
		{
			this.InitRefTypes();
			base.PacketType = 2990657820u;
		}

		// Token: 0x06003C05 RID: 15365 RVA: 0x000219E9 File Offset: 0x0001FBE9
		public DataLobbyDetail(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2990657820u;
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06003C06 RID: 15366 RVA: 0x00021A09 File Offset: 0x0001FC09
		// (set) Token: 0x06003C07 RID: 15367 RVA: 0x00021A11 File Offset: 0x0001FC11
		public ulong LobbyID { get; set; }

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06003C08 RID: 15368 RVA: 0x00021A1A File Offset: 0x0001FC1A
		// (set) Token: 0x06003C09 RID: 15369 RVA: 0x00021A22 File Offset: 0x0001FC22
		public eGameType GameType { get; set; }

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06003C0A RID: 15370 RVA: 0x00021A2B File Offset: 0x0001FC2B
		// (set) Token: 0x06003C0B RID: 15371 RVA: 0x00021A33 File Offset: 0x0001FC33
		public ulong OwnerSessionToken { get; set; }

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06003C0C RID: 15372 RVA: 0x00021A3C File Offset: 0x0001FC3C
		// (set) Token: 0x06003C0D RID: 15373 RVA: 0x00021A44 File Offset: 0x0001FC44
		public string Name { get; set; }

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06003C0E RID: 15374 RVA: 0x00021A4D File Offset: 0x0001FC4D
		// (set) Token: 0x06003C0F RID: 15375 RVA: 0x00021A55 File Offset: 0x0001FC55
		public eLobbyState CurrentState { get; set; }

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06003C10 RID: 15376 RVA: 0x00021A5E File Offset: 0x0001FC5E
		// (set) Token: 0x06003C11 RID: 15377 RVA: 0x00021A66 File Offset: 0x0001FC66
		public List<GameLobbyMember> Members { get; set; }

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06003C12 RID: 15378 RVA: 0x00021A6F File Offset: 0x0001FC6F
		// (set) Token: 0x06003C13 RID: 15379 RVA: 0x00021A77 File Offset: 0x0001FC77
		public ulong GameMapGUID { get; set; }

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06003C14 RID: 15380 RVA: 0x00021A80 File Offset: 0x0001FC80
		// (set) Token: 0x06003C15 RID: 15381 RVA: 0x00021A88 File Offset: 0x0001FC88
		public string Description { get; set; }

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x06003C16 RID: 15382 RVA: 0x00021A91 File Offset: 0x0001FC91
		// (set) Token: 0x06003C17 RID: 15383 RVA: 0x00021A99 File Offset: 0x0001FC99
		public bool IsPublicLobby { get; set; }

		// Token: 0x06003C18 RID: 15384 RVA: 0x00113734 File Offset: 0x00111934
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.LobbyID);
			ArrayManager.WriteeGameType(ref newArray, ref newSize, this.GameType);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.OwnerSessionToken);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Name);
			ArrayManager.WriteeLobbyState(ref newArray, ref newSize, this.CurrentState);
			ArrayManager.WriteListGameLobbyMember(ref newArray, ref newSize, this.Members);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.GameMapGUID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Description);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsPublicLobby);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003C19 RID: 15385 RVA: 0x0011382C File Offset: 0x00111A2C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.LobbyID = ArrayManager.ReadUInt64(data, ref num);
			this.GameType = ArrayManager.ReadeGameType(data, ref num);
			this.OwnerSessionToken = ArrayManager.ReadUInt64(data, ref num);
			this.Name = ArrayManager.ReadString(data, ref num);
			this.CurrentState = ArrayManager.ReadeLobbyState(data, ref num);
			this.Members = ArrayManager.ReadListGameLobbyMember(data, ref num);
			this.GameMapGUID = ArrayManager.ReadUInt64(data, ref num);
			this.Description = ArrayManager.ReadString(data, ref num);
			this.IsPublicLobby = ArrayManager.ReadBoolean(data, ref num);
		}

		// Token: 0x06003C1A RID: 15386 RVA: 0x00113904 File Offset: 0x00111B04
		private void InitRefTypes()
		{
			this.LobbyID = 0UL;
			this.GameType = eGameType.None;
			this.OwnerSessionToken = 0UL;
			this.Name = string.Empty;
			this.CurrentState = eLobbyState.LobbyState_None;
			this.Members = new List<GameLobbyMember>();
			this.GameMapGUID = 0UL;
			this.Description = string.Empty;
			this.IsPublicLobby = false;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001FBC RID: 8124
		public const uint cPacketType = 2990657820u;
	}
}
