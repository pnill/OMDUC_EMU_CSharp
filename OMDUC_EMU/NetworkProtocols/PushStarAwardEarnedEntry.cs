using System;

namespace NetworkProtocols
{
	// Token: 0x02000620 RID: 1568
	public class PushStarAwardEarnedEntry : BotNetMessage
	{
		// Token: 0x060036AB RID: 13995 RVA: 0x0001DE83 File Offset: 0x0001C083
		public PushStarAwardEarnedEntry()
		{
			this.InitRefTypes();
			base.PacketType = 3118710813u;
		}

		// Token: 0x060036AC RID: 13996 RVA: 0x0001DE9C File Offset: 0x0001C09C
		public PushStarAwardEarnedEntry(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3118710813u;
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x060036AD RID: 13997 RVA: 0x0001DEBC File Offset: 0x0001C0BC
		// (set) Token: 0x060036AE RID: 13998 RVA: 0x0001DEC4 File Offset: 0x0001C0C4
		public StarAwardEarnedEntry EarnedStar { get; set; }

		// Token: 0x060036AF RID: 13999 RVA: 0x0010B574 File Offset: 0x00109774
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
			ArrayManager.WriteStarAwardEarnedEntry(ref newArray, ref newSize, this.EarnedStar);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060036B0 RID: 14000 RVA: 0x0010B5F4 File Offset: 0x001097F4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.EarnedStar = ArrayManager.ReadStarAwardEarnedEntry(data, ref num);
		}

		// Token: 0x060036B1 RID: 14001 RVA: 0x0001DECD File Offset: 0x0001C0CD
		private void InitRefTypes()
		{
			this.EarnedStar = new StarAwardEarnedEntry();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001D99 RID: 7577
		public const uint cPacketType = 3118710813u;
	}
}
