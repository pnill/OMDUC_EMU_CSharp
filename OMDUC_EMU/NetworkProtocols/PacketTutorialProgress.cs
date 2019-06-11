using System;

namespace NetworkProtocols
{
	// Token: 0x020004EE RID: 1262
	public class PacketTutorialProgress
	{
		// Token: 0x06002BB9 RID: 11193 RVA: 0x0001725E File Offset: 0x0001545E
		public PacketTutorialProgress()
		{
			this.InitRefTypes();
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06002BBA RID: 11194 RVA: 0x0001726C File Offset: 0x0001546C
		// (set) Token: 0x06002BBB RID: 11195 RVA: 0x00017274 File Offset: 0x00015474
		public eSceneID SceneID { get; set; }

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06002BBC RID: 11196 RVA: 0x0001727D File Offset: 0x0001547D
		// (set) Token: 0x06002BBD RID: 11197 RVA: 0x00017285 File Offset: 0x00015485
		public bool InProgress { get; set; }

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06002BBE RID: 11198 RVA: 0x0001728E File Offset: 0x0001548E
		// (set) Token: 0x06002BBF RID: 11199 RVA: 0x00017296 File Offset: 0x00015496
		public bool IsComplete { get; set; }

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06002BC0 RID: 11200 RVA: 0x0001729F File Offset: 0x0001549F
		// (set) Token: 0x06002BC1 RID: 11201 RVA: 0x000172A7 File Offset: 0x000154A7
		public ulong NextSection { get; set; }

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06002BC2 RID: 11202 RVA: 0x000172B0 File Offset: 0x000154B0
		// (set) Token: 0x06002BC3 RID: 11203 RVA: 0x000172B8 File Offset: 0x000154B8
		public ulong TabID { get; set; }

		// Token: 0x06002BC4 RID: 11204 RVA: 0x000FD004 File Offset: 0x000FB204
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteeSceneID(ref newArray, ref newSize, this.SceneID);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.InProgress);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsComplete);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.NextSection);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.TabID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002BC5 RID: 11205 RVA: 0x000FD070 File Offset: 0x000FB270
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.SceneID = ArrayManager.ReadeSceneID(data, ref num);
			this.InProgress = ArrayManager.ReadBoolean(data, ref num);
			this.IsComplete = ArrayManager.ReadBoolean(data, ref num);
			this.NextSection = ArrayManager.ReadUInt64(data, ref num);
			this.TabID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06002BC6 RID: 11206 RVA: 0x000172C1 File Offset: 0x000154C1
		private void InitRefTypes()
		{
			this.SceneID = eSceneID.LandingPage;
			this.InProgress = false;
			this.IsComplete = false;
			this.NextSection = 0UL;
			this.TabID = 0UL;
		}
	}
}
