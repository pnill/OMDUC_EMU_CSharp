using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020005F7 RID: 1527
	public class PushPlayerAchievements : BotNetMessage
	{
		// Token: 0x0600351D RID: 13597 RVA: 0x0001CC6B File Offset: 0x0001AE6B
		public PushPlayerAchievements()
		{
			this.InitRefTypes();
			base.PacketType = 2583444957u;
		}

		// Token: 0x0600351E RID: 13598 RVA: 0x0001CC84 File Offset: 0x0001AE84
		public PushPlayerAchievements(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2583444957u;
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x0600351F RID: 13599 RVA: 0x0001CCA4 File Offset: 0x0001AEA4
		// (set) Token: 0x06003520 RID: 13600 RVA: 0x0001CCAC File Offset: 0x0001AEAC
		public List<AchievementForNetwork> Achievements { get; set; }

		// Token: 0x06003521 RID: 13601 RVA: 0x00108C94 File Offset: 0x00106E94
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
			ArrayManager.WriteListAchievementForNetwork(ref newArray, ref newSize, this.Achievements);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003522 RID: 13602 RVA: 0x00108D14 File Offset: 0x00106F14
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Achievements = ArrayManager.ReadListAchievementForNetwork(data, ref num);
		}

		// Token: 0x06003523 RID: 13603 RVA: 0x0001CCB5 File Offset: 0x0001AEB5
		private void InitRefTypes()
		{
			this.Achievements = new List<AchievementForNetwork>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001D12 RID: 7442
		public const uint cPacketType = 2583444957u;
	}
}
