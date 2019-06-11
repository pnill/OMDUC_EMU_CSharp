using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000678 RID: 1656
	public class PushSabotageRankingDefinition : BotNetMessage
	{
		// Token: 0x060039F5 RID: 14837 RVA: 0x00020130 File Offset: 0x0001E330
		public PushSabotageRankingDefinition()
		{
			this.InitRefTypes();
			base.PacketType = 1747317513u;
		}

		// Token: 0x060039F6 RID: 14838 RVA: 0x00020149 File Offset: 0x0001E349
		public PushSabotageRankingDefinition(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1747317513u;
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x060039F7 RID: 14839 RVA: 0x00020169 File Offset: 0x0001E369
		// (set) Token: 0x060039F8 RID: 14840 RVA: 0x00020171 File Offset: 0x0001E371
		public List<SabotageRankingDefinitionForNetwork> SabotageTierRankingDefinitions { get; set; }

		// Token: 0x060039F9 RID: 14841 RVA: 0x00110300 File Offset: 0x0010E500
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
			ArrayManager.WriteListSabotageRankingDefinitionForNetwork(ref newArray, ref newSize, this.SabotageTierRankingDefinitions);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060039FA RID: 14842 RVA: 0x00110380 File Offset: 0x0010E580
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.SabotageTierRankingDefinitions = ArrayManager.ReadListSabotageRankingDefinitionForNetwork(data, ref num);
		}

		// Token: 0x060039FB RID: 14843 RVA: 0x0002017A File Offset: 0x0001E37A
		private void InitRefTypes()
		{
			this.SabotageTierRankingDefinitions = new List<SabotageRankingDefinitionForNetwork>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001ED9 RID: 7897
		public const uint cPacketType = 1747317513u;
	}
}
