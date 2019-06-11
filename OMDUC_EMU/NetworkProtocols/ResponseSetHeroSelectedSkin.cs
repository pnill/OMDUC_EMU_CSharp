using System;

namespace NetworkProtocols
{
	// Token: 0x0200057A RID: 1402
	public class ResponseSetHeroSelectedSkin : BotNetMessage
	{
		// Token: 0x06003036 RID: 12342 RVA: 0x00019A85 File Offset: 0x00017C85
		public ResponseSetHeroSelectedSkin()
		{
			this.InitRefTypes();
			base.PacketType = 1928530613u;
		}

		// Token: 0x06003037 RID: 12343 RVA: 0x00019A9E File Offset: 0x00017C9E
		public ResponseSetHeroSelectedSkin(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1928530613u;
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06003038 RID: 12344 RVA: 0x00019ABE File Offset: 0x00017CBE
		// (set) Token: 0x06003039 RID: 12345 RVA: 0x00019AC6 File Offset: 0x00017CC6
		public bool WasSet { get; set; }

		// Token: 0x0600303A RID: 12346 RVA: 0x00102048 File Offset: 0x00100248
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
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.WasSet);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600303B RID: 12347 RVA: 0x001020C8 File Offset: 0x001002C8
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.WasSet = ArrayManager.ReadBoolean(data, ref num);
		}

		// Token: 0x0600303C RID: 12348 RVA: 0x00019ACF File Offset: 0x00017CCF
		private void InitRefTypes()
		{
			this.WasSet = false;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001B80 RID: 7040
		public const uint cPacketType = 1928530613u;
	}
}
