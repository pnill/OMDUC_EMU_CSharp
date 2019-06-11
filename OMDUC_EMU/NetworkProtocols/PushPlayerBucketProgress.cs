using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x0200064E RID: 1614
	public class PushPlayerBucketProgress : BotNetMessage
	{
		// Token: 0x06003849 RID: 14409 RVA: 0x0001EF51 File Offset: 0x0001D151
		public PushPlayerBucketProgress()
		{
			this.InitRefTypes();
			base.PacketType = 1111650129u;
		}

		// Token: 0x0600384A RID: 14410 RVA: 0x0001EF6A File Offset: 0x0001D16A
		public PushPlayerBucketProgress(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1111650129u;
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x0600384B RID: 14411 RVA: 0x0001EF8A File Offset: 0x0001D18A
		// (set) Token: 0x0600384C RID: 14412 RVA: 0x0001EF92 File Offset: 0x0001D192
		public ulong CurrentBucketID { get; set; }

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x0600384D RID: 14413 RVA: 0x0001EF9B File Offset: 0x0001D19B
		// (set) Token: 0x0600384E RID: 14414 RVA: 0x0001EFA3 File Offset: 0x0001D1A3
		public List<PlayerBucketProgress> Buckets { get; set; }

		// Token: 0x0600384F RID: 14415 RVA: 0x0010DB28 File Offset: 0x0010BD28
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.CurrentBucketID);
			ArrayManager.WriteListPlayerBucketProgress(ref newArray, ref newSize, this.Buckets);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003850 RID: 14416 RVA: 0x0010DBB4 File Offset: 0x0010BDB4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.CurrentBucketID = ArrayManager.ReadUInt64(data, ref num);
			this.Buckets = ArrayManager.ReadListPlayerBucketProgress(data, ref num);
		}

		// Token: 0x06003851 RID: 14417 RVA: 0x0001EFAC File Offset: 0x0001D1AC
		private void InitRefTypes()
		{
			this.CurrentBucketID = 0UL;
			this.Buckets = new List<PlayerBucketProgress>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001E17 RID: 7703
		public const uint cPacketType = 1111650129u;
	}
}
