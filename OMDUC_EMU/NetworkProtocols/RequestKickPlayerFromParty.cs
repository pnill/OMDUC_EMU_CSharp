using System;

namespace NetworkProtocols
{
	// Token: 0x020006F8 RID: 1784
	public class RequestKickPlayerFromParty : BotNetMessage
	{
		// Token: 0x06003FB8 RID: 16312 RVA: 0x00024175 File Offset: 0x00022375
		public RequestKickPlayerFromParty()
		{
			this.InitRefTypes();
			base.PacketType = 3477894252u;
		}

		// Token: 0x06003FB9 RID: 16313 RVA: 0x0002418E File Offset: 0x0002238E
		public RequestKickPlayerFromParty(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3477894252u;
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06003FBA RID: 16314 RVA: 0x000241AE File Offset: 0x000223AE
		// (set) Token: 0x06003FBB RID: 16315 RVA: 0x000241B6 File Offset: 0x000223B6
		public ulong AccountSUID { get; set; }

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x06003FBC RID: 16316 RVA: 0x000241BF File Offset: 0x000223BF
		// (set) Token: 0x06003FBD RID: 16317 RVA: 0x000241C7 File Offset: 0x000223C7
		public ulong PartyID { get; set; }

		// Token: 0x06003FBE RID: 16318 RVA: 0x0011C13C File Offset: 0x0011A33C
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.AccountSUID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.PartyID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003FBF RID: 16319 RVA: 0x0011C1C8 File Offset: 0x0011A3C8
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.PartyID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06003FC0 RID: 16320 RVA: 0x000241D0 File Offset: 0x000223D0
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.PartyID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400216F RID: 8559
		public const uint cPacketType = 3477894252u;
	}
}
