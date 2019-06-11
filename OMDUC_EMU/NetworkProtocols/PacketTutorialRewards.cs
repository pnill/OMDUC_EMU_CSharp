using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000602 RID: 1538
	public class PacketTutorialRewards : BotNetMessage
	{
		// Token: 0x06003584 RID: 13700 RVA: 0x0001D0BE File Offset: 0x0001B2BE
		public PacketTutorialRewards()
		{
			this.InitRefTypes();
			base.PacketType = 1544099622u;
		}

		// Token: 0x06003585 RID: 13701 RVA: 0x0001D0D7 File Offset: 0x0001B2D7
		public PacketTutorialRewards(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1544099622u;
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06003586 RID: 13702 RVA: 0x0001D0F7 File Offset: 0x0001B2F7
		// (set) Token: 0x06003587 RID: 13703 RVA: 0x0001D0FF File Offset: 0x0001B2FF
		public ulong GameMapID { get; set; }

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06003588 RID: 13704 RVA: 0x0001D108 File Offset: 0x0001B308
		// (set) Token: 0x06003589 RID: 13705 RVA: 0x0001D110 File Offset: 0x0001B310
		public List<PacketPlayerAward> PlayerAwards { get; set; }

		// Token: 0x0600358A RID: 13706 RVA: 0x00109564 File Offset: 0x00107764
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.GameMapID);
			ArrayManager.WriteListPacketPlayerAward(ref newArray, ref newSize, this.PlayerAwards);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600358B RID: 13707 RVA: 0x001095F0 File Offset: 0x001077F0
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.GameMapID = ArrayManager.ReadUInt64(data, ref num);
			this.PlayerAwards = ArrayManager.ReadListPacketPlayerAward(data, ref num);
		}

		// Token: 0x0600358C RID: 13708 RVA: 0x0001D119 File Offset: 0x0001B319
		private void InitRefTypes()
		{
			this.GameMapID = 0UL;
			this.PlayerAwards = new List<PacketPlayerAward>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001D33 RID: 7475
		public const uint cPacketType = 1544099622u;
	}
}
