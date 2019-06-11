using System;

namespace NetworkProtocols
{
	// Token: 0x02000701 RID: 1793
	public static class ProtocolVersionHelper
	{
		// Token: 0x0600400E RID: 16398 RVA: 0x00024599 File Offset: 0x00022799
		public static uint GetBuildVersion()
		{
			return Convert.ToUInt32(ProtocolVersion.cProtocolVersion.Split(new char[]
			{
				'.'
			})[2]);
		}

		// Token: 0x0600400F RID: 16399 RVA: 0x000245B7 File Offset: 0x000227B7
		public static uint GetHotfixVersion()
		{
			return Convert.ToUInt32(ProtocolVersion.cProtocolVersion.Split(new char[]
			{
				'.'
			})[3]);
		}
	}
}
