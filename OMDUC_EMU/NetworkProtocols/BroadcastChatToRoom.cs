using System;

namespace NetworkProtocols
{
	// Token: 0x02000486 RID: 1158
	public class BroadcastChatToRoom : BotNetMessage
	{
		// Token: 0x060029E2 RID: 10722 RVA: 0x00015C7A File Offset: 0x00013E7A
		public BroadcastChatToRoom()
		{
			this.InitRefTypes();
			base.PacketType = 305536938u;
		}

		// Token: 0x060029E3 RID: 10723 RVA: 0x00015C93 File Offset: 0x00013E93
		public BroadcastChatToRoom(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 305536938u;
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x060029E4 RID: 10724 RVA: 0x00015CB3 File Offset: 0x00013EB3
		// (set) Token: 0x060029E5 RID: 10725 RVA: 0x00015CBB File Offset: 0x00013EBB
		public ulong ChatID { get; set; }

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x060029E6 RID: 10726 RVA: 0x00015CC4 File Offset: 0x00013EC4
		// (set) Token: 0x060029E7 RID: 10727 RVA: 0x00015CCC File Offset: 0x00013ECC
		public string ChatString { get; set; }

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x060029E8 RID: 10728 RVA: 0x00015CD5 File Offset: 0x00013ED5
		// (set) Token: 0x060029E9 RID: 10729 RVA: 0x00015CDD File Offset: 0x00013EDD
		public string SenderName { get; set; }

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x060029EA RID: 10730 RVA: 0x00015CE6 File Offset: 0x00013EE6
		// (set) Token: 0x060029EB RID: 10731 RVA: 0x00015CEE File Offset: 0x00013EEE
		public string GuildTag { get; set; }

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x060029EC RID: 10732 RVA: 0x00015CF7 File Offset: 0x00013EF7
		// (set) Token: 0x060029ED RID: 10733 RVA: 0x00015CFF File Offset: 0x00013EFF
		public string GuildName { get; set; }

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x060029EE RID: 10734 RVA: 0x00015D08 File Offset: 0x00013F08
		// (set) Token: 0x060029EF RID: 10735 RVA: 0x00015D10 File Offset: 0x00013F10
		public uint Level { get; set; }

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x060029F0 RID: 10736 RVA: 0x00015D19 File Offset: 0x00013F19
		// (set) Token: 0x060029F1 RID: 10737 RVA: 0x00015D21 File Offset: 0x00013F21
		public bool IsRobotEmployee { get; set; }

		// Token: 0x060029F2 RID: 10738 RVA: 0x000FA5BC File Offset: 0x000F87BC
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.ChatID);
			ArrayManager.WriteString(ref newArray, ref newSize, this.ChatString);
			ArrayManager.WriteString(ref newArray, ref newSize, this.SenderName);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GuildTag);
			ArrayManager.WriteString(ref newArray, ref newSize, this.GuildName);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.Level);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsRobotEmployee);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060029F3 RID: 10739 RVA: 0x000FA694 File Offset: 0x000F8894
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.ChatID = ArrayManager.ReadUInt64(data, ref num);
			this.ChatString = ArrayManager.ReadString(data, ref num);
			this.SenderName = ArrayManager.ReadString(data, ref num);
			this.GuildTag = ArrayManager.ReadString(data, ref num);
			this.GuildName = ArrayManager.ReadString(data, ref num);
			this.Level = ArrayManager.ReadUInt32(data, ref num);
			this.IsRobotEmployee = ArrayManager.ReadBoolean(data, ref num);
		}

		// Token: 0x060029F4 RID: 10740 RVA: 0x000FA750 File Offset: 0x000F8950
		private void InitRefTypes()
		{
			this.ChatID = 0UL;
			this.ChatString = string.Empty;
			this.SenderName = string.Empty;
			this.GuildTag = string.Empty;
			this.GuildName = string.Empty;
			this.Level = 0u;
			this.IsRobotEmployee = false;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040016BC RID: 5820
		public const uint cPacketType = 305536938u;
	}
}
