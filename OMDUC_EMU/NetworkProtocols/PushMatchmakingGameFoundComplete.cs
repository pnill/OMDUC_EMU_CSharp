using System;

namespace NetworkProtocols
{
	// Token: 0x020006DC RID: 1756
	public class PushMatchmakingGameFoundComplete : BotNetMessage
	{
		// Token: 0x06003EC2 RID: 16066 RVA: 0x000235F6 File Offset: 0x000217F6
		public PushMatchmakingGameFoundComplete()
		{
			this.InitRefTypes();
			base.PacketType = 3623514798u;
		}

		// Token: 0x06003EC3 RID: 16067 RVA: 0x0002360F File Offset: 0x0002180F
		public PushMatchmakingGameFoundComplete(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3623514798u;
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x06003EC4 RID: 16068 RVA: 0x0002362F File Offset: 0x0002182F
		// (set) Token: 0x06003EC5 RID: 16069 RVA: 0x00023637 File Offset: 0x00021837
		public ulong MatchmakingGameID { get; set; }

		// Token: 0x06003EC6 RID: 16070 RVA: 0x001173E8 File Offset: 0x001155E8
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.MatchmakingGameID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003EC7 RID: 16071 RVA: 0x00117468 File Offset: 0x00115668
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.MatchmakingGameID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06003EC8 RID: 16072 RVA: 0x00023640 File Offset: 0x00021840
		private void InitRefTypes()
		{
			this.MatchmakingGameID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040020FF RID: 8447
		public const uint cPacketType = 3623514798u;
	}
}
