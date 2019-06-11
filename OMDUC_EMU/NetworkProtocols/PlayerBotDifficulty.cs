using System;

namespace NetworkProtocols
{
	// Token: 0x020004ED RID: 1261
	public class PlayerBotDifficulty
	{
		// Token: 0x06002BAF RID: 11183 RVA: 0x00017206 File Offset: 0x00015406
		public PlayerBotDifficulty()
		{
			this.InitRefTypes();
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06002BB0 RID: 11184 RVA: 0x00017214 File Offset: 0x00015414
		// (set) Token: 0x06002BB1 RID: 11185 RVA: 0x0001721C File Offset: 0x0001541C
		public eBotDifficulty Level { get; set; }

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06002BB2 RID: 11186 RVA: 0x00017225 File Offset: 0x00015425
		// (set) Token: 0x06002BB3 RID: 11187 RVA: 0x0001722D File Offset: 0x0001542D
		public uint ExperienceBonus { get; set; }

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06002BB4 RID: 11188 RVA: 0x00017236 File Offset: 0x00015436
		// (set) Token: 0x06002BB5 RID: 11189 RVA: 0x0001723E File Offset: 0x0001543E
		public bool Enabled { get; set; }

		// Token: 0x06002BB6 RID: 11190 RVA: 0x000FCF7C File Offset: 0x000FB17C
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteeBotDifficulty(ref newArray, ref newSize, this.Level);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.ExperienceBonus);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.Enabled);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002BB7 RID: 11191 RVA: 0x000FCFC8 File Offset: 0x000FB1C8
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Level = ArrayManager.ReadeBotDifficulty(data, ref num);
			this.ExperienceBonus = ArrayManager.ReadUInt32(data, ref num);
			this.Enabled = ArrayManager.ReadBoolean(data, ref num);
		}

		// Token: 0x06002BB8 RID: 11192 RVA: 0x00017247 File Offset: 0x00015447
		private void InitRefTypes()
		{
			this.Level = eBotDifficulty.BotDifficulty_None;
			this.ExperienceBonus = 0u;
			this.Enabled = false;
		}
	}
}
