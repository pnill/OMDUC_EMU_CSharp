using System;

namespace NetworkProtocols
{
	// Token: 0x020006FA RID: 1786
	public class PushPlayerKickedFromParty : BotNetMessage
	{
		// Token: 0x06003FCC RID: 16332 RVA: 0x00024275 File Offset: 0x00022475
		public PushPlayerKickedFromParty()
		{
			this.InitRefTypes();
			base.PacketType = 4274991488u;
		}

		// Token: 0x06003FCD RID: 16333 RVA: 0x0002428E File Offset: 0x0002248E
		public PushPlayerKickedFromParty(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 4274991488u;
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x06003FCE RID: 16334 RVA: 0x000242AE File Offset: 0x000224AE
		// (set) Token: 0x06003FCF RID: 16335 RVA: 0x000242B6 File Offset: 0x000224B6
		public ulong PartyID { get; set; }

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x06003FD0 RID: 16336 RVA: 0x000242BF File Offset: 0x000224BF
		// (set) Token: 0x06003FD1 RID: 16337 RVA: 0x000242C7 File Offset: 0x000224C7
		public ulong AccountSUID { get; set; }

		// Token: 0x06003FD2 RID: 16338 RVA: 0x0011C360 File Offset: 0x0011A560
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.AccountSUID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003FD3 RID: 16339 RVA: 0x0011C3EC File Offset: 0x0011A5EC
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
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06003FD4 RID: 16340 RVA: 0x000242D0 File Offset: 0x000224D0
		private void InitRefTypes()
		{
			this.PartyID = 0UL;
			this.AccountSUID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002176 RID: 8566
		public const uint cPacketType = 4274991488u;
	}
}
