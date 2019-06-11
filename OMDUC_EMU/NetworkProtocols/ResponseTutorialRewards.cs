using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000601 RID: 1537
	public class ResponseTutorialRewards : BotNetMessage
	{
		// Token: 0x0600357B RID: 13691 RVA: 0x0001D048 File Offset: 0x0001B248
		public ResponseTutorialRewards()
		{
			this.InitRefTypes();
			base.PacketType = 448084762u;
		}

		// Token: 0x0600357C RID: 13692 RVA: 0x0001D061 File Offset: 0x0001B261
		public ResponseTutorialRewards(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 448084762u;
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x0600357D RID: 13693 RVA: 0x0001D081 File Offset: 0x0001B281
		// (set) Token: 0x0600357E RID: 13694 RVA: 0x0001D089 File Offset: 0x0001B289
		public eAccountDataEventCodes ResponseCode { get; set; }

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x0600357F RID: 13695 RVA: 0x0001D092 File Offset: 0x0001B292
		// (set) Token: 0x06003580 RID: 13696 RVA: 0x0001D09A File Offset: 0x0001B29A
		public List<PacketTutorialRewards> TutorialRewards { get; set; }

		// Token: 0x06003581 RID: 13697 RVA: 0x00109460 File Offset: 0x00107660
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
			ArrayManager.WriteeAccountDataEventCodes(ref newArray, ref newSize, this.ResponseCode);
			ArrayManager.WriteListPacketTutorialRewards(ref newArray, ref newSize, this.TutorialRewards);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003582 RID: 13698 RVA: 0x001094EC File Offset: 0x001076EC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.ResponseCode = ArrayManager.ReadeAccountDataEventCodes(data, ref num);
			this.TutorialRewards = ArrayManager.ReadListPacketTutorialRewards(data, ref num);
		}

		// Token: 0x06003583 RID: 13699 RVA: 0x0001D0A3 File Offset: 0x0001B2A3
		private void InitRefTypes()
		{
			this.ResponseCode = eAccountDataEventCodes.AccountDataEventCodes_None;
			this.TutorialRewards = new List<PacketTutorialRewards>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001D30 RID: 7472
		public const uint cPacketType = 448084762u;
	}
}
