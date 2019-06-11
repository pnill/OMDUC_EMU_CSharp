using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020005B2 RID: 1458
	public class ResponseDailyLoginRewards : BotNetMessage
	{
		// Token: 0x060032B0 RID: 12976 RVA: 0x0001B4A4 File Offset: 0x000196A4
		public ResponseDailyLoginRewards()
		{
			this.InitRefTypes();
			base.PacketType = 2902685399u;
		}

		// Token: 0x060032B1 RID: 12977 RVA: 0x0001B4BD File Offset: 0x000196BD
		public ResponseDailyLoginRewards(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2902685399u;
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x060032B2 RID: 12978 RVA: 0x0001B4DD File Offset: 0x000196DD
		// (set) Token: 0x060032B3 RID: 12979 RVA: 0x0001B4E5 File Offset: 0x000196E5
		public int Month { get; set; }

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x060032B4 RID: 12980 RVA: 0x0001B4EE File Offset: 0x000196EE
		// (set) Token: 0x060032B5 RID: 12981 RVA: 0x0001B4F6 File Offset: 0x000196F6
		public List<PacketDailyLoginPeriodEntry> Entries { get; set; }

		// Token: 0x060032B6 RID: 12982 RVA: 0x001056DC File Offset: 0x001038DC
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
			ArrayManager.WriteInt32(ref newArray, ref newSize, this.Month);
			ArrayManager.WriteListPacketDailyLoginPeriodEntry(ref newArray, ref newSize, this.Entries);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060032B7 RID: 12983 RVA: 0x00105768 File Offset: 0x00103968
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Month = ArrayManager.ReadInt32(data, ref num);
			this.Entries = ArrayManager.ReadListPacketDailyLoginPeriodEntry(data, ref num);
		}

		// Token: 0x060032B8 RID: 12984 RVA: 0x0001B4FF File Offset: 0x000196FF
		private void InitRefTypes()
		{
			this.Month = 0;
			this.Entries = new List<PacketDailyLoginPeriodEntry>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001C5F RID: 7263
		public const uint cPacketType = 2902685399u;
	}
}
