using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000668 RID: 1640
	public class PlayerCommunityEventsForNetwork
	{
		// Token: 0x06003968 RID: 14696 RVA: 0x0001FB40 File Offset: 0x0001DD40
		public PlayerCommunityEventsForNetwork()
		{
			this.InitRefTypes();
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06003969 RID: 14697 RVA: 0x0001FB4E File Offset: 0x0001DD4E
		// (set) Token: 0x0600396A RID: 14698 RVA: 0x0001FB56 File Offset: 0x0001DD56
		public DateTime PreStartOn { get; set; }

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x0600396B RID: 14699 RVA: 0x0001FB5F File Offset: 0x0001DD5F
		// (set) Token: 0x0600396C RID: 14700 RVA: 0x0001FB67 File Offset: 0x0001DD67
		public DateTime StartOn { get; set; }

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x0600396D RID: 14701 RVA: 0x0001FB70 File Offset: 0x0001DD70
		// (set) Token: 0x0600396E RID: 14702 RVA: 0x0001FB78 File Offset: 0x0001DD78
		public DateTime EndOn { get; set; }

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x0600396F RID: 14703 RVA: 0x0001FB81 File Offset: 0x0001DD81
		// (set) Token: 0x06003970 RID: 14704 RVA: 0x0001FB89 File Offset: 0x0001DD89
		public DateTime PostEndOn { get; set; }

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06003971 RID: 14705 RVA: 0x0001FB92 File Offset: 0x0001DD92
		// (set) Token: 0x06003972 RID: 14706 RVA: 0x0001FB9A File Offset: 0x0001DD9A
		public bool IsRepeatable { get; set; }

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06003973 RID: 14707 RVA: 0x0001FBA3 File Offset: 0x0001DDA3
		// (set) Token: 0x06003974 RID: 14708 RVA: 0x0001FBAB File Offset: 0x0001DDAB
		public bool IsPrimary { get; set; }

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06003975 RID: 14709 RVA: 0x0001FBB4 File Offset: 0x0001DDB4
		// (set) Token: 0x06003976 RID: 14710 RVA: 0x0001FBBC File Offset: 0x0001DDBC
		public ulong EventID { get; set; }

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06003977 RID: 14711 RVA: 0x0001FBC5 File Offset: 0x0001DDC5
		// (set) Token: 0x06003978 RID: 14712 RVA: 0x0001FBCD File Offset: 0x0001DDCD
		public string EventName { get; set; }

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06003979 RID: 14713 RVA: 0x0001FBD6 File Offset: 0x0001DDD6
		// (set) Token: 0x0600397A RID: 14714 RVA: 0x0001FBDE File Offset: 0x0001DDDE
		public string EventDescription { get; set; }

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x0600397B RID: 14715 RVA: 0x0001FBE7 File Offset: 0x0001DDE7
		// (set) Token: 0x0600397C RID: 14716 RVA: 0x0001FBEF File Offset: 0x0001DDEF
		public string SplashImageCDNPath { get; set; }

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x0600397D RID: 14717 RVA: 0x0001FBF8 File Offset: 0x0001DDF8
		// (set) Token: 0x0600397E RID: 14718 RVA: 0x0001FC00 File Offset: 0x0001DE00
		public uint PercentCompletionForPartialReward { get; set; }

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x0600397F RID: 14719 RVA: 0x0001FC09 File Offset: 0x0001DE09
		// (set) Token: 0x06003980 RID: 14720 RVA: 0x0001FC11 File Offset: 0x0001DE11
		public BaseAwardItem FullEventRewards { get; set; }

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06003981 RID: 14721 RVA: 0x0001FC1A File Offset: 0x0001DE1A
		// (set) Token: 0x06003982 RID: 14722 RVA: 0x0001FC22 File Offset: 0x0001DE22
		public BaseAwardItem PartialEventRewards { get; set; }

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06003983 RID: 14723 RVA: 0x0001FC2B File Offset: 0x0001DE2B
		// (set) Token: 0x06003984 RID: 14724 RVA: 0x0001FC33 File Offset: 0x0001DE33
		public bool PartialCompletionSuccess { get; set; }

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06003985 RID: 14725 RVA: 0x0001FC3C File Offset: 0x0001DE3C
		// (set) Token: 0x06003986 RID: 14726 RVA: 0x0001FC44 File Offset: 0x0001DE44
		public bool PartialCompletionFailure { get; set; }

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06003987 RID: 14727 RVA: 0x0001FC4D File Offset: 0x0001DE4D
		// (set) Token: 0x06003988 RID: 14728 RVA: 0x0001FC55 File Offset: 0x0001DE55
		public bool FullCompletionSuccess { get; set; }

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06003989 RID: 14729 RVA: 0x0001FC5E File Offset: 0x0001DE5E
		// (set) Token: 0x0600398A RID: 14730 RVA: 0x0001FC66 File Offset: 0x0001DE66
		public bool FullCompletionFailure { get; set; }

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x0600398B RID: 14731 RVA: 0x0001FC6F File Offset: 0x0001DE6F
		// (set) Token: 0x0600398C RID: 14732 RVA: 0x0001FC77 File Offset: 0x0001DE77
		public List<PlayerCommunityEventGoalsForNetwork> EventGoals { get; set; }

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x0600398D RID: 14733 RVA: 0x0001FC80 File Offset: 0x0001DE80
		// (set) Token: 0x0600398E RID: 14734 RVA: 0x0001FC88 File Offset: 0x0001DE88
		public List<PlayerCommunityEventBoostForNetwork> EventBoosts { get; set; }

		// Token: 0x0600398F RID: 14735 RVA: 0x0010F548 File Offset: 0x0010D748
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteDateTime(ref newArray, ref newSize, this.PreStartOn);
			ArrayManager.WriteDateTime(ref newArray, ref newSize, this.StartOn);
			ArrayManager.WriteDateTime(ref newArray, ref newSize, this.EndOn);
			ArrayManager.WriteDateTime(ref newArray, ref newSize, this.PostEndOn);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsRepeatable);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsPrimary);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.EventID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.EventName);
			ArrayManager.WriteString(ref newArray, ref newSize, this.EventDescription);
			ArrayManager.WriteString(ref newArray, ref newSize, this.SplashImageCDNPath);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.PercentCompletionForPartialReward);
			ArrayManager.WriteBaseAwardItem(ref newArray, ref newSize, this.FullEventRewards);
			ArrayManager.WriteBaseAwardItem(ref newArray, ref newSize, this.PartialEventRewards);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.PartialCompletionSuccess);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.PartialCompletionFailure);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.FullCompletionSuccess);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.FullCompletionFailure);
			ArrayManager.WriteListPlayerCommunityEventGoalsForNetwork(ref newArray, ref newSize, this.EventGoals);
			ArrayManager.WriteListPlayerCommunityEventBoostForNetwork(ref newArray, ref newSize, this.EventBoosts);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003990 RID: 14736 RVA: 0x0010F684 File Offset: 0x0010D884
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.PreStartOn = ArrayManager.ReadDateTime(data, ref num);
			this.StartOn = ArrayManager.ReadDateTime(data, ref num);
			this.EndOn = ArrayManager.ReadDateTime(data, ref num);
			this.PostEndOn = ArrayManager.ReadDateTime(data, ref num);
			this.IsRepeatable = ArrayManager.ReadBoolean(data, ref num);
			this.IsPrimary = ArrayManager.ReadBoolean(data, ref num);
			this.EventID = ArrayManager.ReadUInt64(data, ref num);
			this.EventName = ArrayManager.ReadString(data, ref num);
			this.EventDescription = ArrayManager.ReadString(data, ref num);
			this.SplashImageCDNPath = ArrayManager.ReadString(data, ref num);
			this.PercentCompletionForPartialReward = ArrayManager.ReadUInt32(data, ref num);
			this.FullEventRewards = ArrayManager.ReadBaseAwardItem(data, ref num);
			this.PartialEventRewards = ArrayManager.ReadBaseAwardItem(data, ref num);
			this.PartialCompletionSuccess = ArrayManager.ReadBoolean(data, ref num);
			this.PartialCompletionFailure = ArrayManager.ReadBoolean(data, ref num);
			this.FullCompletionSuccess = ArrayManager.ReadBoolean(data, ref num);
			this.FullCompletionFailure = ArrayManager.ReadBoolean(data, ref num);
			this.EventGoals = ArrayManager.ReadListPlayerCommunityEventGoalsForNetwork(data, ref num);
			this.EventBoosts = ArrayManager.ReadListPlayerCommunityEventBoostForNetwork(data, ref num);
		}

		// Token: 0x06003991 RID: 14737 RVA: 0x0010F7A0 File Offset: 0x0010D9A0
		private void InitRefTypes()
		{
			this.PreStartOn = default(DateTime);
			this.StartOn = default(DateTime);
			this.EndOn = default(DateTime);
			this.PostEndOn = default(DateTime);
			this.IsRepeatable = false;
			this.IsPrimary = false;
			this.EventID = 0UL;
			this.EventName = string.Empty;
			this.EventDescription = string.Empty;
			this.SplashImageCDNPath = string.Empty;
			this.PercentCompletionForPartialReward = 0u;
			this.FullEventRewards = new BaseAwardItem();
			this.PartialEventRewards = new BaseAwardItem();
			this.PartialCompletionSuccess = false;
			this.PartialCompletionFailure = false;
			this.FullCompletionSuccess = false;
			this.FullCompletionFailure = false;
			this.EventGoals = new List<PlayerCommunityEventGoalsForNetwork>();
			this.EventBoosts = new List<PlayerCommunityEventBoostForNetwork>();
		}
	}
}
