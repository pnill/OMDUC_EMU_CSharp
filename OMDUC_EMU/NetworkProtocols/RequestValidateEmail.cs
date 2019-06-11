using System;

namespace NetworkProtocols
{
	// Token: 0x02000610 RID: 1552
	public class RequestValidateEmail : BotNetMessage
	{
		// Token: 0x0600362C RID: 13868 RVA: 0x0001D836 File Offset: 0x0001BA36
		public RequestValidateEmail()
		{
			this.InitRefTypes();
			base.PacketType = 2231136327u;
		}

		// Token: 0x0600362D RID: 13869 RVA: 0x0001D84F File Offset: 0x0001BA4F
		public RequestValidateEmail(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2231136327u;
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x0600362E RID: 13870 RVA: 0x0001D86F File Offset: 0x0001BA6F
		// (set) Token: 0x0600362F RID: 13871 RVA: 0x0001D877 File Offset: 0x0001BA77
		public string Email { get; set; }

		// Token: 0x06003630 RID: 13872 RVA: 0x0010A778 File Offset: 0x00108978
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.Email);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003631 RID: 13873 RVA: 0x0010A7F8 File Offset: 0x001089F8
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Email = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x06003632 RID: 13874 RVA: 0x0001D880 File Offset: 0x0001BA80
		private void InitRefTypes()
		{
			this.Email = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001D72 RID: 7538
		public const uint cPacketType = 2231136327u;
	}
}
