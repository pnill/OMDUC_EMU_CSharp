using System;

namespace NetworkProtocols
{
	// Token: 0x0200058A RID: 1418
	public class ResponsePlayerPostDeckUpdate : BotNetMessage
	{
		// Token: 0x060030DB RID: 12507 RVA: 0x0001A218 File Offset: 0x00018418
		public ResponsePlayerPostDeckUpdate()
		{
			this.InitRefTypes();
			base.PacketType = 2618024601u;
		}

		// Token: 0x060030DC RID: 12508 RVA: 0x0001A231 File Offset: 0x00018431
		public ResponsePlayerPostDeckUpdate(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2618024601u;
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x060030DD RID: 12509 RVA: 0x0001A251 File Offset: 0x00018451
		// (set) Token: 0x060030DE RID: 12510 RVA: 0x0001A259 File Offset: 0x00018459
		public eDeckOperationResult EventCode { get; set; }

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x060030DF RID: 12511 RVA: 0x0001A262 File Offset: 0x00018462
		// (set) Token: 0x060030E0 RID: 12512 RVA: 0x0001A26A File Offset: 0x0001846A
		public ulong Value { get; set; }

		// Token: 0x060030E1 RID: 12513 RVA: 0x00103068 File Offset: 0x00101268
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
			ArrayManager.WriteeDeckOperationResult(ref newArray, ref newSize, this.EventCode);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.Value);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060030E2 RID: 12514 RVA: 0x001030F4 File Offset: 0x001012F4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.EventCode = ArrayManager.ReadeDeckOperationResult(data, ref num);
			this.Value = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x060030E3 RID: 12515 RVA: 0x0001A273 File Offset: 0x00018473
		private void InitRefTypes()
		{
			this.EventCode = eDeckOperationResult.None;
			this.Value = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001BB9 RID: 7097
		public const uint cPacketType = 2618024601u;
	}
}
