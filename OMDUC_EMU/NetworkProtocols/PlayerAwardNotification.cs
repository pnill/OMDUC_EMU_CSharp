using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x0200056E RID: 1390
	public class PlayerAwardNotification : BotNetMessage
	{
		// Token: 0x06002F5A RID: 12122 RVA: 0x00019297 File Offset: 0x00017497
		public PlayerAwardNotification()
		{
			this.InitRefTypes();
			base.PacketType = 2573065639u;
		}

		// Token: 0x06002F5B RID: 12123 RVA: 0x000192B0 File Offset: 0x000174B0
		public PlayerAwardNotification(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2573065639u;
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06002F5C RID: 12124 RVA: 0x000192D0 File Offset: 0x000174D0
		// (set) Token: 0x06002F5D RID: 12125 RVA: 0x000192D8 File Offset: 0x000174D8
		public List<BaseAwardItem> Items { get; set; }

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06002F5E RID: 12126 RVA: 0x000192E1 File Offset: 0x000174E1
		// (set) Token: 0x06002F5F RID: 12127 RVA: 0x000192E9 File Offset: 0x000174E9
		public uint RewardPercentage { get; set; }

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06002F60 RID: 12128 RVA: 0x000192F2 File Offset: 0x000174F2
		// (set) Token: 0x06002F61 RID: 12129 RVA: 0x000192FA File Offset: 0x000174FA
		public uint StartingLevel { get; set; }

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06002F62 RID: 12130 RVA: 0x00019303 File Offset: 0x00017503
		// (set) Token: 0x06002F63 RID: 12131 RVA: 0x0001930B File Offset: 0x0001750B
		public uint StartingXP { get; set; }

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06002F64 RID: 12132 RVA: 0x00019314 File Offset: 0x00017514
		// (set) Token: 0x06002F65 RID: 12133 RVA: 0x0001931C File Offset: 0x0001751C
		public uint EndingLevel { get; set; }

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06002F66 RID: 12134 RVA: 0x00019325 File Offset: 0x00017525
		// (set) Token: 0x06002F67 RID: 12135 RVA: 0x0001932D File Offset: 0x0001752D
		public uint EndingXP { get; set; }

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06002F68 RID: 12136 RVA: 0x00019336 File Offset: 0x00017536
		// (set) Token: 0x06002F69 RID: 12137 RVA: 0x0001933E File Offset: 0x0001753E
		public ePriceCurrencyType SpentCurrency { get; set; }

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06002F6A RID: 12138 RVA: 0x00019347 File Offset: 0x00017547
		// (set) Token: 0x06002F6B RID: 12139 RVA: 0x0001934F File Offset: 0x0001754F
		public decimal SpentCost { get; set; }

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06002F6C RID: 12140 RVA: 0x00019358 File Offset: 0x00017558
		// (set) Token: 0x06002F6D RID: 12141 RVA: 0x00019360 File Offset: 0x00017560
		public ulong OfferID { get; set; }

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06002F6E RID: 12142 RVA: 0x00019369 File Offset: 0x00017569
		// (set) Token: 0x06002F6F RID: 12143 RVA: 0x00019371 File Offset: 0x00017571
		public ulong LimitedTimeOfferID { get; set; }

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06002F70 RID: 12144 RVA: 0x0001937A File Offset: 0x0001757A
		// (set) Token: 0x06002F71 RID: 12145 RVA: 0x00019382 File Offset: 0x00017582
		public ulong RotatingStoreDefinitionID { get; set; }

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06002F72 RID: 12146 RVA: 0x0001938B File Offset: 0x0001758B
		// (set) Token: 0x06002F73 RID: 12147 RVA: 0x00019393 File Offset: 0x00017593
		public ulong RotatingStoreInstanceID { get; set; }

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06002F74 RID: 12148 RVA: 0x0001939C File Offset: 0x0001759C
		// (set) Token: 0x06002F75 RID: 12149 RVA: 0x000193A4 File Offset: 0x000175A4
		public Guid GameStateID { get; set; }

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06002F76 RID: 12150 RVA: 0x000193AD File Offset: 0x000175AD
		// (set) Token: 0x06002F77 RID: 12151 RVA: 0x000193B5 File Offset: 0x000175B5
		public bool OfferWasFeatured { get; set; }

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06002F78 RID: 12152 RVA: 0x000193BE File Offset: 0x000175BE
		// (set) Token: 0x06002F79 RID: 12153 RVA: 0x000193C6 File Offset: 0x000175C6
		public bool ShowPostGameRewards { get; set; }

		// Token: 0x06002F7A RID: 12154 RVA: 0x00100DF8 File Offset: 0x000FEFF8
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
			ArrayManager.WriteListBaseAwardItem(ref newArray, ref newSize, this.Items);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.RewardPercentage);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.StartingLevel);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.StartingXP);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.EndingLevel);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.EndingXP);
			ArrayManager.WriteePriceCurrencyType(ref newArray, ref newSize, this.SpentCurrency);
			ArrayManager.WriteDecimal(ref newArray, ref newSize, this.SpentCost);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.OfferID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.LimitedTimeOfferID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.RotatingStoreDefinitionID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.RotatingStoreInstanceID);
			ArrayManager.WriteGuid(ref newArray, ref newSize, this.GameStateID);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.OfferWasFeatured);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.ShowPostGameRewards);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002F7B RID: 12155 RVA: 0x00100F48 File Offset: 0x000FF148
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Items = ArrayManager.ReadListBaseAwardItem(data, ref num);
			this.RewardPercentage = ArrayManager.ReadUInt32(data, ref num);
			this.StartingLevel = ArrayManager.ReadUInt32(data, ref num);
			this.StartingXP = ArrayManager.ReadUInt32(data, ref num);
			this.EndingLevel = ArrayManager.ReadUInt32(data, ref num);
			this.EndingXP = ArrayManager.ReadUInt32(data, ref num);
			this.SpentCurrency = ArrayManager.ReadePriceCurrencyType(data, ref num);
			this.SpentCost = ArrayManager.ReadDecimal(data, ref num);
			this.OfferID = ArrayManager.ReadUInt64(data, ref num);
			this.LimitedTimeOfferID = ArrayManager.ReadUInt64(data, ref num);
			this.RotatingStoreDefinitionID = ArrayManager.ReadUInt64(data, ref num);
			this.RotatingStoreInstanceID = ArrayManager.ReadUInt64(data, ref num);
			this.GameStateID = ArrayManager.ReadGuid(data, ref num);
			this.OfferWasFeatured = ArrayManager.ReadBoolean(data, ref num);
			this.ShowPostGameRewards = ArrayManager.ReadBoolean(data, ref num);
		}

		// Token: 0x06002F7C RID: 12156 RVA: 0x00101074 File Offset: 0x000FF274
		private void InitRefTypes()
		{
			this.Items = new List<BaseAwardItem>();
			this.RewardPercentage = 0u;
			this.StartingLevel = 0u;
			this.StartingXP = 0u;
			this.EndingLevel = 0u;
			this.EndingXP = 0u;
			this.SpentCurrency = ePriceCurrencyType.None;
			this.SpentCost = 0m;
			this.OfferID = 0UL;
			this.LimitedTimeOfferID = 0UL;
			this.RotatingStoreDefinitionID = 0UL;
			this.RotatingStoreInstanceID = 0UL;
			this.GameStateID = default(Guid);
			this.OfferWasFeatured = false;
			this.ShowPostGameRewards = false;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001B26 RID: 6950
		public const uint cPacketType = 2573065639u;
	}
}
