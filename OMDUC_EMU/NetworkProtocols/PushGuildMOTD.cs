using System;

namespace NetworkProtocols
{
	// Token: 0x0200075E RID: 1886
	public class PushGuildMOTD : BotNetMessage
	{
		// Token: 0x060042F5 RID: 17141 RVA: 0x00026763 File Offset: 0x00024963
		public PushGuildMOTD()
		{
			this.InitRefTypes();
			base.PacketType = 4056958469u;
		}

		// Token: 0x060042F6 RID: 17142 RVA: 0x0002677C File Offset: 0x0002497C
		public PushGuildMOTD(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 4056958469u;
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x060042F7 RID: 17143 RVA: 0x0002679C File Offset: 0x0002499C
		// (set) Token: 0x060042F8 RID: 17144 RVA: 0x000267A4 File Offset: 0x000249A4
		public string MOTD { get; set; }

		// Token: 0x060042F9 RID: 17145 RVA: 0x001213BC File Offset: 0x0011F5BC
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.MOTD);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060042FA RID: 17146 RVA: 0x0012143C File Offset: 0x0011F63C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.MOTD = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x060042FB RID: 17147 RVA: 0x000267AD File Offset: 0x000249AD
		private void InitRefTypes()
		{
			this.MOTD = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040022EA RID: 8938
		public const uint cPacketType = 4056958469u;
	}
}
