using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000773 RID: 1907
	public class ResponseGuildListInfo : BotNetMessage
	{
		// Token: 0x060043AD RID: 17325 RVA: 0x00027033 File Offset: 0x00025233
		public ResponseGuildListInfo()
		{
			this.InitRefTypes();
			base.PacketType = 2308775205u;
		}

		// Token: 0x060043AE RID: 17326 RVA: 0x0002704C File Offset: 0x0002524C
		public ResponseGuildListInfo(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2308775205u;
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x060043AF RID: 17327 RVA: 0x0002706C File Offset: 0x0002526C
		// (set) Token: 0x060043B0 RID: 17328 RVA: 0x00027074 File Offset: 0x00025274
		public eGuildOperationStatus Status { get; set; }

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x060043B1 RID: 17329 RVA: 0x0002707D File Offset: 0x0002527D
		// (set) Token: 0x060043B2 RID: 17330 RVA: 0x00027085 File Offset: 0x00025285
		public List<GuildLeaderboardInfoForNetwork> GuildList { get; set; }

		// Token: 0x060043B3 RID: 17331 RVA: 0x00122720 File Offset: 0x00120920
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
			ArrayManager.WriteeGuildOperationStatus(ref newArray, ref newSize, this.Status);
			ArrayManager.WriteListGuildLeaderboardInfoForNetwork(ref newArray, ref newSize, this.GuildList);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060043B4 RID: 17332 RVA: 0x001227AC File Offset: 0x001209AC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Status = ArrayManager.ReadeGuildOperationStatus(data, ref num);
			this.GuildList = ArrayManager.ReadListGuildLeaderboardInfoForNetwork(data, ref num);
		}

		// Token: 0x060043B5 RID: 17333 RVA: 0x0002708E File Offset: 0x0002528E
		private void InitRefTypes()
		{
			this.Status = eGuildOperationStatus.None;
			this.GuildList = new List<GuildLeaderboardInfoForNetwork>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002326 RID: 8998
		public const uint cPacketType = 2308775205u;
	}
}
