using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020004A3 RID: 1187
	public class CommunityContributionForEvent
	{
		// Token: 0x06002AAA RID: 10922 RVA: 0x00016596 File Offset: 0x00014796
		public CommunityContributionForEvent()
		{
			this.InitRefTypes();
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06002AAB RID: 10923 RVA: 0x000165A4 File Offset: 0x000147A4
		// (set) Token: 0x06002AAC RID: 10924 RVA: 0x000165AC File Offset: 0x000147AC
		public ulong EventID { get; set; }

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06002AAD RID: 10925 RVA: 0x000165B5 File Offset: 0x000147B5
		// (set) Token: 0x06002AAE RID: 10926 RVA: 0x000165BD File Offset: 0x000147BD
		public List<IndividualPlayerContributionForGoal> PlayerContributionList { get; set; }

		// Token: 0x06002AAF RID: 10927 RVA: 0x000FB9C0 File Offset: 0x000F9BC0
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.EventID);
			ArrayManager.WriteListIndividualPlayerContributionForGoal(ref newArray, ref newSize, this.PlayerContributionList);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002AB0 RID: 10928 RVA: 0x000FB9FC File Offset: 0x000F9BFC
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.EventID = ArrayManager.ReadUInt64(data, ref num);
			this.PlayerContributionList = ArrayManager.ReadListIndividualPlayerContributionForGoal(data, ref num);
		}

		// Token: 0x06002AB1 RID: 10929 RVA: 0x000165C6 File Offset: 0x000147C6
		private void InitRefTypes()
		{
			this.EventID = 0UL;
			this.PlayerContributionList = new List<IndividualPlayerContributionForGoal>();
		}
	}
}
