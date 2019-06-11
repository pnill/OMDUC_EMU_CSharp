using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020006C6 RID: 1734
	public class LobbyListUpdateData
	{
		// Token: 0x06003E37 RID: 15927 RVA: 0x00022F44 File Offset: 0x00021144
		public LobbyListUpdateData()
		{
			this.InitRefTypes();
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06003E38 RID: 15928 RVA: 0x00022F52 File Offset: 0x00021152
		// (set) Token: 0x06003E39 RID: 15929 RVA: 0x00022F5A File Offset: 0x0002115A
		public List<ulong> ClosedLobbies { get; set; }

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x06003E3A RID: 15930 RVA: 0x00022F63 File Offset: 0x00021163
		// (set) Token: 0x06003E3B RID: 15931 RVA: 0x00022F6B File Offset: 0x0002116B
		public List<LobbyListEntry> ModifiedEntries { get; set; }

		// Token: 0x06003E3C RID: 15932 RVA: 0x00116698 File Offset: 0x00114898
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteListUInt64(ref newArray, ref newSize, this.ClosedLobbies);
			ArrayManager.WriteListLobbyListEntry(ref newArray, ref newSize, this.ModifiedEntries);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003E3D RID: 15933 RVA: 0x001166D4 File Offset: 0x001148D4
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.ClosedLobbies = ArrayManager.ReadListUInt64(data, ref num);
			this.ModifiedEntries = ArrayManager.ReadListLobbyListEntry(data, ref num);
		}

		// Token: 0x06003E3E RID: 15934 RVA: 0x00022F74 File Offset: 0x00021174
		private void InitRefTypes()
		{
			this.ClosedLobbies = new List<ulong>();
			this.ModifiedEntries = new List<LobbyListEntry>();
		}
	}
}
