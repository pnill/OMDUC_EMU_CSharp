using System;

namespace NetworkProtocols
{
	// Token: 0x0200073F RID: 1855
	public class RequestSendGuildInvite : BotNetMessage
	{
		// Token: 0x060041BC RID: 16828 RVA: 0x00025A04 File Offset: 0x00023C04
		public RequestSendGuildInvite()
		{
			this.InitRefTypes();
			base.PacketType = 106595167u;
		}

		// Token: 0x060041BD RID: 16829 RVA: 0x00025A1D File Offset: 0x00023C1D
		public RequestSendGuildInvite(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 106595167u;
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x060041BE RID: 16830 RVA: 0x00025A3D File Offset: 0x00023C3D
		// (set) Token: 0x060041BF RID: 16831 RVA: 0x00025A45 File Offset: 0x00023C45
		public string TargetPlayerName { get; set; }

		// Token: 0x060041C0 RID: 16832 RVA: 0x0011F534 File Offset: 0x0011D734
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.TargetPlayerName);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060041C1 RID: 16833 RVA: 0x0011F5B4 File Offset: 0x0011D7B4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.TargetPlayerName = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x060041C2 RID: 16834 RVA: 0x00025A4E File Offset: 0x00023C4E
		private void InitRefTypes()
		{
			this.TargetPlayerName = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400227F RID: 8831
		public const uint cPacketType = 106595167u;
	}
}
