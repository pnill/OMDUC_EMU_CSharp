using System;

namespace NetworkProtocols
{
	// Token: 0x02000717 RID: 1815
	public class RequestDeleteFriend : BotNetMessage
	{
		// Token: 0x06004066 RID: 16486 RVA: 0x0002498E File Offset: 0x00022B8E
		public RequestDeleteFriend()
		{
			this.InitRefTypes();
			base.PacketType = 4123902956u;
		}

		// Token: 0x06004067 RID: 16487 RVA: 0x000249A7 File Offset: 0x00022BA7
		public RequestDeleteFriend(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 4123902956u;
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06004068 RID: 16488 RVA: 0x000249C7 File Offset: 0x00022BC7
		// (set) Token: 0x06004069 RID: 16489 RVA: 0x000249CF File Offset: 0x00022BCF
		public ulong AccountSUID { get; set; }

		// Token: 0x0600406A RID: 16490 RVA: 0x0011D108 File Offset: 0x0011B308
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.AccountSUID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600406B RID: 16491 RVA: 0x0011D188 File Offset: 0x0011B388
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x0600406C RID: 16492 RVA: 0x000249D8 File Offset: 0x00022BD8
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002211 RID: 8721
		public const uint cPacketType = 4123902956u;
	}
}
