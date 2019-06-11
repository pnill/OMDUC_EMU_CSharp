using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000616 RID: 1558
	public class RequestValidatePassword : BotNetMessage
	{
		// Token: 0x06003656 RID: 13910 RVA: 0x0001DA5E File Offset: 0x0001BC5E
		public RequestValidatePassword()
		{
			this.InitRefTypes();
			base.PacketType = 357572140u;
		}

		// Token: 0x06003657 RID: 13911 RVA: 0x0001DA77 File Offset: 0x0001BC77
		public RequestValidatePassword(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 357572140u;
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06003658 RID: 13912 RVA: 0x0001DA97 File Offset: 0x0001BC97
		// (set) Token: 0x06003659 RID: 13913 RVA: 0x0001DA9F File Offset: 0x0001BC9F
		public List<byte> Password { get; set; }

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x0600365A RID: 13914 RVA: 0x0001DAA8 File Offset: 0x0001BCA8
		// (set) Token: 0x0600365B RID: 13915 RVA: 0x0001DAB0 File Offset: 0x0001BCB0
		public string RemoteEndpoint { get; set; }

		// Token: 0x0600365C RID: 13916 RVA: 0x0010ACE8 File Offset: 0x00108EE8
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
			ArrayManager.WriteListByte(ref newArray, ref newSize, this.Password);
			ArrayManager.WriteString(ref newArray, ref newSize, this.RemoteEndpoint);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600365D RID: 13917 RVA: 0x0010AD74 File Offset: 0x00108F74
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Password = ArrayManager.ReadListByte(data, ref num);
			this.RemoteEndpoint = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x0600365E RID: 13918 RVA: 0x0001DAB9 File Offset: 0x0001BCB9
		private void InitRefTypes()
		{
			this.Password = new List<byte>();
			this.RemoteEndpoint = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001D7E RID: 7550
		public const uint cPacketType = 357572140u;
	}
}
