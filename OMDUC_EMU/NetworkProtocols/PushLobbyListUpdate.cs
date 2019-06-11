using System;

namespace NetworkProtocols
{
	// Token: 0x020006C5 RID: 1733
	public class PushLobbyListUpdate : BotNetMessage
	{
		// Token: 0x06003E30 RID: 15920 RVA: 0x00022EE6 File Offset: 0x000210E6
		public PushLobbyListUpdate()
		{
			this.InitRefTypes();
			base.PacketType = 3468121880u;
		}

		// Token: 0x06003E31 RID: 15921 RVA: 0x00022EFF File Offset: 0x000210FF
		public PushLobbyListUpdate(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3468121880u;
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06003E32 RID: 15922 RVA: 0x00022F1F File Offset: 0x0002111F
		// (set) Token: 0x06003E33 RID: 15923 RVA: 0x00022F27 File Offset: 0x00021127
		public LobbyListUpdateData UpdateData { get; set; }

		// Token: 0x06003E34 RID: 15924 RVA: 0x001165B0 File Offset: 0x001147B0
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
			ArrayManager.WriteLobbyListUpdateData(ref newArray, ref newSize, this.UpdateData);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003E35 RID: 15925 RVA: 0x00116630 File Offset: 0x00114830
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.UpdateData = ArrayManager.ReadLobbyListUpdateData(data, ref num);
		}

		// Token: 0x06003E36 RID: 15926 RVA: 0x00022F30 File Offset: 0x00021130
		private void InitRefTypes()
		{
			this.UpdateData = new LobbyListUpdateData();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040020AB RID: 8363
		public const uint cPacketType = 3468121880u;
	}
}
