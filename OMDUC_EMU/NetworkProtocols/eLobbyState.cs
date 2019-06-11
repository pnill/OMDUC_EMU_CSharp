using System;

namespace NetworkProtocols
{
	// Token: 0x0200068C RID: 1676
	public enum eLobbyState
	{
		// Token: 0x04001F30 RID: 7984
		LobbyState_None,
		// Token: 0x04001F31 RID: 7985
		LobbyState_Setup,
		// Token: 0x04001F32 RID: 7986
		LobbyState_Idle,
		// Token: 0x04001F33 RID: 7987
		LobbyState_Game_SelectTeam = 20,
		// Token: 0x04001F34 RID: 7988
		LobbyState_Game_SelectCharacters,
		// Token: 0x04001F35 RID: 7989
		LobbyState_Game_Launching,
		// Token: 0x04001F36 RID: 7990
		LobbyState_Game_InGame,
		// Token: 0x04001F37 RID: 7991
		LobbyState_Game_PostGame,
		// Token: 0x04001F38 RID: 7992
		LobbyState_Game_Finished,
		// Token: 0x04001F39 RID: 7993
		LobbyState_Game_Closed
	}
}
