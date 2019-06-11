using System;

namespace NetworkProtocols
{
	// Token: 0x0200072C RID: 1836
	public class RequestCheckGuildName : BotNetMessage
	{
		// Token: 0x06004115 RID: 16661 RVA: 0x00025269 File Offset: 0x00023469
		public RequestCheckGuildName()
		{
			this.InitRefTypes();
			base.PacketType = 3563342773u;
		}

		// Token: 0x06004116 RID: 16662 RVA: 0x00025282 File Offset: 0x00023482
		public RequestCheckGuildName(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3563342773u;
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x06004117 RID: 16663 RVA: 0x000252A2 File Offset: 0x000234A2
		// (set) Token: 0x06004118 RID: 16664 RVA: 0x000252AA File Offset: 0x000234AA
		public string Name { get; set; }

		// Token: 0x06004119 RID: 16665 RVA: 0x0011E400 File Offset: 0x0011C600
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.Name);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600411A RID: 16666 RVA: 0x0011E480 File Offset: 0x0011C680
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Name = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x0600411B RID: 16667 RVA: 0x000252B3 File Offset: 0x000234B3
		private void InitRefTypes()
		{
			this.Name = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002249 RID: 8777
		public const uint cPacketType = 3563342773u;
	}
}
