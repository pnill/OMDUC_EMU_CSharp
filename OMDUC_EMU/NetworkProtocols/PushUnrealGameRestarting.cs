using System;

namespace NetworkProtocols
{
	// Token: 0x020006CC RID: 1740
	public class PushUnrealGameRestarting : BotNetMessage
	{
		// Token: 0x06003E60 RID: 15968 RVA: 0x0002311B File Offset: 0x0002131B
		public PushUnrealGameRestarting()
		{
			this.InitRefTypes();
			base.PacketType = 320512202u;
		}

		// Token: 0x06003E61 RID: 15969 RVA: 0x00023134 File Offset: 0x00021334
		public PushUnrealGameRestarting(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 320512202u;
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06003E62 RID: 15970 RVA: 0x00023154 File Offset: 0x00021354
		// (set) Token: 0x06003E63 RID: 15971 RVA: 0x0002315C File Offset: 0x0002135C
		public string GameStateID { get; set; }

		// Token: 0x06003E64 RID: 15972 RVA: 0x001168D0 File Offset: 0x00114AD0
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.GameStateID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003E65 RID: 15973 RVA: 0x00116950 File Offset: 0x00114B50
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.GameStateID = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x06003E66 RID: 15974 RVA: 0x00023165 File Offset: 0x00021365
		private void InitRefTypes()
		{
			this.GameStateID = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040020B9 RID: 8377
		public const uint cPacketType = 320512202u;
	}
}
