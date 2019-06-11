using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x0200058D RID: 1421
	public class UserLoginRequest : BotNetMessage
	{
		// Token: 0x06003106 RID: 12550 RVA: 0x0001A3EC File Offset: 0x000185EC
		public UserLoginRequest()
		{
			this.InitRefTypes();
			base.PacketType = 47558132u;
		}

		// Token: 0x06003107 RID: 12551 RVA: 0x0001A405 File Offset: 0x00018605
		public UserLoginRequest(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 47558132u;
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06003108 RID: 12552 RVA: 0x0001A425 File Offset: 0x00018625
		// (set) Token: 0x06003109 RID: 12553 RVA: 0x0001A42D File Offset: 0x0001862D
		public string Username { get; set; }

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x0600310A RID: 12554 RVA: 0x0001A436 File Offset: 0x00018636
		// (set) Token: 0x0600310B RID: 12555 RVA: 0x0001A43E File Offset: 0x0001863E
		public List<byte> Password { get; set; }

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x0600310C RID: 12556 RVA: 0x0001A447 File Offset: 0x00018647
		// (set) Token: 0x0600310D RID: 12557 RVA: 0x0001A44F File Offset: 0x0001864F
		public string RemoteEndpoint { get; set; }

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x0600310E RID: 12558 RVA: 0x0001A458 File Offset: 0x00018658
		// (set) Token: 0x0600310F RID: 12559 RVA: 0x0001A460 File Offset: 0x00018660
		public string Nickname { get; set; }

		// Token: 0x06003110 RID: 12560 RVA: 0x001034CC File Offset: 0x001016CC
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.Username);
			ArrayManager.WriteListByte(ref newArray, ref newSize, this.Password);
			ArrayManager.WriteString(ref newArray, ref newSize, this.RemoteEndpoint);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Nickname);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003111 RID: 12561 RVA: 0x00103578 File Offset: 0x00101778
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Username = ArrayManager.ReadString(data, ref num);
			this.Password = ArrayManager.ReadListByte(data, ref num);
			this.RemoteEndpoint = ArrayManager.ReadString(data, ref num);
			this.Nickname = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x06003112 RID: 12562 RVA: 0x0001A469 File Offset: 0x00018669
		private void InitRefTypes()
		{
			this.Username = string.Empty;
			this.Password = new List<byte>();
			this.RemoteEndpoint = string.Empty;
			this.Nickname = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001BCA RID: 7114
		public const uint cPacketType = 47558132u;
	}
}
