using System;

namespace NetworkProtocols
{
	// Token: 0x0200075B RID: 1883
	public class RequestSetGuildDescription : BotNetMessage
	{
		// Token: 0x060042E0 RID: 17120 RVA: 0x00026650 File Offset: 0x00024850
		public RequestSetGuildDescription()
		{
			this.InitRefTypes();
			base.PacketType = 4079833005u;
		}

		// Token: 0x060042E1 RID: 17121 RVA: 0x00026669 File Offset: 0x00024869
		public RequestSetGuildDescription(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 4079833005u;
		}

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x060042E2 RID: 17122 RVA: 0x00026689 File Offset: 0x00024889
		// (set) Token: 0x060042E3 RID: 17123 RVA: 0x00026691 File Offset: 0x00024891
		public string Description { get; set; }

		// Token: 0x060042E4 RID: 17124 RVA: 0x00121104 File Offset: 0x0011F304
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.Description);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060042E5 RID: 17125 RVA: 0x00121184 File Offset: 0x0011F384
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Description = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x060042E6 RID: 17126 RVA: 0x0002669A File Offset: 0x0002489A
		private void InitRefTypes()
		{
			this.Description = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040022E4 RID: 8932
		public const uint cPacketType = 4079833005u;
	}
}
