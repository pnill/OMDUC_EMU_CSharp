using System;

namespace NetworkProtocols
{
	// Token: 0x02000721 RID: 1825
	public class FriendRequestReceived : BotNetMessage
	{
		// Token: 0x060040B2 RID: 16562 RVA: 0x00024D56 File Offset: 0x00022F56
		public FriendRequestReceived()
		{
			this.InitRefTypes();
			base.PacketType = 519804164u;
		}

		// Token: 0x060040B3 RID: 16563 RVA: 0x00024D6F File Offset: 0x00022F6F
		public FriendRequestReceived(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 519804164u;
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x060040B4 RID: 16564 RVA: 0x00024D8F File Offset: 0x00022F8F
		// (set) Token: 0x060040B5 RID: 16565 RVA: 0x00024D97 File Offset: 0x00022F97
		public ulong OriginatorAccountSUID { get; set; }

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x060040B6 RID: 16566 RVA: 0x00024DA0 File Offset: 0x00022FA0
		// (set) Token: 0x060040B7 RID: 16567 RVA: 0x00024DA8 File Offset: 0x00022FA8
		public string OriginatorName { get; set; }

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x060040B8 RID: 16568 RVA: 0x00024DB1 File Offset: 0x00022FB1
		// (set) Token: 0x060040B9 RID: 16569 RVA: 0x00024DB9 File Offset: 0x00022FB9
		public string GuildTag { get; set; }

		// Token: 0x060040BA RID: 16570 RVA: 0x0011D8D4 File Offset: 0x0011BAD4
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.OriginatorAccountSUID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.OriginatorName);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GuildTag);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060040BB RID: 16571 RVA: 0x0011D970 File Offset: 0x0011BB70
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.OriginatorAccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.OriginatorName = ArrayManager.ReadString(data, ref num);
			this.GuildTag = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x060040BC RID: 16572 RVA: 0x00024DC2 File Offset: 0x00022FC2
		private void InitRefTypes()
		{
			this.OriginatorAccountSUID = 0UL;
			this.OriginatorName = string.Empty;
			this.GuildTag = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002228 RID: 8744
		public const uint cPacketType = 519804164u;
	}
}
