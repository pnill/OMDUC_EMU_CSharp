using System;

namespace NetworkProtocols
{
	// Token: 0x020006D6 RID: 1750
	public class MatchmakingGamePlayer
	{
		// Token: 0x06003E8D RID: 16013 RVA: 0x0002336C File Offset: 0x0002156C
		public MatchmakingGamePlayer()
		{
			this.InitRefTypes();
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x06003E8E RID: 16014 RVA: 0x0002337A File Offset: 0x0002157A
		// (set) Token: 0x06003E8F RID: 16015 RVA: 0x00023382 File Offset: 0x00021582
		public string Username { get; set; }

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x06003E90 RID: 16016 RVA: 0x0002338B File Offset: 0x0002158B
		// (set) Token: 0x06003E91 RID: 16017 RVA: 0x00023393 File Offset: 0x00021593
		public ulong AccountSUID { get; set; }

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x06003E92 RID: 16018 RVA: 0x0002339C File Offset: 0x0002159C
		// (set) Token: 0x06003E93 RID: 16019 RVA: 0x000233A4 File Offset: 0x000215A4
		public uint Team { get; set; }

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x06003E94 RID: 16020 RVA: 0x000233AD File Offset: 0x000215AD
		// (set) Token: 0x06003E95 RID: 16021 RVA: 0x000233B5 File Offset: 0x000215B5
		public bool IsReady { get; set; }

		// Token: 0x06003E96 RID: 16022 RVA: 0x00116E68 File Offset: 0x00115068
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteString(ref newArray, ref newSize, this.Username);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.AccountSUID);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.Team);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsReady);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003E97 RID: 16023 RVA: 0x00116EC4 File Offset: 0x001150C4
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Username = ArrayManager.ReadString(data, ref num);
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.Team = ArrayManager.ReadUInt32(data, ref num);
			this.IsReady = ArrayManager.ReadBoolean(data, ref num);
		}

		// Token: 0x06003E98 RID: 16024 RVA: 0x000233BE File Offset: 0x000215BE
		private void InitRefTypes()
		{
			this.Username = string.Empty;
			this.AccountSUID = 0UL;
			this.Team = 0u;
			this.IsReady = false;
		}
	}
}
