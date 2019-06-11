using System;

namespace NetworkProtocols
{
	// Token: 0x02000614 RID: 1556
	public class RequestValidateNickname : BotNetMessage
	{
		// Token: 0x06003648 RID: 13896 RVA: 0x0001D9A6 File Offset: 0x0001BBA6
		public RequestValidateNickname()
		{
			this.InitRefTypes();
			base.PacketType = 2166007453u;
		}

		// Token: 0x06003649 RID: 13897 RVA: 0x0001D9BF File Offset: 0x0001BBBF
		public RequestValidateNickname(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2166007453u;
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x0600364A RID: 13898 RVA: 0x0001D9DF File Offset: 0x0001BBDF
		// (set) Token: 0x0600364B RID: 13899 RVA: 0x0001D9E7 File Offset: 0x0001BBE7
		public string Nickname { get; set; }

		// Token: 0x0600364C RID: 13900 RVA: 0x0010AB18 File Offset: 0x00108D18
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.Nickname);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600364D RID: 13901 RVA: 0x0010AB98 File Offset: 0x00108D98
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Nickname = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x0600364E RID: 13902 RVA: 0x0001D9F0 File Offset: 0x0001BBF0
		private void InitRefTypes()
		{
			this.Nickname = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001D7A RID: 7546
		public const uint cPacketType = 2166007453u;
	}
}
