using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x0200069B RID: 1691
	public class PushLobbyJoined : BotNetMessage
	{
		// Token: 0x06003B43 RID: 15171 RVA: 0x000210BB File Offset: 0x0001F2BB
		public PushLobbyJoined()
		{
			this.InitRefTypes();
			base.PacketType = 2556482078u;
		}

		// Token: 0x06003B44 RID: 15172 RVA: 0x000210D4 File Offset: 0x0001F2D4
		public PushLobbyJoined(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2556482078u;
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06003B45 RID: 15173 RVA: 0x000210F4 File Offset: 0x0001F2F4
		// (set) Token: 0x06003B46 RID: 15174 RVA: 0x000210FC File Offset: 0x0001F2FC
		public ulong LobbyID { get; set; }

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06003B47 RID: 15175 RVA: 0x00021105 File Offset: 0x0001F305
		// (set) Token: 0x06003B48 RID: 15176 RVA: 0x0002110D File Offset: 0x0001F30D
		public string Name { get; set; }

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06003B49 RID: 15177 RVA: 0x00021116 File Offset: 0x0001F316
		// (set) Token: 0x06003B4A RID: 15178 RVA: 0x0002111E File Offset: 0x0001F31E
		public eGameType GameType { get; set; }

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x06003B4B RID: 15179 RVA: 0x00021127 File Offset: 0x0001F327
		// (set) Token: 0x06003B4C RID: 15180 RVA: 0x0002112F File Offset: 0x0001F32F
		public ulong OwnerSessionToken { get; set; }

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06003B4D RID: 15181 RVA: 0x00021138 File Offset: 0x0001F338
		// (set) Token: 0x06003B4E RID: 15182 RVA: 0x00021140 File Offset: 0x0001F340
		public eLobbyState CurrentState { get; set; }

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06003B4F RID: 15183 RVA: 0x00021149 File Offset: 0x0001F349
		// (set) Token: 0x06003B50 RID: 15184 RVA: 0x00021151 File Offset: 0x0001F351
		public List<ulong> KeystoneModifierGUIDs { get; set; }

		// Token: 0x06003B51 RID: 15185 RVA: 0x0011232C File Offset: 0x0011052C
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.Name);
			ArrayManager.WriteeGameType(ref newArray, ref newSize, this.GameType);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.OwnerSessionToken);
			ArrayManager.WriteeLobbyState(ref newArray, ref newSize, this.CurrentState);
			ArrayManager.WriteListUInt64(ref newArray, ref newSize, this.KeystoneModifierGUIDs);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003B52 RID: 15186 RVA: 0x001123F4 File Offset: 0x001105F4
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
			this.Name = ArrayManager.ReadString(data, ref num);
			this.GameType = ArrayManager.ReadeGameType(data, ref num);
			this.OwnerSessionToken = ArrayManager.ReadUInt64(data, ref num);
			this.CurrentState = ArrayManager.ReadeLobbyState(data, ref num);
			this.KeystoneModifierGUIDs = ArrayManager.ReadListUInt64(data, ref num);
		}

		// Token: 0x06003B53 RID: 15187 RVA: 0x0002115A File Offset: 0x0001F35A
		private void InitRefTypes()
		{
			this.LobbyID = 0UL;
			this.Name = string.Empty;
			this.GameType = eGameType.None;
			this.OwnerSessionToken = 0UL;
			this.CurrentState = eLobbyState.LobbyState_None;
			this.KeystoneModifierGUIDs = new List<ulong>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001F77 RID: 8055
		public const uint cPacketType = 2556482078u;
	}
}
