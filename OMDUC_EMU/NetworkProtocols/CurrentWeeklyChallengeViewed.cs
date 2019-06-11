using System;

namespace NetworkProtocols
{
	// Token: 0x02000660 RID: 1632
	public class CurrentWeeklyChallengeViewed : BotNetMessage
	{
		// Token: 0x060038F0 RID: 14576 RVA: 0x0001F6F0 File Offset: 0x0001D8F0
		public CurrentWeeklyChallengeViewed()
		{
			this.InitRefTypes();
			base.PacketType = 2734367319u;
		}

		// Token: 0x060038F1 RID: 14577 RVA: 0x0001F709 File Offset: 0x0001D909
		public CurrentWeeklyChallengeViewed(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2734367319u;
		}

		// Token: 0x060038F2 RID: 14578 RVA: 0x000FBBEC File Offset: 0x000F9DEC
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
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060038F3 RID: 14579 RVA: 0x000FBC5C File Offset: 0x000F9E5C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
		}

		// Token: 0x060038F4 RID: 14580 RVA: 0x000167D3 File Offset: 0x000149D3
		private void InitRefTypes()
		{
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001E4E RID: 7758
		public const uint cPacketType = 2734367319u;
	}
}
