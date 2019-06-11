using System;

namespace NetworkProtocols
{
	// Token: 0x020004AF RID: 1199
	public class ForceReconnectPush : BotNetMessage
	{
		// Token: 0x06002AFA RID: 11002 RVA: 0x0001695F File Offset: 0x00014B5F
		public ForceReconnectPush()
		{
			this.InitRefTypes();
			base.PacketType = 2176573297u;
		}

		// Token: 0x06002AFB RID: 11003 RVA: 0x00016978 File Offset: 0x00014B78
		public ForceReconnectPush(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2176573297u;
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06002AFC RID: 11004 RVA: 0x00016998 File Offset: 0x00014B98
		// (set) Token: 0x06002AFD RID: 11005 RVA: 0x000169A0 File Offset: 0x00014BA0
		public eGameType GameType { get; set; }

		// Token: 0x06002AFE RID: 11006 RVA: 0x000FBFA8 File Offset: 0x000FA1A8
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
			ArrayManager.WriteeGameType(ref newArray, ref newSize, this.GameType);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002AFF RID: 11007 RVA: 0x000FC028 File Offset: 0x000FA228
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.GameType = ArrayManager.ReadeGameType(data, ref num);
		}

		// Token: 0x06002B00 RID: 11008 RVA: 0x000169A9 File Offset: 0x00014BA9
		private void InitRefTypes()
		{
			this.GameType = eGameType.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040017A6 RID: 6054
		public const uint cPacketType = 2176573297u;
	}
}
