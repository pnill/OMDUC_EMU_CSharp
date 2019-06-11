using System;

namespace NetworkProtocols
{
	// Token: 0x020006CD RID: 1741
	public class PushUnrealGameRestartData : BotNetMessage
	{
		// Token: 0x06003E67 RID: 15975 RVA: 0x00023179 File Offset: 0x00021379
		public PushUnrealGameRestartData()
		{
			this.InitRefTypes();
			base.PacketType = 2885615105u;
		}

		// Token: 0x06003E68 RID: 15976 RVA: 0x00023192 File Offset: 0x00021392
		public PushUnrealGameRestartData(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2885615105u;
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06003E69 RID: 15977 RVA: 0x000231B2 File Offset: 0x000213B2
		// (set) Token: 0x06003E6A RID: 15978 RVA: 0x000231BA File Offset: 0x000213BA
		public ulong TargetIP { get; set; }

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x06003E6B RID: 15979 RVA: 0x000231C3 File Offset: 0x000213C3
		// (set) Token: 0x06003E6C RID: 15980 RVA: 0x000231CB File Offset: 0x000213CB
		public uint Port { get; set; }

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06003E6D RID: 15981 RVA: 0x000231D4 File Offset: 0x000213D4
		// (set) Token: 0x06003E6E RID: 15982 RVA: 0x000231DC File Offset: 0x000213DC
		public int PlayerJoinKey { get; set; }

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06003E6F RID: 15983 RVA: 0x000231E5 File Offset: 0x000213E5
		// (set) Token: 0x06003E70 RID: 15984 RVA: 0x000231ED File Offset: 0x000213ED
		public string GameStateID { get; set; }

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06003E71 RID: 15985 RVA: 0x000231F6 File Offset: 0x000213F6
		// (set) Token: 0x06003E72 RID: 15986 RVA: 0x000231FE File Offset: 0x000213FE
		public string AdditionalGameLaunchParams { get; set; }

		// Token: 0x06003E73 RID: 15987 RVA: 0x001169B8 File Offset: 0x00114BB8
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.GameStateID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.AdditionalGameLaunchParams);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003E74 RID: 15988 RVA: 0x00116A74 File Offset: 0x00114C74
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
			this.GameStateID = ArrayManager.ReadString(data, ref num);
			this.AdditionalGameLaunchParams = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x06003E75 RID: 15989 RVA: 0x00023207 File Offset: 0x00021407
		private void InitRefTypes()
		{
			this.TargetIP = 0UL;
			this.Port = 0u;
			this.PlayerJoinKey = 0;
			this.GameStateID = string.Empty;
			this.AdditionalGameLaunchParams = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040020BB RID: 8379
		public const uint cPacketType = 2885615105u;
	}
}
