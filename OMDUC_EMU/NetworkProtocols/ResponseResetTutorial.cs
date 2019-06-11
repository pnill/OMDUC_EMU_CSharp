using System;

namespace NetworkProtocols
{
	// Token: 0x020004F2 RID: 1266
	public class ResponseResetTutorial : BotNetMessage
	{
		// Token: 0x06002BE2 RID: 11234 RVA: 0x00017437 File Offset: 0x00015637
		public ResponseResetTutorial()
		{
			this.InitRefTypes();
			base.PacketType = 3239703731u;
		}

		// Token: 0x06002BE3 RID: 11235 RVA: 0x00017450 File Offset: 0x00015650
		public ResponseResetTutorial(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3239703731u;
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06002BE4 RID: 11236 RVA: 0x00017470 File Offset: 0x00015670
		// (set) Token: 0x06002BE5 RID: 11237 RVA: 0x00017478 File Offset: 0x00015678
		public bool WasCommitted { get; set; }

		// Token: 0x06002BE6 RID: 11238 RVA: 0x000FD30C File Offset: 0x000FB50C
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

		// Token: 0x06002BE7 RID: 11239 RVA: 0x000FD38C File Offset: 0x000FB58C
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

		// Token: 0x06002BE8 RID: 11240 RVA: 0x00017481 File Offset: 0x00015681
		private void InitRefTypes()
		{
			this.WasCommitted = false;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001A5F RID: 6751
		public const uint cPacketType = 3239703731u;
	}
}
