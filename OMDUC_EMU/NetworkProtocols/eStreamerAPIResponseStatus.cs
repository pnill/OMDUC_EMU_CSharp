using System;

namespace NetworkProtocols
{
	// Token: 0x020004D9 RID: 1241
	public enum eStreamerAPIResponseStatus
	{
		// Token: 0x04001A15 RID: 6677
		Success,
		// Token: 0x04001A16 RID: 6678
		FailureGeneral,
		// Token: 0x04001A17 RID: 6679
		FailureNotPartyLeader,
		// Token: 0x04001A18 RID: 6680
		FailureOldStreamAuthAlreadyExists,
		// Token: 0x04001A19 RID: 6681
		FailurePlayerNotInTheRightPresence,
		// Token: 0x04001A1A RID: 6682
		FailurePlayerNotCertifiedStreamer
	}
}
