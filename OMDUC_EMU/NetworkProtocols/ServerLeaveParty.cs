using System;

namespace NetworkProtocols
{
	// Token: 0x020006EC RID: 1772
	public class ServerLeaveParty : BotNetMessage
	{
		// Token: 0x06003F3B RID: 16187 RVA: 0x00023BA8 File Offset: 0x00021DA8
		public ServerLeaveParty()
		{
			this.InitRefTypes();
			base.PacketType = 2901968593u;
		}

		// Token: 0x06003F3C RID: 16188 RVA: 0x00023BC1 File Offset: 0x00021DC1
		public ServerLeaveParty(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2901968593u;
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06003F3D RID: 16189 RVA: 0x00023BE1 File Offset: 0x00021DE1
		// (set) Token: 0x06003F3E RID: 16190 RVA: 0x00023BE9 File Offset: 0x00021DE9
		public ulong PartyID { get; set; }

		// Token: 0x06003F3F RID: 16191 RVA: 0x0011B430 File Offset: 0x00119630
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

		// Token: 0x06003F40 RID: 16192 RVA: 0x0011B4B0 File Offset: 0x001196B0
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

		// Token: 0x06003F41 RID: 16193 RVA: 0x00023BF2 File Offset: 0x00021DF2
		private void InitRefTypes()
		{
			this.PartyID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002143 RID: 8515
		public const uint cPacketType = 2901968593u;
	}
}
