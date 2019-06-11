using System;

namespace NetworkProtocols
{
	// Token: 0x020005FD RID: 1533
	public class RequestOfflineTutorialStarted : BotNetMessage
	{
		// Token: 0x0600355D RID: 13661 RVA: 0x0001CECD File Offset: 0x0001B0CD
		public RequestOfflineTutorialStarted()
		{
			this.InitRefTypes();
			base.PacketType = 3910894782u;
		}

		// Token: 0x0600355E RID: 13662 RVA: 0x0001CEE6 File Offset: 0x0001B0E6
		public RequestOfflineTutorialStarted(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3910894782u;
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x0600355F RID: 13663 RVA: 0x0001CF06 File Offset: 0x0001B106
		// (set) Token: 0x06003560 RID: 13664 RVA: 0x0001CF0E File Offset: 0x0001B10E
		public ulong GameMapID { get; set; }

		// Token: 0x06003561 RID: 13665 RVA: 0x00109170 File Offset: 0x00107370
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.GameMapID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003562 RID: 13666 RVA: 0x001091F0 File Offset: 0x001073F0
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.GameMapID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06003563 RID: 13667 RVA: 0x0001CF17 File Offset: 0x0001B117
		private void InitRefTypes()
		{
			this.GameMapID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001D27 RID: 7463
		public const uint cPacketType = 3910894782u;
	}
}
