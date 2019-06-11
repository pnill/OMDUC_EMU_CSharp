using System;

namespace NetworkProtocols
{
	// Token: 0x02000480 RID: 1152
	public enum eLeaveDiscordChannelStatus
	{
		// Token: 0x040016A4 RID: 5796
		None,
		// Token: 0x040016A5 RID: 5797
		Success,
		// Token: 0x040016A6 RID: 5798
		Failure = 3,
		// Token: 0x040016A7 RID: 5799
		UserNotOnline,
		// Token: 0x040016A8 RID: 5800
		UserNotAuthenticated,
		// Token: 0x040016A9 RID: 5801
		ChannelNotFound,
		// Token: 0x040016AA RID: 5802
		UserNotInChannel
	}
}
