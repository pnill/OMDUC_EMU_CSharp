using System;

namespace NetworkProtocols
{
	// Token: 0x02000722 RID: 1826
	public class FriendRequestAccepted : BotNetMessage
	{
		// Token: 0x060040BD RID: 16573 RVA: 0x00024DE9 File Offset: 0x00022FE9
		public FriendRequestAccepted()
		{
			this.InitRefTypes();
			base.PacketType = 2710198925u;
		}

		// Token: 0x060040BE RID: 16574 RVA: 0x00024E02 File Offset: 0x00023002
		public FriendRequestAccepted(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2710198925u;
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x060040BF RID: 16575 RVA: 0x00024E22 File Offset: 0x00023022
		// (set) Token: 0x060040C0 RID: 16576 RVA: 0x00024E2A File Offset: 0x0002302A
		public ulong RecipientAccountSUID { get; set; }

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x060040C1 RID: 16577 RVA: 0x00024E33 File Offset: 0x00023033
		// (set) Token: 0x060040C2 RID: 16578 RVA: 0x00024E3B File Offset: 0x0002303B
		public string RecipientName { get; set; }

		// Token: 0x060040C3 RID: 16579 RVA: 0x0011D9F4 File Offset: 0x0011BBF4
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.RecipientAccountSUID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.RecipientName);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060040C4 RID: 16580 RVA: 0x0011DA80 File Offset: 0x0011BC80
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.RecipientAccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.RecipientName = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x060040C5 RID: 16581 RVA: 0x00024E44 File Offset: 0x00023044
		private void InitRefTypes()
		{
			this.RecipientAccountSUID = 0UL;
			this.RecipientName = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400222C RID: 8748
		public const uint cPacketType = 2710198925u;
	}
}
