using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x0200063D RID: 1597
	public class PacketCampaign
	{
		// Token: 0x0600379C RID: 14236 RVA: 0x0001E7EE File Offset: 0x0001C9EE
		public PacketCampaign()
		{
			this.InitRefTypes();
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x0600379D RID: 14237 RVA: 0x0001E7FC File Offset: 0x0001C9FC
		// (set) Token: 0x0600379E RID: 14238 RVA: 0x0001E804 File Offset: 0x0001CA04
		public ulong CampaignID { get; set; }

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x0600379F RID: 14239 RVA: 0x0001E80D File Offset: 0x0001CA0D
		// (set) Token: 0x060037A0 RID: 14240 RVA: 0x0001E815 File Offset: 0x0001CA15
		public string Name { get; set; }

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x060037A1 RID: 14241 RVA: 0x0001E81E File Offset: 0x0001CA1E
		// (set) Token: 0x060037A2 RID: 14242 RVA: 0x0001E826 File Offset: 0x0001CA26
		public List<PacketCampaignMission> SequentialMissions { get; set; }

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x060037A3 RID: 14243 RVA: 0x0001E82F File Offset: 0x0001CA2F
		// (set) Token: 0x060037A4 RID: 14244 RVA: 0x0001E837 File Offset: 0x0001CA37
		public List<PacketCampaignMission> NonSequentialMissions { get; set; }

		// Token: 0x060037A5 RID: 14245 RVA: 0x0010CB50 File Offset: 0x0010AD50
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.CampaignID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Name);
			ArrayManager.WriteListPacketCampaignMission(ref newArray, ref newSize, this.SequentialMissions);
			ArrayManager.WriteListPacketCampaignMission(ref newArray, ref newSize, this.NonSequentialMissions);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060037A6 RID: 14246 RVA: 0x0010CBAC File Offset: 0x0010ADAC
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.CampaignID = ArrayManager.ReadUInt64(data, ref num);
			this.Name = ArrayManager.ReadString(data, ref num);
			this.SequentialMissions = ArrayManager.ReadListPacketCampaignMission(data, ref num);
			this.NonSequentialMissions = ArrayManager.ReadListPacketCampaignMission(data, ref num);
		}

		// Token: 0x060037A7 RID: 14247 RVA: 0x0001E840 File Offset: 0x0001CA40
		private void InitRefTypes()
		{
			this.CampaignID = 0UL;
			this.Name = string.Empty;
			this.SequentialMissions = new List<PacketCampaignMission>();
			this.NonSequentialMissions = new List<PacketCampaignMission>();
		}
	}
}
