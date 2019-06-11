using System;

namespace NetworkProtocols
{
	// Token: 0x020004DD RID: 1245
	public class PingCharacter : BotNetMessage
	{
		// Token: 0x06002B2C RID: 11052 RVA: 0x00016BDF File Offset: 0x00014DDF
		public PingCharacter()
		{
			this.InitRefTypes();
			base.PacketType = 1964942180u;
		}

		// Token: 0x06002B2D RID: 11053 RVA: 0x00016BF8 File Offset: 0x00014DF8
		public PingCharacter(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1964942180u;
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06002B2E RID: 11054 RVA: 0x00016C18 File Offset: 0x00014E18
		// (set) Token: 0x06002B2F RID: 11055 RVA: 0x00016C20 File Offset: 0x00014E20
		public string Data { get; set; }

		// Token: 0x06002B30 RID: 11056 RVA: 0x000FC4C0 File Offset: 0x000FA6C0
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.Data);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002B31 RID: 11057 RVA: 0x000FC540 File Offset: 0x000FA740
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Data = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x06002B32 RID: 11058 RVA: 0x00016C29 File Offset: 0x00014E29
		private void InitRefTypes()
		{
			this.Data = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001A26 RID: 6694
		public const uint cPacketType = 1964942180u;
	}
}
