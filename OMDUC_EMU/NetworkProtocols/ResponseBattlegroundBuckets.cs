using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000640 RID: 1600
	public class ResponseBattlegroundBuckets : BotNetMessage
	{
		// Token: 0x060037CB RID: 14283 RVA: 0x0001E9A3 File Offset: 0x0001CBA3
		public ResponseBattlegroundBuckets()
		{
			this.InitRefTypes();
			base.PacketType = 804381683u;
		}

		// Token: 0x060037CC RID: 14284 RVA: 0x0001E9BC File Offset: 0x0001CBBC
		public ResponseBattlegroundBuckets(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 804381683u;
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x060037CD RID: 14285 RVA: 0x0001E9DC File Offset: 0x0001CBDC
		// (set) Token: 0x060037CE RID: 14286 RVA: 0x0001E9E4 File Offset: 0x0001CBE4
		public List<PacketBattlegroundBucket> Buckets { get; set; }

		// Token: 0x060037CF RID: 14287 RVA: 0x0010CEE4 File Offset: 0x0010B0E4
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
			ArrayManager.WriteListPacketBattlegroundBucket(ref newArray, ref newSize, this.Buckets);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060037D0 RID: 14288 RVA: 0x0010CF64 File Offset: 0x0010B164
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Buckets = ArrayManager.ReadListPacketBattlegroundBucket(data, ref num);
		}

		// Token: 0x060037D1 RID: 14289 RVA: 0x0001E9ED File Offset: 0x0001CBED
		private void InitRefTypes()
		{
			this.Buckets = new List<PacketBattlegroundBucket>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001DEF RID: 7663
		public const uint cPacketType = 804381683u;
	}
}
