using System;

namespace NetworkProtocols
{
	// Token: 0x020006A3 RID: 1699
	public class RequestLobbySelectPlayerSkin : BotNetMessage
	{
		// Token: 0x06003B97 RID: 15255 RVA: 0x000214F0 File Offset: 0x0001F6F0
		public RequestLobbySelectPlayerSkin()
		{
			this.InitRefTypes();
			base.PacketType = 2057406401u;
		}

		// Token: 0x06003B98 RID: 15256 RVA: 0x00021509 File Offset: 0x0001F709
		public RequestLobbySelectPlayerSkin(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2057406401u;
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x06003B99 RID: 15257 RVA: 0x00021529 File Offset: 0x0001F729
		// (set) Token: 0x06003B9A RID: 15258 RVA: 0x00021531 File Offset: 0x0001F731
		public ulong LobbyID { get; set; }

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06003B9B RID: 15259 RVA: 0x0002153A File Offset: 0x0001F73A
		// (set) Token: 0x06003B9C RID: 15260 RVA: 0x00021542 File Offset: 0x0001F742
		public ulong SelectedSkin { get; set; }

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06003B9D RID: 15261 RVA: 0x0002154B File Offset: 0x0001F74B
		// (set) Token: 0x06003B9E RID: 15262 RVA: 0x00021553 File Offset: 0x0001F753
		public ulong HeroicDyeUnlockID { get; set; }

		// Token: 0x06003B9F RID: 15263 RVA: 0x00112BF8 File Offset: 0x00110DF8
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.SelectedSkin);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.HeroicDyeUnlockID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003BA0 RID: 15264 RVA: 0x00112C94 File Offset: 0x00110E94
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
			this.SelectedSkin = ArrayManager.ReadUInt64(data, ref num);
			this.HeroicDyeUnlockID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06003BA1 RID: 15265 RVA: 0x0002155C File Offset: 0x0001F75C
		private void InitRefTypes()
		{
			this.LobbyID = 0UL;
			this.SelectedSkin = 0UL;
			this.HeroicDyeUnlockID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001F95 RID: 8085
		public const uint cPacketType = 2057406401u;
	}
}
