using System;

namespace NetworkProtocols
{
	// Token: 0x020006E8 RID: 1768
	public class ResponseServerAckInviteToParty : BotNetMessage
	{
		// Token: 0x06003F13 RID: 16147 RVA: 0x0002399F File Offset: 0x00021B9F
		public ResponseServerAckInviteToParty()
		{
			this.InitRefTypes();
			base.PacketType = 3442345621u;
		}

		// Token: 0x06003F14 RID: 16148 RVA: 0x000239B8 File Offset: 0x00021BB8
		public ResponseServerAckInviteToParty(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3442345621u;
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06003F15 RID: 16149 RVA: 0x000239D8 File Offset: 0x00021BD8
		// (set) Token: 0x06003F16 RID: 16150 RVA: 0x000239E0 File Offset: 0x00021BE0
		public ulong PartyID { get; set; }

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06003F17 RID: 16151 RVA: 0x000239E9 File Offset: 0x00021BE9
		// (set) Token: 0x06003F18 RID: 16152 RVA: 0x000239F1 File Offset: 0x00021BF1
		public ePartyOperationStatus Status { get; set; }

		// Token: 0x06003F19 RID: 16153 RVA: 0x0011AFE4 File Offset: 0x001191E4
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
			ArrayManager.WriteePartyOperationStatus(ref newArray, ref newSize, this.Status);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003F1A RID: 16154 RVA: 0x0011B070 File Offset: 0x00119270
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
			this.Status = ArrayManager.ReadePartyOperationStatus(data, ref num);
		}

		// Token: 0x06003F1B RID: 16155 RVA: 0x000239FA File Offset: 0x00021BFA
		private void InitRefTypes()
		{
			this.PartyID = 0UL;
			this.Status = ePartyOperationStatus.Failure;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002135 RID: 8501
		public const uint cPacketType = 3442345621u;
	}
}
