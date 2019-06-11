using System;

namespace NetworkProtocols
{
	// Token: 0x020006BD RID: 1725
	public class RequestLobbySetVisibility : BotNetMessage
	{
		// Token: 0x06003DDA RID: 15834 RVA: 0x00022A8C File Offset: 0x00020C8C
		public RequestLobbySetVisibility()
		{
			this.InitRefTypes();
			base.PacketType = 1016889151u;
		}

		// Token: 0x06003DDB RID: 15835 RVA: 0x00022AA5 File Offset: 0x00020CA5
		public RequestLobbySetVisibility(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1016889151u;
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06003DDC RID: 15836 RVA: 0x00022AC5 File Offset: 0x00020CC5
		// (set) Token: 0x06003DDD RID: 15837 RVA: 0x00022ACD File Offset: 0x00020CCD
		public ulong LobbyID { get; set; }

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06003DDE RID: 15838 RVA: 0x00022AD6 File Offset: 0x00020CD6
		// (set) Token: 0x06003DDF RID: 15839 RVA: 0x00022ADE File Offset: 0x00020CDE
		public bool IsVisible { get; set; }

		// Token: 0x06003DE0 RID: 15840 RVA: 0x00115CC4 File Offset: 0x00113EC4
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
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsVisible);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003DE1 RID: 15841 RVA: 0x00115D50 File Offset: 0x00113F50
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
			this.IsVisible = ArrayManager.ReadBoolean(data, ref num);
		}

		// Token: 0x06003DE2 RID: 15842 RVA: 0x00022AE7 File Offset: 0x00020CE7
		private void InitRefTypes()
		{
			this.LobbyID = 0UL;
			this.IsVisible = false;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400208C RID: 8332
		public const uint cPacketType = 1016889151u;
	}
}
