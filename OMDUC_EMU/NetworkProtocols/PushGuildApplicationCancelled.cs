using System;

namespace NetworkProtocols
{
	// Token: 0x02000761 RID: 1889
	public class PushGuildApplicationCancelled : BotNetMessage
	{
		// Token: 0x0600430C RID: 17164 RVA: 0x00026892 File Offset: 0x00024A92
		public PushGuildApplicationCancelled()
		{
			this.InitRefTypes();
			base.PacketType = 3736326188u;
		}

		// Token: 0x0600430D RID: 17165 RVA: 0x000268AB File Offset: 0x00024AAB
		public PushGuildApplicationCancelled(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3736326188u;
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x0600430E RID: 17166 RVA: 0x000268CB File Offset: 0x00024ACB
		// (set) Token: 0x0600430F RID: 17167 RVA: 0x000268D3 File Offset: 0x00024AD3
		public ulong ApplicationID { get; set; }

		// Token: 0x06004310 RID: 17168 RVA: 0x00121690 File Offset: 0x0011F890
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.ApplicationID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06004311 RID: 17169 RVA: 0x00121710 File Offset: 0x0011F910
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.ApplicationID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06004312 RID: 17170 RVA: 0x000268DC File Offset: 0x00024ADC
		private void InitRefTypes()
		{
			this.ApplicationID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040022F1 RID: 8945
		public const uint cPacketType = 3736326188u;
	}
}
