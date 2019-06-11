using System;

namespace NetworkProtocols
{
	// Token: 0x0200072E RID: 1838
	public class RequestCheckGuildTag : BotNetMessage
	{
		// Token: 0x06004123 RID: 16675 RVA: 0x00025321 File Offset: 0x00023521
		public RequestCheckGuildTag()
		{
			this.InitRefTypes();
			base.PacketType = 561375384u;
		}

		// Token: 0x06004124 RID: 16676 RVA: 0x0002533A File Offset: 0x0002353A
		public RequestCheckGuildTag(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 561375384u;
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06004125 RID: 16677 RVA: 0x0002535A File Offset: 0x0002355A
		// (set) Token: 0x06004126 RID: 16678 RVA: 0x00025362 File Offset: 0x00023562
		public string Tag { get; set; }

		// Token: 0x06004127 RID: 16679 RVA: 0x0011E5D0 File Offset: 0x0011C7D0
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.Tag);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06004128 RID: 16680 RVA: 0x0011E650 File Offset: 0x0011C850
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Tag = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x06004129 RID: 16681 RVA: 0x0002536B File Offset: 0x0002356B
		private void InitRefTypes()
		{
			this.Tag = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400224D RID: 8781
		public const uint cPacketType = 561375384u;
	}
}
