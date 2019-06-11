using System;

namespace NetworkProtocols
{
	// Token: 0x0200049C RID: 1180
	public enum ePlayerPresence
	{
		// Token: 0x04001760 RID: 5984
		PlayerPresence_None,
		// Token: 0x04001761 RID: 5985
		PlayerPresence_Offline,
		// Token: 0x04001762 RID: 5986
		PlayerPresence_Online = 3,
		// Token: 0x04001763 RID: 5987
		PlayerPresence_Matchmaking,
		// Token: 0x04001764 RID: 5988
		PlayerPresence_InLobby,
		// Token: 0x04001765 RID: 5989
		PlayerPresence_InParty,
		// Token: 0x04001766 RID: 5990
		PlayerPresence_InGame,
		// Token: 0x04001767 RID: 5991
		PlayerPresence_InPrologue = 7
	}
}
