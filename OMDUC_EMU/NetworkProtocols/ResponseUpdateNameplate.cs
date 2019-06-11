using System;

namespace NetworkProtocols
{
	// Token: 0x02000664 RID: 1636
	public class ResponseUpdateNameplate : BotNetMessage
	{
		// Token: 0x06003923 RID: 14627 RVA: 0x0001F8F6 File Offset: 0x0001DAF6
		public ResponseUpdateNameplate()
		{
			this.InitRefTypes();
			base.PacketType = 4027114090u;
		}

		// Token: 0x06003924 RID: 14628 RVA: 0x0001F90F File Offset: 0x0001DB0F
		public ResponseUpdateNameplate(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 4027114090u;
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06003925 RID: 14629 RVA: 0x0001F92F File Offset: 0x0001DB2F
		// (set) Token: 0x06003926 RID: 14630 RVA: 0x0001F937 File Offset: 0x0001DB37
		public eNameplateOperationStatus Status { get; set; }

		// Token: 0x06003927 RID: 14631 RVA: 0x0010EFF8 File Offset: 0x0010D1F8
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
			ArrayManager.WriteeNameplateOperationStatus(ref newArray, ref newSize, this.Status);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003928 RID: 14632 RVA: 0x0010F078 File Offset: 0x0010D278
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Status = ArrayManager.ReadeNameplateOperationStatus(data, ref num);
		}

		// Token: 0x06003929 RID: 14633 RVA: 0x0001F940 File Offset: 0x0001DB40
		private void InitRefTypes()
		{
			this.Status = eNameplateOperationStatus.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001E61 RID: 7777
		public const uint cPacketType = 4027114090u;
	}
}
