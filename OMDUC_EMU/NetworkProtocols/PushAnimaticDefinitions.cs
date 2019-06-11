using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000657 RID: 1623
	public class PushAnimaticDefinitions : BotNetMessage
	{
		// Token: 0x0600389C RID: 14492 RVA: 0x0001F314 File Offset: 0x0001D514
		public PushAnimaticDefinitions()
		{
			this.InitRefTypes();
			base.PacketType = 3510015090u;
		}

		// Token: 0x0600389D RID: 14493 RVA: 0x0001F32D File Offset: 0x0001D52D
		public PushAnimaticDefinitions(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3510015090u;
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x0600389E RID: 14494 RVA: 0x0001F34D File Offset: 0x0001D54D
		// (set) Token: 0x0600389F RID: 14495 RVA: 0x0001F355 File Offset: 0x0001D555
		public List<AnimaticDefinitionPacket> AnimaticDefitions { get; set; }

		// Token: 0x060038A0 RID: 14496 RVA: 0x0010E3A0 File Offset: 0x0010C5A0
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
			ArrayManager.WriteListAnimaticDefinitionPacket(ref newArray, ref newSize, this.AnimaticDefitions);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060038A1 RID: 14497 RVA: 0x0010E420 File Offset: 0x0010C620
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.AnimaticDefitions = ArrayManager.ReadListAnimaticDefinitionPacket(data, ref num);
		}

		// Token: 0x060038A2 RID: 14498 RVA: 0x0001F35E File Offset: 0x0001D55E
		private void InitRefTypes()
		{
			this.AnimaticDefitions = new List<AnimaticDefinitionPacket>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001E32 RID: 7730
		public const uint cPacketType = 3510015090u;
	}
}
