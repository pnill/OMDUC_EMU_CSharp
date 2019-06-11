using System;

namespace NetworkProtocols
{
	// Token: 0x02000738 RID: 1848
	public class RequestGetApplicationsForGuild : BotNetMessage
	{
		// Token: 0x06004180 RID: 16768 RVA: 0x0002576C File Offset: 0x0002396C
		public RequestGetApplicationsForGuild()
		{
			this.InitRefTypes();
			base.PacketType = 3921608283u;
		}

		// Token: 0x06004181 RID: 16769 RVA: 0x00025785 File Offset: 0x00023985
		public RequestGetApplicationsForGuild(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3921608283u;
		}

		// Token: 0x06004182 RID: 16770 RVA: 0x000FBBEC File Offset: 0x000F9DEC
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

		// Token: 0x06004183 RID: 16771 RVA: 0x000FBC5C File Offset: 0x000F9E5C
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

		// Token: 0x06004184 RID: 16772 RVA: 0x000167D3 File Offset: 0x000149D3
		private void InitRefTypes()
		{
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400226C RID: 8812
		public const uint cPacketType = 3921608283u;
	}
}
