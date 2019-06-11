using System;

namespace NetworkProtocols
{
	// Token: 0x02000618 RID: 1560
	public class RequestInitiateSteamTransaction : BotNetMessage
	{
		// Token: 0x06003666 RID: 13926 RVA: 0x0001DB32 File Offset: 0x0001BD32
		public RequestInitiateSteamTransaction()
		{
			this.InitRefTypes();
			base.PacketType = 4045256113u;
		}

		// Token: 0x06003667 RID: 13927 RVA: 0x0001DB4B File Offset: 0x0001BD4B
		public RequestInitiateSteamTransaction(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 4045256113u;
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06003668 RID: 13928 RVA: 0x0001DB6B File Offset: 0x0001BD6B
		// (set) Token: 0x06003669 RID: 13929 RVA: 0x0001DB73 File Offset: 0x0001BD73
		public ulong SteamID { get; set; }

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x0600366A RID: 13930 RVA: 0x0001DB7C File Offset: 0x0001BD7C
		// (set) Token: 0x0600366B RID: 13931 RVA: 0x0001DB84 File Offset: 0x0001BD84
		public ulong OfferID { get; set; }

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x0600366C RID: 13932 RVA: 0x0001DB8D File Offset: 0x0001BD8D
		// (set) Token: 0x0600366D RID: 13933 RVA: 0x0001DB95 File Offset: 0x0001BD95
		public string Language { get; set; }

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x0600366E RID: 13934 RVA: 0x0001DB9E File Offset: 0x0001BD9E
		// (set) Token: 0x0600366F RID: 13935 RVA: 0x0001DBA6 File Offset: 0x0001BDA6
		public ePriceCurrencyType CurrencyType { get; set; }

		// Token: 0x06003670 RID: 13936 RVA: 0x0010AED4 File Offset: 0x001090D4
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.SteamID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.OfferID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Language);
			ArrayManager.WriteePriceCurrencyType(ref newArray, ref newSize, this.CurrencyType);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003671 RID: 13937 RVA: 0x0010AF80 File Offset: 0x00109180
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.SteamID = ArrayManager.ReadUInt64(data, ref num);
			this.OfferID = ArrayManager.ReadUInt64(data, ref num);
			this.Language = ArrayManager.ReadString(data, ref num);
			this.CurrencyType = ArrayManager.ReadePriceCurrencyType(data, ref num);
		}

		// Token: 0x06003672 RID: 13938 RVA: 0x0001DBAF File Offset: 0x0001BDAF
		private void InitRefTypes()
		{
			this.SteamID = 0UL;
			this.OfferID = 0UL;
			this.Language = string.Empty;
			this.CurrencyType = ePriceCurrencyType.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001D83 RID: 7555
		public const uint cPacketType = 4045256113u;
	}
}
