using System;

namespace NetworkProtocols
{
	// Token: 0x02000702 RID: 1794
	public enum eCreateFriendRequestStatus
	{
		// Token: 0x0400218F RID: 8591
		CreateFriendRequestStatus_Failure,
		// Token: 0x04002190 RID: 8592
		CreateFriendRequestStatus_Success,
		// Token: 0x04002191 RID: 8593
		CreateFriendRequestStatus_AccountUnknown,
		// Token: 0x04002192 RID: 8594
		CreateFriendRequestStatus_AlreadyFriends,
		// Token: 0x04002193 RID: 8595
		CreateFriendRequestStatus_RequestAlreadyExists,
		// Token: 0x04002194 RID: 8596
		CreateFriendRequestStatus_FriendAlreadyRequested,
		// Token: 0x04002195 RID: 8597
		CreateFriendRequestStatus_OriginatorTooManyFriends,
		// Token: 0x04002196 RID: 8598
		CreateFriendRequestStatus_RecipientTooManyFriends
	}
}
