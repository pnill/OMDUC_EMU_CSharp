using System;

namespace NetworkProtocols
{
	// Token: 0x0200068A RID: 1674
	public class RequestUpdatePlayerKeystoneLeaderboardInfo : BotNetMessage
	{
		// Token: 0x06003ABE RID: 15038 RVA: 0x00020AA4 File Offset: 0x0001ECA4
		public RequestUpdatePlayerKeystoneLeaderboardInfo()
		{
			this.InitRefTypes();
			base.PacketType = 199016344u;
		}

		// Token: 0x06003ABF RID: 15039 RVA: 0x00020ABD File Offset: 0x0001ECBD
		public RequestUpdatePlayerKeystoneLeaderboardInfo(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 199016344u;
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x06003AC0 RID: 15040 RVA: 0x00020ADD File Offset: 0x0001ECDD
		// (set) Token: 0x06003AC1 RID: 15041 RVA: 0x00020AE5 File Offset: 0x0001ECE5
		public ulong AccountSUID { get; set; }

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x06003AC2 RID: 15042 RVA: 0x00020AEE File Offset: 0x0001ECEE
		// (set) Token: 0x06003AC3 RID: 15043 RVA: 0x00020AF6 File Offset: 0x0001ECF6
		public ulong KeystoneID { get; set; }

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x06003AC4 RID: 15044 RVA: 0x00020AFF File Offset: 0x0001ECFF
		// (set) Token: 0x06003AC5 RID: 15045 RVA: 0x00020B07 File Offset: 0x0001ED07
		public ulong BucketID { get; set; }

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x06003AC6 RID: 15046 RVA: 0x00020B10 File Offset: 0x0001ED10
		// (set) Token: 0x06003AC7 RID: 15047 RVA: 0x00020B18 File Offset: 0x0001ED18
		public ulong RunningScore { get; set; }

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x06003AC8 RID: 15048 RVA: 0x00020B21 File Offset: 0x0001ED21
		// (set) Token: 0x06003AC9 RID: 15049 RVA: 0x00020B29 File Offset: 0x0001ED29
		public int Level { get; set; }

		// Token: 0x06003ACA RID: 15050 RVA: 0x00111654 File Offset: 0x0010F854
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.KeystoneID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.BucketID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.RunningScore);
			ArrayManager.WriteInt32(ref newArray, ref newSize, this.Level);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003ACB RID: 15051 RVA: 0x00111710 File Offset: 0x0010F910
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
			this.KeystoneID = ArrayManager.ReadUInt64(data, ref num);
			this.BucketID = ArrayManager.ReadUInt64(data, ref num);
			this.RunningScore = ArrayManager.ReadUInt64(data, ref num);
			this.Level = ArrayManager.ReadInt32(data, ref num);
		}

		// Token: 0x06003ACC RID: 15052 RVA: 0x00020B32 File Offset: 0x0001ED32
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.KeystoneID = 0UL;
			this.BucketID = 0UL;
			this.RunningScore = 0UL;
			this.Level = 0;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001F21 RID: 7969
		public const uint cPacketType = 199016344u;
	}
}
