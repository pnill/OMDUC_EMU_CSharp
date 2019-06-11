using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020005AA RID: 1450
	public class PacketHeroLevelReward
	{
		// Token: 0x06003274 RID: 12916 RVA: 0x0001B231 File Offset: 0x00019431
		public PacketHeroLevelReward()
		{
			this.InitRefTypes();
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06003275 RID: 12917 RVA: 0x0001B23F File Offset: 0x0001943F
		// (set) Token: 0x06003276 RID: 12918 RVA: 0x0001B247 File Offset: 0x00019447
		public uint Level { get; set; }

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06003277 RID: 12919 RVA: 0x0001B250 File Offset: 0x00019450
		// (set) Token: 0x06003278 RID: 12920 RVA: 0x0001B258 File Offset: 0x00019458
		public uint ExperiencePoints { get; set; }

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06003279 RID: 12921 RVA: 0x0001B261 File Offset: 0x00019461
		// (set) Token: 0x0600327A RID: 12922 RVA: 0x0001B269 File Offset: 0x00019469
		public List<PacketPlayerAward> Awards { get; set; }

		// Token: 0x0600327B RID: 12923 RVA: 0x00105264 File Offset: 0x00103464
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.Level);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.ExperiencePoints);
			ArrayManager.WriteListPacketPlayerAward(ref newArray, ref newSize, this.Awards);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600327C RID: 12924 RVA: 0x001052B0 File Offset: 0x001034B0
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Level = ArrayManager.ReadUInt32(data, ref num);
			this.ExperiencePoints = ArrayManager.ReadUInt32(data, ref num);
			this.Awards = ArrayManager.ReadListPacketPlayerAward(data, ref num);
		}

		// Token: 0x0600327D RID: 12925 RVA: 0x0001B272 File Offset: 0x00019472
		private void InitRefTypes()
		{
			this.Level = 0u;
			this.ExperiencePoints = 0u;
			this.Awards = new List<PacketPlayerAward>();
		}
	}
}
