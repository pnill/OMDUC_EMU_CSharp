using System;

namespace NetworkProtocols
{
	// Token: 0x02000688 RID: 1672
	public class RequestKeystoneLeaderboardInfo : BotNetMessage
	{
		// Token: 0x06003AA8 RID: 15016 RVA: 0x00020987 File Offset: 0x0001EB87
		public RequestKeystoneLeaderboardInfo()
		{
			this.InitRefTypes();
			base.PacketType = 1205638919u;
		}

		// Token: 0x06003AA9 RID: 15017 RVA: 0x000209A0 File Offset: 0x0001EBA0
		public RequestKeystoneLeaderboardInfo(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1205638919u;
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x06003AAA RID: 15018 RVA: 0x000209C0 File Offset: 0x0001EBC0
		// (set) Token: 0x06003AAB RID: 15019 RVA: 0x000209C8 File Offset: 0x0001EBC8
		public ulong BucketID { get; set; }

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x06003AAC RID: 15020 RVA: 0x000209D1 File Offset: 0x0001EBD1
		// (set) Token: 0x06003AAD RID: 15021 RVA: 0x000209D9 File Offset: 0x0001EBD9
		public string PlayerName { get; set; }

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06003AAE RID: 15022 RVA: 0x000209E2 File Offset: 0x0001EBE2
		// (set) Token: 0x06003AAF RID: 15023 RVA: 0x000209EA File Offset: 0x0001EBEA
		public eLeaderboardSearchType SearchType { get; set; }

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06003AB0 RID: 15024 RVA: 0x000209F3 File Offset: 0x0001EBF3
		// (set) Token: 0x06003AB1 RID: 15025 RVA: 0x000209FB File Offset: 0x0001EBFB
		public eLeaderboardFilter Filter { get; set; }

		// Token: 0x06003AB2 RID: 15026 RVA: 0x00111410 File Offset: 0x0010F610
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.BucketID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.PlayerName);
			ArrayManager.WriteeLeaderboardSearchType(ref newArray, ref newSize, this.SearchType);
			ArrayManager.WriteeLeaderboardFilter(ref newArray, ref newSize, this.Filter);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003AB3 RID: 15027 RVA: 0x001114BC File Offset: 0x0010F6BC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.BucketID = ArrayManager.ReadUInt64(data, ref num);
			this.PlayerName = ArrayManager.ReadString(data, ref num);
			this.SearchType = ArrayManager.ReadeLeaderboardSearchType(data, ref num);
			this.Filter = ArrayManager.ReadeLeaderboardFilter(data, ref num);
		}

		// Token: 0x06003AB4 RID: 15028 RVA: 0x00020A04 File Offset: 0x0001EC04
		private void InitRefTypes()
		{
			this.BucketID = 0UL;
			this.PlayerName = string.Empty;
			this.SearchType = eLeaderboardSearchType.None;
			this.Filter = eLeaderboardFilter.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001F19 RID: 7961
		public const uint cPacketType = 1205638919u;
	}
}
