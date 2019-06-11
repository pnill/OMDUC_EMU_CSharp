using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000689 RID: 1673
	public class ResponseKeystoneLeaderboardInfo : BotNetMessage
	{
		// Token: 0x06003AB5 RID: 15029 RVA: 0x00020A2E File Offset: 0x0001EC2E
		public ResponseKeystoneLeaderboardInfo()
		{
			this.InitRefTypes();
			base.PacketType = 4172070350u;
		}

		// Token: 0x06003AB6 RID: 15030 RVA: 0x00020A47 File Offset: 0x0001EC47
		public ResponseKeystoneLeaderboardInfo(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 4172070350u;
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06003AB7 RID: 15031 RVA: 0x00020A67 File Offset: 0x0001EC67
		// (set) Token: 0x06003AB8 RID: 15032 RVA: 0x00020A6F File Offset: 0x0001EC6F
		public eLeaderboardOperationResult Status { get; set; }

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06003AB9 RID: 15033 RVA: 0x00020A78 File Offset: 0x0001EC78
		// (set) Token: 0x06003ABA RID: 15034 RVA: 0x00020A80 File Offset: 0x0001EC80
		public List<KeystonePlayerInfoForNetwork> PlayerList { get; set; }

		// Token: 0x06003ABB RID: 15035 RVA: 0x00111550 File Offset: 0x0010F750
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
			ArrayManager.WriteeLeaderboardOperationResult(ref newArray, ref newSize, this.Status);
			ArrayManager.WriteListKeystonePlayerInfoForNetwork(ref newArray, ref newSize, this.PlayerList);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003ABC RID: 15036 RVA: 0x001115DC File Offset: 0x0010F7DC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Status = ArrayManager.ReadeLeaderboardOperationResult(data, ref num);
			this.PlayerList = ArrayManager.ReadListKeystonePlayerInfoForNetwork(data, ref num);
		}

		// Token: 0x06003ABD RID: 15037 RVA: 0x00020A89 File Offset: 0x0001EC89
		private void InitRefTypes()
		{
			this.Status = eLeaderboardOperationResult.Success;
			this.PlayerList = new List<KeystonePlayerInfoForNetwork>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001F1E RID: 7966
		public const uint cPacketType = 4172070350u;
	}
}
