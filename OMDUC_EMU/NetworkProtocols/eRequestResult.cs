using System;

namespace NetworkProtocols
{
	// Token: 0x020004C2 RID: 1218
	public enum eRequestResult
	{
		// Token: 0x0400188B RID: 6283
		Request_None,
		// Token: 0x0400188C RID: 6284
		Request_Success,
		// Token: 0x0400188D RID: 6285
		Request_Failure_Unknown,
		// Token: 0x0400188E RID: 6286
		Request_Failure_Level,
		// Token: 0x0400188F RID: 6287
		Request_Failure_NotEnoughFunds,
		// Token: 0x04001890 RID: 6288
		Request_Failure_NotFound,
		// Token: 0x04001891 RID: 6289
		Request_Failure_AccountError
	}
}
