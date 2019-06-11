using System;

namespace NetworkProtocols
{
	// Token: 0x02000786 RID: 1926
	public class ClearChatIDForGuild : BotNetMessage
	{
		// Token: 0x06004420 RID: 17440 RVA: 0x00027449 File Offset: 0x00025649
		public ClearChatIDForGuild()
		{
			this.InitRefTypes();
			base.PacketType = 2725020781u;
		}

		// Token: 0x06004421 RID: 17441 RVA: 0x00027462 File Offset: 0x00025662
		public ClearChatIDForGuild(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2725020781u;
		}

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x06004422 RID: 17442 RVA: 0x00027482 File Offset: 0x00025682
		// (set) Token: 0x06004423 RID: 17443 RVA: 0x0002748A File Offset: 0x0002568A
		public ulong ChatID { get; set; }

		// Token: 0x06004424 RID: 17444 RVA: 0x00122E6C File Offset: 0x0012106C
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.ChatID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06004425 RID: 17445 RVA: 0x00122EEC File Offset: 0x001210EC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.ChatID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06004426 RID: 17446 RVA: 0x00027493 File Offset: 0x00025693
		private void InitRefTypes()
		{
			this.ChatID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400233D RID: 9021
		public const uint cPacketType = 2725020781u;
	}
}
