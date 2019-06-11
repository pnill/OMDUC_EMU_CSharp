using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000573 RID: 1395
	public class PushTutorialProgress : BotNetMessage
	{
		// Token: 0x06002FD4 RID: 12244 RVA: 0x000196E9 File Offset: 0x000178E9
		public PushTutorialProgress()
		{
			this.InitRefTypes();
			base.PacketType = 8969000u;
		}

		// Token: 0x06002FD5 RID: 12245 RVA: 0x00019702 File Offset: 0x00017902
		public PushTutorialProgress(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 8969000u;
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06002FD6 RID: 12246 RVA: 0x00019722 File Offset: 0x00017922
		// (set) Token: 0x06002FD7 RID: 12247 RVA: 0x0001972A File Offset: 0x0001792A
		public List<PacketTutorialProgress> TutorialProgress { get; set; }

		// Token: 0x06002FD8 RID: 12248 RVA: 0x001017C8 File Offset: 0x000FF9C8
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
			ArrayManager.WriteListPacketTutorialProgress(ref newArray, ref newSize, this.TutorialProgress);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002FD9 RID: 12249 RVA: 0x00101848 File Offset: 0x000FFA48
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.TutorialProgress = ArrayManager.ReadListPacketTutorialProgress(data, ref num);
		}

		// Token: 0x06002FDA RID: 12250 RVA: 0x00019733 File Offset: 0x00017933
		private void InitRefTypes()
		{
			this.TutorialProgress = new List<PacketTutorialProgress>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001B5B RID: 7003
		public const uint cPacketType = 8969000u;
	}
}
