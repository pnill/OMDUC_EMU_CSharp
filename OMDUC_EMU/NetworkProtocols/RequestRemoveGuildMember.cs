using System;

namespace NetworkProtocols
{
	// Token: 0x02000747 RID: 1863
	public class RequestRemoveGuildMember : BotNetMessage
	{
		// Token: 0x060041FC RID: 16892 RVA: 0x00025D45 File Offset: 0x00023F45
		public RequestRemoveGuildMember()
		{
			this.InitRefTypes();
			base.PacketType = 3375728112u;
		}

		// Token: 0x060041FD RID: 16893 RVA: 0x00025D5E File Offset: 0x00023F5E
		public RequestRemoveGuildMember(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3375728112u;
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x060041FE RID: 16894 RVA: 0x00025D7E File Offset: 0x00023F7E
		// (set) Token: 0x060041FF RID: 16895 RVA: 0x00025D86 File Offset: 0x00023F86
		public ulong TargetAccountSUID { get; set; }

		// Token: 0x06004200 RID: 16896 RVA: 0x0011FCE4 File Offset: 0x0011DEE4
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

		// Token: 0x06004201 RID: 16897 RVA: 0x0011FD64 File Offset: 0x0011DF64
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

		// Token: 0x06004202 RID: 16898 RVA: 0x00025D8F File Offset: 0x00023F8F
		private void InitRefTypes()
		{
			this.TargetAccountSUID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002293 RID: 8851
		public const uint cPacketType = 3375728112u;
	}
}
