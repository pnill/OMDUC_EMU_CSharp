using System;

namespace NetworkProtocols
{
	// Token: 0x0200066E RID: 1646
	public class RequestAcceptKeystoneRollResult : BotNetMessage
	{
		// Token: 0x060039C3 RID: 14787 RVA: 0x0001FF18 File Offset: 0x0001E118
		public RequestAcceptKeystoneRollResult()
		{
			this.InitRefTypes();
			base.PacketType = 2869521887u;
		}

		// Token: 0x060039C4 RID: 14788 RVA: 0x0001FF31 File Offset: 0x0001E131
		public RequestAcceptKeystoneRollResult(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2869521887u;
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x060039C5 RID: 14789 RVA: 0x0001FF51 File Offset: 0x0001E151
		// (set) Token: 0x060039C6 RID: 14790 RVA: 0x0001FF59 File Offset: 0x0001E159
		public ulong KeystoneID { get; set; }

		// Token: 0x060039C7 RID: 14791 RVA: 0x0010FDC0 File Offset: 0x0010DFC0
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.KeystoneID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060039C8 RID: 14792 RVA: 0x0010FE40 File Offset: 0x0010E040
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.KeystoneID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x060039C9 RID: 14793 RVA: 0x0001FF62 File Offset: 0x0001E162
		private void InitRefTypes()
		{
			this.KeystoneID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001EA0 RID: 7840
		public const uint cPacketType = 2869521887u;
	}
}
