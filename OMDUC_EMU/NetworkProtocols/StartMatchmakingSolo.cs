using System;

namespace NetworkProtocols
{
	// Token: 0x020006DD RID: 1757
	public class StartMatchmakingSolo : BotNetMessage
	{
		// Token: 0x06003EC9 RID: 16073 RVA: 0x00023651 File Offset: 0x00021851
		public StartMatchmakingSolo()
		{
			this.InitRefTypes();
			base.PacketType = 3559327802u;
		}

		// Token: 0x06003ECA RID: 16074 RVA: 0x0002366A File Offset: 0x0002186A
		public StartMatchmakingSolo(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3559327802u;
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x06003ECB RID: 16075 RVA: 0x0002368A File Offset: 0x0002188A
		// (set) Token: 0x06003ECC RID: 16076 RVA: 0x00023692 File Offset: 0x00021892
		public eMatchmakingType MatchmakingType { get; set; }

		// Token: 0x06003ECD RID: 16077 RVA: 0x001174D0 File Offset: 0x001156D0
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
			ArrayManager.WriteeMatchmakingType(ref newArray, ref newSize, this.MatchmakingType);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003ECE RID: 16078 RVA: 0x00117550 File Offset: 0x00115750
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.MatchmakingType = ArrayManager.ReadeMatchmakingType(data, ref num);
		}

		// Token: 0x06003ECF RID: 16079 RVA: 0x0002369B File Offset: 0x0002189B
		private void InitRefTypes()
		{
			this.MatchmakingType = eMatchmakingType.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002101 RID: 8449
		public const uint cPacketType = 3559327802u;
	}
}
