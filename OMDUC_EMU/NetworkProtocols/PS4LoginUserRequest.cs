using System;

namespace NetworkProtocols
{
	// Token: 0x02000592 RID: 1426
	public class PS4LoginUserRequest : BotNetMessage
	{
		// Token: 0x0600313D RID: 12605 RVA: 0x0001A64D File Offset: 0x0001884D
		public PS4LoginUserRequest()
		{
			this.InitRefTypes();
			base.PacketType = 197131932u;
		}

		// Token: 0x0600313E RID: 12606 RVA: 0x0001A666 File Offset: 0x00018866
		public PS4LoginUserRequest(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 197131932u;
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x0600313F RID: 12607 RVA: 0x0001A686 File Offset: 0x00018886
		// (set) Token: 0x06003140 RID: 12608 RVA: 0x0001A68E File Offset: 0x0001888E
		public ulong PSNAccountID { get; set; }

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06003141 RID: 12609 RVA: 0x0001A697 File Offset: 0x00018897
		// (set) Token: 0x06003142 RID: 12610 RVA: 0x0001A69F File Offset: 0x0001889F
		public string PSNName { get; set; }

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06003143 RID: 12611 RVA: 0x0001A6A8 File Offset: 0x000188A8
		// (set) Token: 0x06003144 RID: 12612 RVA: 0x0001A6B0 File Offset: 0x000188B0
		public string AccessToken { get; set; }

		// Token: 0x06003145 RID: 12613 RVA: 0x0010394C File Offset: 0x00101B4C
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.PSNAccountID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.PSNName);
			ArrayManager.WriteString(ref newArray, ref newSize, this.AccessToken);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003146 RID: 12614 RVA: 0x001039E8 File Offset: 0x00101BE8
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.PSNAccountID = ArrayManager.ReadUInt64(data, ref num);
			this.PSNName = ArrayManager.ReadString(data, ref num);
			this.AccessToken = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x06003147 RID: 12615 RVA: 0x0001A6B9 File Offset: 0x000188B9
		private void InitRefTypes()
		{
			this.PSNAccountID = 0UL;
			this.PSNName = string.Empty;
			this.AccessToken = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001BDE RID: 7134
		public const uint cPacketType = 197131932u;
	}
}
