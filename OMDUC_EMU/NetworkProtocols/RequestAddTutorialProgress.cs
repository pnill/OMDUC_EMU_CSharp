using System;

namespace NetworkProtocols
{
	// Token: 0x020004EF RID: 1263
	public class RequestAddTutorialProgress : BotNetMessage
	{
		// Token: 0x06002BC7 RID: 11207 RVA: 0x000172E8 File Offset: 0x000154E8
		public RequestAddTutorialProgress()
		{
			this.InitRefTypes();
			base.PacketType = 3184606052u;
		}

		// Token: 0x06002BC8 RID: 11208 RVA: 0x00017301 File Offset: 0x00015501
		public RequestAddTutorialProgress(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3184606052u;
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06002BC9 RID: 11209 RVA: 0x00017321 File Offset: 0x00015521
		// (set) Token: 0x06002BCA RID: 11210 RVA: 0x00017329 File Offset: 0x00015529
		public eSceneID SceneID { get; set; }

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06002BCB RID: 11211 RVA: 0x00017332 File Offset: 0x00015532
		// (set) Token: 0x06002BCC RID: 11212 RVA: 0x0001733A File Offset: 0x0001553A
		public bool InProgress { get; set; }

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06002BCD RID: 11213 RVA: 0x00017343 File Offset: 0x00015543
		// (set) Token: 0x06002BCE RID: 11214 RVA: 0x0001734B File Offset: 0x0001554B
		public bool IsComplete { get; set; }

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06002BCF RID: 11215 RVA: 0x00017354 File Offset: 0x00015554
		// (set) Token: 0x06002BD0 RID: 11216 RVA: 0x0001735C File Offset: 0x0001555C
		public ulong NextSection { get; set; }

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06002BD1 RID: 11217 RVA: 0x00017365 File Offset: 0x00015565
		// (set) Token: 0x06002BD2 RID: 11218 RVA: 0x0001736D File Offset: 0x0001556D
		public ulong TabID { get; set; }

		// Token: 0x06002BD3 RID: 11219 RVA: 0x000FD0C8 File Offset: 0x000FB2C8
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
			ArrayManager.WriteeSceneID(ref newArray, ref newSize, this.SceneID);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.InProgress);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsComplete);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.NextSection);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.TabID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002BD4 RID: 11220 RVA: 0x000FD184 File Offset: 0x000FB384
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.SceneID = ArrayManager.ReadeSceneID(data, ref num);
			this.InProgress = ArrayManager.ReadBoolean(data, ref num);
			this.IsComplete = ArrayManager.ReadBoolean(data, ref num);
			this.NextSection = ArrayManager.ReadUInt64(data, ref num);
			this.TabID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06002BD5 RID: 11221 RVA: 0x00017376 File Offset: 0x00015576
		private void InitRefTypes()
		{
			this.SceneID = eSceneID.LandingPage;
			this.InProgress = false;
			this.IsComplete = false;
			this.NextSection = 0UL;
			this.TabID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001A56 RID: 6742
		public const uint cPacketType = 3184606052u;
	}
}
