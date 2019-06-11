using System;

namespace NetworkProtocols
{
	// Token: 0x0200070E RID: 1806
	public enum eGuildOperationStatus
	{
		// Token: 0x040021CF RID: 8655
		None,
		// Token: 0x040021D0 RID: 8656
		Failed,
		// Token: 0x040021D1 RID: 8657
		Success,
		// Token: 0x040021D2 RID: 8658
		AlreadyInGuild,
		// Token: 0x040021D3 RID: 8659
		NotHighEnoughLevel,
		// Token: 0x040021D4 RID: 8660
		UnknownGuild,
		// Token: 0x040021D5 RID: 8661
		GuildRosterFull,
		// Token: 0x040021D6 RID: 8662
		NoApplicationsFound,
		// Token: 0x040021D7 RID: 8663
		PlayerNotInGuild,
		// Token: 0x040021D8 RID: 8664
		InsufficientRank,
		// Token: 0x040021D9 RID: 8665
		NoOutgoingInvites,
		// Token: 0x040021DA RID: 8666
		NoIncomingApplications,
		// Token: 0x040021DB RID: 8667
		PlayerNotFound,
		// Token: 0x040021DC RID: 8668
		LeaderCannotLeaveGuild,
		// Token: 0x040021DD RID: 8669
		RequestingPlayerNotInGuild,
		// Token: 0x040021DE RID: 8670
		CreateGuild_NotEnoughSkulls = 20,
		// Token: 0x040021DF RID: 8671
		PlayerIsNotGuildLeader = 30,
		// Token: 0x040021E0 RID: 8672
		GuildName_TooShort = 40,
		// Token: 0x040021E1 RID: 8673
		GuildName_TooLong,
		// Token: 0x040021E2 RID: 8674
		GuildName_Taken,
		// Token: 0x040021E3 RID: 8675
		GuildName_Restricted,
		// Token: 0x040021E4 RID: 8676
		GuildName_NotAlphaNumeric,
		// Token: 0x040021E5 RID: 8677
		GuildTag_TooShort = 50,
		// Token: 0x040021E6 RID: 8678
		GuildTag_TooLong,
		// Token: 0x040021E7 RID: 8679
		GuildTag_Taken,
		// Token: 0x040021E8 RID: 8680
		GuildTag_Restricted,
		// Token: 0x040021E9 RID: 8681
		GuildTag_NotAlphaNumeric,
		// Token: 0x040021EA RID: 8682
		ApplyToGuild_ExistingApplication = 60,
		// Token: 0x040021EB RID: 8683
		ApplyToGuild_ExistingInvite,
		// Token: 0x040021EC RID: 8684
		ApplyToGuild_GuildNotAcceptingApplications,
		// Token: 0x040021ED RID: 8685
		ModifyMember_RequestingPlayerAndMemberNotInSameGuild = 71,
		// Token: 0x040021EE RID: 8686
		ModifyMember_MemberAtMinimumRank,
		// Token: 0x040021EF RID: 8687
		ModifyMember_MemberAtMaximumRank,
		// Token: 0x040021F0 RID: 8688
		ModifyMember_MemberNotInGuild,
		// Token: 0x040021F1 RID: 8689
		ModifyMember_CannotDemoteLeader,
		// Token: 0x040021F2 RID: 8690
		ModifyMember_CannotKickLeader
	}
}
