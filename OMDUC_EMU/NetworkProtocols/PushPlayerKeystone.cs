using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000662 RID: 1634
	public class PushPlayerKeystone : BotNetMessage
	{
		// Token: 0x0600390F RID: 14607 RVA: 0x0001F7F2 File Offset: 0x0001D9F2
		public PushPlayerKeystone()
		{
			this.InitRefTypes();
			base.PacketType = 706845900u;
		}

		// Token: 0x06003910 RID: 14608 RVA: 0x0001F80B File Offset: 0x0001DA0B
		public PushPlayerKeystone(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 706845900u;
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x06003911 RID: 14609 RVA: 0x0001F82B File Offset: 0x0001DA2B
		// (set) Token: 0x06003912 RID: 14610 RVA: 0x0001F833 File Offset: 0x0001DA33
		public List<KeystoneDetailPacket> Keystones { get; set; }

		// Token: 0x06003913 RID: 14611 RVA: 0x0010EDD0 File Offset: 0x0010CFD0
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
			ArrayManager.WriteListKeystoneDetailPacket(ref newArray, ref newSize, this.Keystones);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003914 RID: 14612 RVA: 0x0010EE50 File Offset: 0x0010D050
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Keystones = ArrayManager.ReadListKeystoneDetailPacket(data, ref num);
		}

		// Token: 0x06003915 RID: 14613 RVA: 0x0001F83C File Offset: 0x0001DA3C
		private void InitRefTypes()
		{
			this.Keystones = new List<KeystoneDetailPacket>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001E5A RID: 7770
		public const uint cPacketType = 706845900u;
	}
}
