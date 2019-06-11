using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020005AB RID: 1451
	public class ResponseHeroLevelRewards : BotNetMessage
	{
		// Token: 0x0600327E RID: 12926 RVA: 0x0001B28D File Offset: 0x0001948D
		public ResponseHeroLevelRewards()
		{
			this.InitRefTypes();
			base.PacketType = 2260294134u;
		}

		// Token: 0x0600327F RID: 12927 RVA: 0x0001B2A6 File Offset: 0x000194A6
		public ResponseHeroLevelRewards(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2260294134u;
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06003280 RID: 12928 RVA: 0x0001B2C6 File Offset: 0x000194C6
		// (set) Token: 0x06003281 RID: 12929 RVA: 0x0001B2CE File Offset: 0x000194CE
		public List<PacketHeroLevelReward> Rewards { get; set; }

		// Token: 0x06003282 RID: 12930 RVA: 0x001052EC File Offset: 0x001034EC
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
			ArrayManager.WriteListPacketHeroLevelReward(ref newArray, ref newSize, this.Rewards);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003283 RID: 12931 RVA: 0x0010536C File Offset: 0x0010356C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Rewards = ArrayManager.ReadListPacketHeroLevelReward(data, ref num);
		}

		// Token: 0x06003284 RID: 12932 RVA: 0x0001B2D7 File Offset: 0x000194D7
		private void InitRefTypes()
		{
			this.Rewards = new List<PacketHeroLevelReward>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001C52 RID: 7250
		public const uint cPacketType = 2260294134u;
	}
}
