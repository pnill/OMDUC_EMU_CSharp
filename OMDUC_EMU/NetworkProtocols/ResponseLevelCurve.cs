using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020005AD RID: 1453
	public class ResponseLevelCurve : BotNetMessage
	{
		// Token: 0x0600328C RID: 12940 RVA: 0x0001B349 File Offset: 0x00019549
		public ResponseLevelCurve()
		{
			this.InitRefTypes();
			base.PacketType = 3554474019u;
		}

		// Token: 0x0600328D RID: 12941 RVA: 0x0001B362 File Offset: 0x00019562
		public ResponseLevelCurve(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3554474019u;
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x0600328E RID: 12942 RVA: 0x0001B382 File Offset: 0x00019582
		// (set) Token: 0x0600328F RID: 12943 RVA: 0x0001B38A File Offset: 0x0001958A
		public List<PacketLevelCurveEntry> LevelCurve { get; set; }

		// Token: 0x06003290 RID: 12944 RVA: 0x001054BC File Offset: 0x001036BC
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
			ArrayManager.WriteListPacketLevelCurveEntry(ref newArray, ref newSize, this.LevelCurve);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003291 RID: 12945 RVA: 0x0010553C File Offset: 0x0010373C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.LevelCurve = ArrayManager.ReadListPacketLevelCurveEntry(data, ref num);
		}

		// Token: 0x06003292 RID: 12946 RVA: 0x0001B393 File Offset: 0x00019593
		private void InitRefTypes()
		{
			this.LevelCurve = new List<PacketLevelCurveEntry>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001C56 RID: 7254
		public const uint cPacketType = 3554474019u;
	}
}
