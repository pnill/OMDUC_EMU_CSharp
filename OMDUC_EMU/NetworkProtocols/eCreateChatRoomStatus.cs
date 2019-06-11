using System;

namespace NetworkProtocols
{
	// Token: 0x0200047D RID: 1149
	public enum eCreateChatRoomStatus
	{
		// Token: 0x04001694 RID: 5780
		None,
		// Token: 0x04001695 RID: 5781
		Success,
		// Token: 0x04001696 RID: 5782
		Failure = 3,
		// Token: 0x04001697 RID: 5783
		RoomNameNotUnique,
		// Token: 0x04001698 RID: 5784
		UserNotOnline
	}
}
