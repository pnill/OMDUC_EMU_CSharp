using System;

namespace NetworkProtocols
{
	// Token: 0x020004F0 RID: 1264
	public class ResponseAddTutorialProgress : BotNetMessage
	{
		// Token: 0x06002BD6 RID: 11222 RVA: 0x000173A4 File Offset: 0x000155A4
		public ResponseAddTutorialProgress()
		{
			this.InitRefTypes();
			base.PacketType = 2413974151u;
		}

		// Token: 0x06002BD7 RID: 11223 RVA: 0x000173BD File Offset: 0x000155BD
		public ResponseAddTutorialProgress(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2413974151u;
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06002BD8 RID: 11224 RVA: 0x000173DD File Offset: 0x000155DD
		// (set) Token: 0x06002BD9 RID: 11225 RVA: 0x000173E5 File Offset: 0x000155E5
		public bool WasCommitted { get; set; }

		// Token: 0x06002BDA RID: 11226 RVA: 0x000FD224 File Offset: 0x000FB424
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
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.WasCommitted);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002BDB RID: 11227 RVA: 0x000FD2A4 File Offset: 0x000FB4A4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.WasCommitted = ArrayManager.ReadBoolean(data, ref num);
		}

		// Token: 0x06002BDC RID: 11228 RVA: 0x000173EE File Offset: 0x000155EE
		private void InitRefTypes()
		{
			this.WasCommitted = false;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001A5C RID: 6748
		public const uint cPacketType = 2413974151u;
	}
}
