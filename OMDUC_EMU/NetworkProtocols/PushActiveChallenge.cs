using System;

namespace NetworkProtocols
{
	// Token: 0x02000652 RID: 1618
	public class PushActiveChallenge : BotNetMessage
	{
		// Token: 0x06003870 RID: 14448 RVA: 0x0001F0FC File Offset: 0x0001D2FC
		public PushActiveChallenge()
		{
			this.InitRefTypes();
			base.PacketType = 168718057u;
		}

		// Token: 0x06003871 RID: 14449 RVA: 0x0001F115 File Offset: 0x0001D315
		public PushActiveChallenge(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 168718057u;
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06003872 RID: 14450 RVA: 0x0001F135 File Offset: 0x0001D335
		// (set) Token: 0x06003873 RID: 14451 RVA: 0x0001F13D File Offset: 0x0001D33D
		public PacketChallenge Challenge { get; set; }

		// Token: 0x06003874 RID: 14452 RVA: 0x0010DF20 File Offset: 0x0010C120
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
			ArrayManager.WritePacketChallenge(ref newArray, ref newSize, this.Challenge);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003875 RID: 14453 RVA: 0x0010DFA0 File Offset: 0x0010C1A0
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Challenge = ArrayManager.ReadPacketChallenge(data, ref num);
		}

		// Token: 0x06003876 RID: 14454 RVA: 0x0001F146 File Offset: 0x0001D346
		private void InitRefTypes()
		{
			this.Challenge = new PacketChallenge();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001E24 RID: 7716
		public const uint cPacketType = 168718057u;
	}
}
