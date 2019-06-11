using System;

namespace NetworkProtocols
{
	// Token: 0x02000713 RID: 1811
	public class RequestCreateFriendRequestByName : BotNetMessage
	{
		// Token: 0x06004046 RID: 16454 RVA: 0x000247EC File Offset: 0x000229EC
		public RequestCreateFriendRequestByName()
		{
			this.InitRefTypes();
			base.PacketType = 1956477434u;
		}

		// Token: 0x06004047 RID: 16455 RVA: 0x00024805 File Offset: 0x00022A05
		public RequestCreateFriendRequestByName(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1956477434u;
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x06004048 RID: 16456 RVA: 0x00024825 File Offset: 0x00022A25
		// (set) Token: 0x06004049 RID: 16457 RVA: 0x0002482D File Offset: 0x00022A2D
		public string PlayerName { get; set; }

		// Token: 0x0600404A RID: 16458 RVA: 0x0011CD30 File Offset: 0x0011AF30
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.PlayerName);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600404B RID: 16459 RVA: 0x0011CDB0 File Offset: 0x0011AFB0
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.PlayerName = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x0600404C RID: 16460 RVA: 0x00024836 File Offset: 0x00022A36
		private void InitRefTypes()
		{
			this.PlayerName = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002207 RID: 8711
		public const uint cPacketType = 1956477434u;
	}
}
