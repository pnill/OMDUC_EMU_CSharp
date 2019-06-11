using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020006AF RID: 1711
	public class GameMapList : BotNetMessage
	{
		// Token: 0x06003C51 RID: 15441 RVA: 0x00021C59 File Offset: 0x0001FE59
		public GameMapList()
		{
			this.InitRefTypes();
			base.PacketType = 1173273169u;
		}

		// Token: 0x06003C52 RID: 15442 RVA: 0x00021C72 File Offset: 0x0001FE72
		public GameMapList(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1173273169u;
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x06003C53 RID: 15443 RVA: 0x00021C92 File Offset: 0x0001FE92
		// (set) Token: 0x06003C54 RID: 15444 RVA: 0x00021C9A File Offset: 0x0001FE9A
		public List<GameMap> GameMaps { get; set; }

		// Token: 0x06003C55 RID: 15445 RVA: 0x00113D4C File Offset: 0x00111F4C
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
			ArrayManager.WriteListGameMap(ref newArray, ref newSize, this.GameMaps);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003C56 RID: 15446 RVA: 0x00113DCC File Offset: 0x00111FCC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.GameMaps = ArrayManager.ReadListGameMap(data, ref num);
		}

		// Token: 0x06003C57 RID: 15447 RVA: 0x00021CA3 File Offset: 0x0001FEA3
		private void InitRefTypes()
		{
			this.GameMaps = new List<GameMap>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001FDF RID: 8159
		public const uint cPacketType = 1173273169u;
	}
}
