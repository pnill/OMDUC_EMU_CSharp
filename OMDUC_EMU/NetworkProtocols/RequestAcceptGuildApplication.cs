using System;

namespace NetworkProtocols
{
	// Token: 0x0200073D RID: 1853
	public class RequestAcceptGuildApplication : BotNetMessage
	{
		// Token: 0x060041AE RID: 16814 RVA: 0x0002594F File Offset: 0x00023B4F
		public RequestAcceptGuildApplication()
		{
			this.InitRefTypes();
			base.PacketType = 856260801u;
		}

		// Token: 0x060041AF RID: 16815 RVA: 0x00025968 File Offset: 0x00023B68
		public RequestAcceptGuildApplication(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 856260801u;
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x060041B0 RID: 16816 RVA: 0x00025988 File Offset: 0x00023B88
		// (set) Token: 0x060041B1 RID: 16817 RVA: 0x00025990 File Offset: 0x00023B90
		public ulong ApplicationID { get; set; }

		// Token: 0x060041B2 RID: 16818 RVA: 0x0011F364 File Offset: 0x0011D564
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.ApplicationID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060041B3 RID: 16819 RVA: 0x0011F3E4 File Offset: 0x0011D5E4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.ApplicationID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x060041B4 RID: 16820 RVA: 0x00025999 File Offset: 0x00023B99
		private void InitRefTypes()
		{
			this.ApplicationID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x0400227B RID: 8827
		public const uint cPacketType = 856260801u;
	}
}
