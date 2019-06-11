using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x0200061F RID: 1567
	public class ResponseStarAwardsEarnedList : BotNetMessage
	{
		// Token: 0x060036A4 RID: 13988 RVA: 0x0001DE25 File Offset: 0x0001C025
		public ResponseStarAwardsEarnedList()
		{
			this.InitRefTypes();
			base.PacketType = 2003965106u;
		}

		// Token: 0x060036A5 RID: 13989 RVA: 0x0001DE3E File Offset: 0x0001C03E
		public ResponseStarAwardsEarnedList(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2003965106u;
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x060036A6 RID: 13990 RVA: 0x0001DE5E File Offset: 0x0001C05E
		// (set) Token: 0x060036A7 RID: 13991 RVA: 0x0001DE66 File Offset: 0x0001C066
		public List<StarAwardEarnedEntry> EarnedStars { get; set; }

		// Token: 0x060036A8 RID: 13992 RVA: 0x0010B48C File Offset: 0x0010968C
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
			ArrayManager.WriteListStarAwardEarnedEntry(ref newArray, ref newSize, this.EarnedStars);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060036A9 RID: 13993 RVA: 0x0010B50C File Offset: 0x0010970C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.EarnedStars = ArrayManager.ReadListStarAwardEarnedEntry(data, ref num);
		}

		// Token: 0x060036AA RID: 13994 RVA: 0x0001DE6F File Offset: 0x0001C06F
		private void InitRefTypes()
		{
			this.EarnedStars = new List<StarAwardEarnedEntry>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001D97 RID: 7575
		public const uint cPacketType = 2003965106u;
	}
}
