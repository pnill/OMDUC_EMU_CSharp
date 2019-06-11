using System;

namespace NetworkProtocols
{
	// Token: 0x020006DE RID: 1758
	public class StartMatchmakingParty : BotNetMessage
	{
		// Token: 0x06003ED0 RID: 16080 RVA: 0x000236AB File Offset: 0x000218AB
		public StartMatchmakingParty()
		{
			this.InitRefTypes();
			base.PacketType = 636653740u;
		}

		// Token: 0x06003ED1 RID: 16081 RVA: 0x000236C4 File Offset: 0x000218C4
		public StartMatchmakingParty(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 636653740u;
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x06003ED2 RID: 16082 RVA: 0x000236E4 File Offset: 0x000218E4
		// (set) Token: 0x06003ED3 RID: 16083 RVA: 0x000236EC File Offset: 0x000218EC
		public ulong PartyID { get; set; }

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x06003ED4 RID: 16084 RVA: 0x000236F5 File Offset: 0x000218F5
		// (set) Token: 0x06003ED5 RID: 16085 RVA: 0x000236FD File Offset: 0x000218FD
		public eMatchmakingType MatchmakingType { get; set; }

		// Token: 0x06003ED6 RID: 16086 RVA: 0x001175B8 File Offset: 0x001157B8
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.PartyID);
			ArrayManager.WriteeMatchmakingType(ref newArray, ref newSize, this.MatchmakingType);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003ED7 RID: 16087 RVA: 0x00117644 File Offset: 0x00115844
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.PartyID = ArrayManager.ReadUInt64(data, ref num);
			this.MatchmakingType = ArrayManager.ReadeMatchmakingType(data, ref num);
		}

		// Token: 0x06003ED8 RID: 16088 RVA: 0x00023706 File Offset: 0x00021906
		private void InitRefTypes()
		{
			this.PartyID = 0UL;
			this.MatchmakingType = eMatchmakingType.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002103 RID: 8451
		public const uint cPacketType = 636653740u;
	}
}
