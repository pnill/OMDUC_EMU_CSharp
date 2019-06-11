using System;

namespace NetworkProtocols
{
	// Token: 0x0200066F RID: 1647
	public class ResponseAcceptKeystoneRollResult : BotNetMessage
	{
		// Token: 0x060039CA RID: 14794 RVA: 0x0001FF73 File Offset: 0x0001E173
		public ResponseAcceptKeystoneRollResult()
		{
			this.InitRefTypes();
			base.PacketType = 1225680865u;
		}

		// Token: 0x060039CB RID: 14795 RVA: 0x0001FF8C File Offset: 0x0001E18C
		public ResponseAcceptKeystoneRollResult(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1225680865u;
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x060039CC RID: 14796 RVA: 0x0001FFAC File Offset: 0x0001E1AC
		// (set) Token: 0x060039CD RID: 14797 RVA: 0x0001FFB4 File Offset: 0x0001E1B4
		public bool ResultAccepted { get; set; }

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x060039CE RID: 14798 RVA: 0x0001FFBD File Offset: 0x0001E1BD
		// (set) Token: 0x060039CF RID: 14799 RVA: 0x0001FFC5 File Offset: 0x0001E1C5
		public ulong KeystoneID { get; set; }

		// Token: 0x060039D0 RID: 14800 RVA: 0x0010FEA8 File Offset: 0x0010E0A8
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
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.ResultAccepted);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.KeystoneID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060039D1 RID: 14801 RVA: 0x0010FF34 File Offset: 0x0010E134
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.ResultAccepted = ArrayManager.ReadBoolean(data, ref num);
			this.KeystoneID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x060039D2 RID: 14802 RVA: 0x0001FFCE File Offset: 0x0001E1CE
		private void InitRefTypes()
		{
			this.ResultAccepted = false;
			this.KeystoneID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001EA2 RID: 7842
		public const uint cPacketType = 1225680865u;
	}
}
