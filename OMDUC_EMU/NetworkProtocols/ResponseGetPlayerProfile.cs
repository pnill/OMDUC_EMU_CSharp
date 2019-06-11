using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000755 RID: 1877
	public class ResponseGetPlayerProfile : BotNetMessage
	{
		// Token: 0x060042AE RID: 17070 RVA: 0x0002640C File Offset: 0x0002460C
		public ResponseGetPlayerProfile()
		{
			this.InitRefTypes();
			base.PacketType = 2285840822u;
		}

		// Token: 0x060042AF RID: 17071 RVA: 0x00026425 File Offset: 0x00024625
		public ResponseGetPlayerProfile(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2285840822u;
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x060042B0 RID: 17072 RVA: 0x00026445 File Offset: 0x00024645
		// (set) Token: 0x060042B1 RID: 17073 RVA: 0x0002644D File Offset: 0x0002464D
		public eGuildOperationStatus Status { get; set; }

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x060042B2 RID: 17074 RVA: 0x00026456 File Offset: 0x00024656
		// (set) Token: 0x060042B3 RID: 17075 RVA: 0x0002645E File Offset: 0x0002465E
		public List<PlayerBoostStatus> PlayerBoosts { get; set; }

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x060042B4 RID: 17076 RVA: 0x00026467 File Offset: 0x00024667
		// (set) Token: 0x060042B5 RID: 17077 RVA: 0x0002646F File Offset: 0x0002466F
		public AccountPlayerProfile MemberDetail { get; set; }

		// Token: 0x060042B6 RID: 17078 RVA: 0x00120C38 File Offset: 0x0011EE38
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
			ArrayManager.WriteeGuildOperationStatus(ref newArray, ref newSize, this.Status);
			ArrayManager.WriteListPlayerBoostStatus(ref newArray, ref newSize, this.PlayerBoosts);
			ArrayManager.WriteAccountPlayerProfile(ref newArray, ref newSize, this.MemberDetail);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060042B7 RID: 17079 RVA: 0x00120CD4 File Offset: 0x0011EED4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Status = ArrayManager.ReadeGuildOperationStatus(data, ref num);
			this.PlayerBoosts = ArrayManager.ReadListPlayerBoostStatus(data, ref num);
			this.MemberDetail = ArrayManager.ReadAccountPlayerProfile(data, ref num);
		}

		// Token: 0x060042B8 RID: 17080 RVA: 0x00026478 File Offset: 0x00024678
		private void InitRefTypes()
		{
			this.Status = eGuildOperationStatus.None;
			this.PlayerBoosts = new List<PlayerBoostStatus>();
			this.MemberDetail = new AccountPlayerProfile();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040022D5 RID: 8917
		public const uint cPacketType = 2285840822u;
	}
}
