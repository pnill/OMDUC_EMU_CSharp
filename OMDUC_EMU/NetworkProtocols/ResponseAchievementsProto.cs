using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020005F8 RID: 1528
	public class ResponseAchievementsProto : BotNetMessage
	{
		// Token: 0x06003524 RID: 13604 RVA: 0x0001CCC9 File Offset: 0x0001AEC9
		public ResponseAchievementsProto()
		{
			this.InitRefTypes();
			base.PacketType = 584935640u;
		}

		// Token: 0x06003525 RID: 13605 RVA: 0x0001CCE2 File Offset: 0x0001AEE2
		public ResponseAchievementsProto(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 584935640u;
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06003526 RID: 13606 RVA: 0x0001CD02 File Offset: 0x0001AF02
		// (set) Token: 0x06003527 RID: 13607 RVA: 0x0001CD0A File Offset: 0x0001AF0A
		public List<AchievementProtoForNetwork> Achievements { get; set; }

		// Token: 0x06003528 RID: 13608 RVA: 0x00108D7C File Offset: 0x00106F7C
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
			ArrayManager.WriteListAchievementProtoForNetwork(ref newArray, ref newSize, this.Achievements);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003529 RID: 13609 RVA: 0x00108DFC File Offset: 0x00106FFC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Achievements = ArrayManager.ReadListAchievementProtoForNetwork(data, ref num);
		}

		// Token: 0x0600352A RID: 13610 RVA: 0x0001CD13 File Offset: 0x0001AF13
		private void InitRefTypes()
		{
			this.Achievements = new List<AchievementProtoForNetwork>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001D14 RID: 7444
		public const uint cPacketType = 584935640u;
	}
}
