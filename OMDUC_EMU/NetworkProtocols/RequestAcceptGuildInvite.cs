using System;

namespace NetworkProtocols
{
	// Token: 0x02000741 RID: 1857
	public class RequestAcceptGuildInvite : BotNetMessage
	{
		// Token: 0x060041CA RID: 16842 RVA: 0x00025ABC File Offset: 0x00023CBC
		public RequestAcceptGuildInvite()
		{
			this.InitRefTypes();
			base.PacketType = 1635088610u;
		}

		// Token: 0x060041CB RID: 16843 RVA: 0x00025AD5 File Offset: 0x00023CD5
		public RequestAcceptGuildInvite(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1635088610u;
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x060041CC RID: 16844 RVA: 0x00025AF5 File Offset: 0x00023CF5
		// (set) Token: 0x060041CD RID: 16845 RVA: 0x00025AFD File Offset: 0x00023CFD
		public ulong InviteID { get; set; }

		// Token: 0x060041CE RID: 16846 RVA: 0x0011F704 File Offset: 0x0011D904
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.InviteID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060041CF RID: 16847 RVA: 0x0011F784 File Offset: 0x0011D984
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.InviteID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x060041D0 RID: 16848 RVA: 0x00025B06 File Offset: 0x00023D06
		private void InitRefTypes()
		{
			this.InviteID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002283 RID: 8835
		public const uint cPacketType = 1635088610u;
	}
}
