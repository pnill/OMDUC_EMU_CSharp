using System;

namespace NetworkProtocols
{
	// Token: 0x02000653 RID: 1619
	public class PushPlayerChallengeProgress : BotNetMessage
	{
		// Token: 0x06003877 RID: 14455 RVA: 0x0001F15A File Offset: 0x0001D35A
		public PushPlayerChallengeProgress()
		{
			this.InitRefTypes();
			base.PacketType = 4091036120u;
		}

		// Token: 0x06003878 RID: 14456 RVA: 0x0001F173 File Offset: 0x0001D373
		public PushPlayerChallengeProgress(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 4091036120u;
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06003879 RID: 14457 RVA: 0x0001F193 File Offset: 0x0001D393
		// (set) Token: 0x0600387A RID: 14458 RVA: 0x0001F19B File Offset: 0x0001D39B
		public ulong ChallengeID { get; set; }

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x0600387B RID: 14459 RVA: 0x0001F1A4 File Offset: 0x0001D3A4
		// (set) Token: 0x0600387C RID: 14460 RVA: 0x0001F1AC File Offset: 0x0001D3AC
		public eChallengeStatus Status { get; set; }

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x0600387D RID: 14461 RVA: 0x0001F1B5 File Offset: 0x0001D3B5
		// (set) Token: 0x0600387E RID: 14462 RVA: 0x0001F1BD File Offset: 0x0001D3BD
		public int StarsEarned { get; set; }

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x0600387F RID: 14463 RVA: 0x0001F1C6 File Offset: 0x0001D3C6
		// (set) Token: 0x06003880 RID: 14464 RVA: 0x0001F1CE File Offset: 0x0001D3CE
		public bool ViewedChallenge { get; set; }

		// Token: 0x06003881 RID: 14465 RVA: 0x0010E008 File Offset: 0x0010C208
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.ChallengeID);
			ArrayManager.WriteeChallengeStatus(ref newArray, ref newSize, this.Status);
			ArrayManager.WriteInt32(ref newArray, ref newSize, this.StarsEarned);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.ViewedChallenge);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003882 RID: 14466 RVA: 0x0010E0B4 File Offset: 0x0010C2B4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.ChallengeID = ArrayManager.ReadUInt64(data, ref num);
			this.Status = ArrayManager.ReadeChallengeStatus(data, ref num);
			this.StarsEarned = ArrayManager.ReadInt32(data, ref num);
			this.ViewedChallenge = ArrayManager.ReadBoolean(data, ref num);
		}

		// Token: 0x06003883 RID: 14467 RVA: 0x0001F1D7 File Offset: 0x0001D3D7
		private void InitRefTypes()
		{
			this.ChallengeID = 0UL;
			this.Status = eChallengeStatus.None;
			this.StarsEarned = 0;
			this.ViewedChallenge = false;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001E26 RID: 7718
		public const uint cPacketType = 4091036120u;
	}
}
