using System;

namespace NetworkProtocols
{
	// Token: 0x020004E2 RID: 1250
	public class PushPlayerProgress : BotNetMessage
	{
		// Token: 0x06002B4B RID: 11083 RVA: 0x00016D5F File Offset: 0x00014F5F
		public PushPlayerProgress()
		{
			this.InitRefTypes();
			base.PacketType = 3391275122u;
		}

		// Token: 0x06002B4C RID: 11084 RVA: 0x00016D78 File Offset: 0x00014F78
		public PushPlayerProgress(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3391275122u;
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06002B4D RID: 11085 RVA: 0x00016D98 File Offset: 0x00014F98
		// (set) Token: 0x06002B4E RID: 11086 RVA: 0x00016DA0 File Offset: 0x00014FA0
		public LevelProgress LevelProgress { get; set; }

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06002B4F RID: 11087 RVA: 0x00016DA9 File Offset: 0x00014FA9
		// (set) Token: 0x06002B50 RID: 11088 RVA: 0x00016DB1 File Offset: 0x00014FB1
		public HeroProgress HeroProgress { get; set; }

		// Token: 0x06002B51 RID: 11089 RVA: 0x000FC6AC File Offset: 0x000FA8AC
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt32(ref newArray, ref newSize, base.PacketType);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, base.SessionToken);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, base.SecurityToken);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, base.RequestID);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, 0u);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, 0u);
			ArrayManager.WriteLevelProgress(ref newArray, ref newSize, this.LevelProgress);
			ArrayManager.WriteHeroProgress(ref newArray, ref newSize, this.HeroProgress);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002B52 RID: 11090 RVA: 0x000FC738 File Offset: 0x000FA938
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.LevelProgress = ArrayManager.ReadLevelProgress(data, ref num);
			this.HeroProgress = ArrayManager.ReadHeroProgress(data, ref num);
		}

		// Token: 0x06002B53 RID: 11091 RVA: 0x00016DBA File Offset: 0x00014FBA
		private void InitRefTypes()
		{
			this.LevelProgress = new LevelProgress();
			this.HeroProgress = new HeroProgress();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001A2E RID: 6702
		public const uint cPacketType = 3391275122u;
	}
}
