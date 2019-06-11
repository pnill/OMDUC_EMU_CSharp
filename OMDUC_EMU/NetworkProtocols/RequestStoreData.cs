using System;

namespace NetworkProtocols
{
	// Token: 0x02000594 RID: 1428
	public class RequestStoreData : BotNetMessage
	{
		// Token: 0x0600315B RID: 12635 RVA: 0x0001A790 File Offset: 0x00018990
		public RequestStoreData()
		{
			this.InitRefTypes();
			base.PacketType = 257278965u;
		}

		// Token: 0x0600315C RID: 12636 RVA: 0x0001A7A9 File Offset: 0x000189A9
		public RequestStoreData(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 257278965u;
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x0600315D RID: 12637 RVA: 0x0001A7C9 File Offset: 0x000189C9
		// (set) Token: 0x0600315E RID: 12638 RVA: 0x0001A7D1 File Offset: 0x000189D1
		public string Locale { get; set; }

		// Token: 0x0600315F RID: 12639 RVA: 0x00103C50 File Offset: 0x00101E50
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.Locale);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003160 RID: 12640 RVA: 0x00103CD0 File Offset: 0x00101ED0
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Locale = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x06003161 RID: 12641 RVA: 0x0001A7DA File Offset: 0x000189DA
		private void InitRefTypes()
		{
			this.Locale = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001BEA RID: 7146
		public const uint cPacketType = 257278965u;
	}
}
