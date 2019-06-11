using System;

namespace NetworkProtocols
{
	// Token: 0x02000676 RID: 1654
	public enum eLeaderboardOperationResult
	{
		// Token: 0x04001EBD RID: 7869
		Success,
		// Token: 0x04001EBE RID: 7870
		PlayerNotFound,
		// Token: 0x04001EBF RID: 7871
		GameMapIDNotFound,
		// Token: 0x04001EC0 RID: 7872
		GameMapTypeInvalid,
		// Token: 0x04001EC1 RID: 7873
		NoFriendsFound,
		// Token: 0x04001EC2 RID: 7874
		InvalidFilter,
		// Token: 0x04001EC3 RID: 7875
		MapInvalidForLeaderboards,
		// Token: 0x04001EC4 RID: 7876
		InvalidInGamePlayerCount,
		// Token: 0x04001EC5 RID: 7877
		InvalidPlayerCountPerPage,
		// Token: 0x04001EC6 RID: 7878
		InvalidPageCount,
		// Token: 0x04001EC7 RID: 7879
		LeaderboardPageNotFound,
		// Token: 0x04001EC8 RID: 7880
		UnknownFailure,
		// Token: 0x04001EC9 RID: 7881
		GuildNotFound,
		// Token: 0x04001ECA RID: 7882
		NoGuildMembersFound,
		// Token: 0x04001ECB RID: 7883
		NoFriendsOrGuildMembersFound,
		// Token: 0x04001ECC RID: 7884
		PreviousChallengeNotFound,
		// Token: 0x04001ECD RID: 7885
		UnknownPreviousChallengeID,
		// Token: 0x04001ECE RID: 7886
		NoPlayerEntryFoundForFilter,
		// Token: 0x04001ECF RID: 7887
		ActiveChallengeNotFound,
		// Token: 0x04001ED0 RID: 7888
		UnknownActiveChallengeID
	}
}
