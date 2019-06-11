using System;

namespace NetworkProtocols
{
	// Token: 0x02000712 RID: 1810
	public class RequestCreateFriendRequest : BotNetMessage
	{
		// Token: 0x0600403B RID: 16443 RVA: 0x00024759 File Offset: 0x00022959
		public RequestCreateFriendRequest()
		{
			this.InitRefTypes();
			base.PacketType = 929024488u;
		}

		// Token: 0x0600403C RID: 16444 RVA: 0x00024772 File Offset: 0x00022972
		public RequestCreateFriendRequest(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 929024488u;
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x0600403D RID: 16445 RVA: 0x00024792 File Offset: 0x00022992
		// (set) Token: 0x0600403E RID: 16446 RVA: 0x0002479A File Offset: 0x0002299A
		public string OriginatorName { get; set; }

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x0600403F RID: 16447 RVA: 0x000247A3 File Offset: 0x000229A3
		// (set) Token: 0x06004040 RID: 16448 RVA: 0x000247AB File Offset: 0x000229AB
		public string RecipientName { get; set; }

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06004041 RID: 16449 RVA: 0x000247B4 File Offset: 0x000229B4
		// (set) Token: 0x06004042 RID: 16450 RVA: 0x000247BC File Offset: 0x000229BC
		public ulong ReferralID { get; set; }

		// Token: 0x06004043 RID: 16451 RVA: 0x0011CC10 File Offset: 0x0011AE10
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.OriginatorName);
			ArrayManager.WriteString(ref newArray, ref newSize, this.RecipientName);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.ReferralID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06004044 RID: 16452 RVA: 0x0011CCAC File Offset: 0x0011AEAC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.OriginatorName = ArrayManager.ReadString(data, ref num);
			this.RecipientName = ArrayManager.ReadString(data, ref num);
			this.ReferralID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06004045 RID: 16453 RVA: 0x000247C5 File Offset: 0x000229C5
		private void InitRefTypes()
		{
			this.OriginatorName = string.Empty;
			this.RecipientName = string.Empty;
			this.ReferralID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002203 RID: 8707
		public const uint cPacketType = 929024488u;
	}
}
