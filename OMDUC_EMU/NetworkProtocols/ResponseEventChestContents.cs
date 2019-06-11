using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020005BA RID: 1466
	public class ResponseEventChestContents : BotNetMessage
	{
		// Token: 0x060032FB RID: 13051 RVA: 0x0001B774 File Offset: 0x00019974
		public ResponseEventChestContents()
		{
			this.InitRefTypes();
			base.PacketType = 1990053639u;
		}

		// Token: 0x060032FC RID: 13052 RVA: 0x0001B78D File Offset: 0x0001998D
		public ResponseEventChestContents(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1990053639u;
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x060032FD RID: 13053 RVA: 0x0001B7AD File Offset: 0x000199AD
		// (set) Token: 0x060032FE RID: 13054 RVA: 0x0001B7B5 File Offset: 0x000199B5
		public List<EventChestProto> EventChests { get; set; }

		// Token: 0x060032FF RID: 13055 RVA: 0x00105B54 File Offset: 0x00103D54
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
			ArrayManager.WriteListEventChestProto(ref newArray, ref newSize, this.EventChests);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003300 RID: 13056 RVA: 0x00105BD4 File Offset: 0x00103DD4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.EventChests = ArrayManager.ReadListEventChestProto(data, ref num);
		}

		// Token: 0x06003301 RID: 13057 RVA: 0x0001B7BE File Offset: 0x000199BE
		private void InitRefTypes()
		{
			this.EventChests = new List<EventChestProto>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001C75 RID: 7285
		public const uint cPacketType = 1990053639u;
	}
}
