using System;

namespace NetworkProtocols
{
	// Token: 0x020006EF RID: 1775
	public class PartyClosed : BotNetMessage
	{
		// Token: 0x06003F54 RID: 16212 RVA: 0x00023CED File Offset: 0x00021EED
		public PartyClosed()
		{
			this.InitRefTypes();
			base.PacketType = 269093686u;
		}

		// Token: 0x06003F55 RID: 16213 RVA: 0x00023D06 File Offset: 0x00021F06
		public PartyClosed(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 269093686u;
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x06003F56 RID: 16214 RVA: 0x00023D26 File Offset: 0x00021F26
		// (set) Token: 0x06003F57 RID: 16215 RVA: 0x00023D2E File Offset: 0x00021F2E
		public ulong PartyID { get; set; }

		// Token: 0x06003F58 RID: 16216 RVA: 0x0011B720 File Offset: 0x00119920
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.PartyID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003F59 RID: 16217 RVA: 0x0011B7A0 File Offset: 0x001199A0
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.PartyID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06003F5A RID: 16218 RVA: 0x00023D37 File Offset: 0x00021F37
		private void InitRefTypes()
		{
			this.PartyID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400214B RID: 8523
		public const uint cPacketType = 269093686u;
	}
}
