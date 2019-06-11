using System;

namespace NetworkProtocols
{
	// Token: 0x020006B3 RID: 1715
	public class DataStartGame : BotNetMessage
	{
		// Token: 0x06003CAB RID: 15531 RVA: 0x00021F90 File Offset: 0x00020190
		public DataStartGame()
		{
			this.InitRefTypes();
			base.PacketType = 394845444u;
		}

		// Token: 0x06003CAC RID: 15532 RVA: 0x00021FA9 File Offset: 0x000201A9
		public DataStartGame(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 394845444u;
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06003CAD RID: 15533 RVA: 0x00021FC9 File Offset: 0x000201C9
		// (set) Token: 0x06003CAE RID: 15534 RVA: 0x00021FD1 File Offset: 0x000201D1
		public ulong TargetIP { get; set; }

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06003CAF RID: 15535 RVA: 0x00021FDA File Offset: 0x000201DA
		// (set) Token: 0x06003CB0 RID: 15536 RVA: 0x00021FE2 File Offset: 0x000201E2
		public uint Port { get; set; }

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06003CB1 RID: 15537 RVA: 0x00021FEB File Offset: 0x000201EB
		// (set) Token: 0x06003CB2 RID: 15538 RVA: 0x00021FF3 File Offset: 0x000201F3
		public int PlayerJoinKey { get; set; }

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06003CB3 RID: 15539 RVA: 0x00021FFC File Offset: 0x000201FC
		// (set) Token: 0x06003CB4 RID: 15540 RVA: 0x00022004 File Offset: 0x00020204
		public Guid GameStateID { get; set; }

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06003CB5 RID: 15541 RVA: 0x0002200D File Offset: 0x0002020D
		// (set) Token: 0x06003CB6 RID: 15542 RVA: 0x00022015 File Offset: 0x00020215
		public string AdditionaGameLaunchParams { get; set; }

		// Token: 0x06003CB7 RID: 15543 RVA: 0x0011445C File Offset: 0x0011265C
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.TargetIP);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.Port);
			ArrayManager.WriteInt32(ref newArray, ref newSize, this.PlayerJoinKey);
			ArrayManager.WriteGuid(ref newArray, ref newSize, this.GameStateID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.AdditionaGameLaunchParams);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003CB8 RID: 15544 RVA: 0x00114518 File Offset: 0x00112718
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.TargetIP = ArrayManager.ReadUInt64(data, ref num);
			this.Port = ArrayManager.ReadUInt32(data, ref num);
			this.PlayerJoinKey = ArrayManager.ReadInt32(data, ref num);
			this.GameStateID = ArrayManager.ReadGuid(data, ref num);
			this.AdditionaGameLaunchParams = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x06003CB9 RID: 15545 RVA: 0x001145B8 File Offset: 0x001127B8
		private void InitRefTypes()
		{
			this.TargetIP = 0UL;
			this.Port = 0u;
			this.PlayerJoinKey = 0;
			this.GameStateID = default(Guid);
			this.AdditionaGameLaunchParams = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002005 RID: 8197
		public const uint cPacketType = 394845444u;
	}
}
