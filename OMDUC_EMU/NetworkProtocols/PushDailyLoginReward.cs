using System;

namespace NetworkProtocols
{
	// Token: 0x020005BC RID: 1468
	public class PushDailyLoginReward : BotNetMessage
	{
		// Token: 0x06003337 RID: 13111 RVA: 0x0001B9A3 File Offset: 0x00019BA3
		public PushDailyLoginReward()
		{
			this.InitRefTypes();
			base.PacketType = 204538625u;
		}

		// Token: 0x06003338 RID: 13112 RVA: 0x0001B9BC File Offset: 0x00019BBC
		public PushDailyLoginReward(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 204538625u;
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06003339 RID: 13113 RVA: 0x0001B9DC File Offset: 0x00019BDC
		// (set) Token: 0x0600333A RID: 13114 RVA: 0x0001B9E4 File Offset: 0x00019BE4
		public uint Day { get; set; }

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x0600333B RID: 13115 RVA: 0x0001B9ED File Offset: 0x00019BED
		// (set) Token: 0x0600333C RID: 13116 RVA: 0x0001B9F5 File Offset: 0x00019BF5
		public uint TotalDays { get; set; }

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x0600333D RID: 13117 RVA: 0x0001B9FE File Offset: 0x00019BFE
		// (set) Token: 0x0600333E RID: 13118 RVA: 0x0001BA06 File Offset: 0x00019C06
		public BaseAwardItem AwardItem { get; set; }

		// Token: 0x0600333F RID: 13119 RVA: 0x001060C4 File Offset: 0x001042C4
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
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.Day);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.TotalDays);
			ArrayManager.WriteBaseAwardItem(ref newArray, ref newSize, this.AwardItem);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003340 RID: 13120 RVA: 0x00106160 File Offset: 0x00104360
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Day = ArrayManager.ReadUInt32(data, ref num);
			this.TotalDays = ArrayManager.ReadUInt32(data, ref num);
			this.AwardItem = ArrayManager.ReadBaseAwardItem(data, ref num);
		}

		// Token: 0x06003341 RID: 13121 RVA: 0x0001BA0F File Offset: 0x00019C0F
		private void InitRefTypes()
		{
			this.Day = 0u;
			this.TotalDays = 0u;
			this.AwardItem = new BaseAwardItem();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001C90 RID: 7312
		public const uint cPacketType = 204538625u;
	}
}
