using System;

namespace NetworkProtocols
{
	// Token: 0x0200070C RID: 1804
	public enum eGuildTransactionLogEvent
	{
		// Token: 0x040021BC RID: 8636
		None,
		// Token: 0x040021BD RID: 8637
		CreateGuild,
		// Token: 0x040021BE RID: 8638
		DisbandGuild,
		// Token: 0x040021BF RID: 8639
		AcceptApplication,
		// Token: 0x040021C0 RID: 8640
		MemberLeft,
		// Token: 0x040021C1 RID: 8641
		MemberPromoted,
		// Token: 0x040021C2 RID: 8642
		MemberDemoted,
		// Token: 0x040021C3 RID: 8643
		LeaderAssigned,
		// Token: 0x040021C4 RID: 8644
		MemberKicked,
		// Token: 0x040021C5 RID: 8645
		AcceptInvite,
		// Token: 0x040021C6 RID: 8646
		SeasonalReward,
		// Token: 0x040021C7 RID: 8647
		AbsenteeLeaderReplaced,
		// Token: 0x040021C8 RID: 8648
		ChangeMOTD,
		// Token: 0x040021C9 RID: 8649
		ChangeDescription
	}
}
