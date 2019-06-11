using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000642 RID: 1602
	public class ResponseSabotageBuckets : BotNetMessage
	{
		// Token: 0x060037DC RID: 14300 RVA: 0x0001EA5E File Offset: 0x0001CC5E
		public ResponseSabotageBuckets()
		{
			this.InitRefTypes();
			base.PacketType = 2952920753u;
		}

		// Token: 0x060037DD RID: 14301 RVA: 0x0001EA77 File Offset: 0x0001CC77
		public ResponseSabotageBuckets(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2952920753u;
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x060037DE RID: 14302 RVA: 0x0001EA97 File Offset: 0x0001CC97
		// (set) Token: 0x060037DF RID: 14303 RVA: 0x0001EA9F File Offset: 0x0001CC9F
		public List<PacketSabotageBucket> Buckets { get; set; }

		// Token: 0x060037E0 RID: 14304 RVA: 0x0010D054 File Offset: 0x0010B254
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
			ArrayManager.WriteListPacketSabotageBucket(ref newArray, ref newSize, this.Buckets);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060037E1 RID: 14305 RVA: 0x0010D0D4 File Offset: 0x0010B2D4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Buckets = ArrayManager.ReadListPacketSabotageBucket(data, ref num);
		}

		// Token: 0x060037E2 RID: 14306 RVA: 0x0001EAA8 File Offset: 0x0001CCA8
		private void InitRefTypes()
		{
			this.Buckets = new List<PacketSabotageBucket>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001DF4 RID: 7668
		public const uint cPacketType = 2952920753u;
	}
}
