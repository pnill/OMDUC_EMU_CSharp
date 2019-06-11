using System;

namespace NetworkProtocols
{
	// Token: 0x02000731 RID: 1841
	public class RequestPromoteGuildMember : BotNetMessage
	{
		// Token: 0x0600413C RID: 16700 RVA: 0x0002546B File Offset: 0x0002366B
		public RequestPromoteGuildMember()
		{
			this.InitRefTypes();
			base.PacketType = 2496668806u;
		}

		// Token: 0x0600413D RID: 16701 RVA: 0x00025484 File Offset: 0x00023684
		public RequestPromoteGuildMember(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2496668806u;
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x0600413E RID: 16702 RVA: 0x000254A4 File Offset: 0x000236A4
		// (set) Token: 0x0600413F RID: 16703 RVA: 0x000254AC File Offset: 0x000236AC
		public ulong TargetAccountSUID { get; set; }

		// Token: 0x06004140 RID: 16704 RVA: 0x0011E8C0 File Offset: 0x0011CAC0
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.TargetAccountSUID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06004141 RID: 16705 RVA: 0x0011E940 File Offset: 0x0011CB40
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.TargetAccountSUID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06004142 RID: 16706 RVA: 0x000254B5 File Offset: 0x000236B5
		private void InitRefTypes()
		{
			this.TargetAccountSUID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002255 RID: 8789
		public const uint cPacketType = 2496668806u;
	}
}
