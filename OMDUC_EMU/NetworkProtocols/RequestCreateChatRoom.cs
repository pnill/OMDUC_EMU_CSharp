using System;

namespace NetworkProtocols
{
	// Token: 0x02000482 RID: 1154
	public class RequestCreateChatRoom : BotNetMessage
	{
		// Token: 0x060029BC RID: 10684 RVA: 0x00015A8B File Offset: 0x00013C8B
		public RequestCreateChatRoom()
		{
			this.InitRefTypes();
			base.PacketType = 1843771463u;
		}

		// Token: 0x060029BD RID: 10685 RVA: 0x00015AA4 File Offset: 0x00013CA4
		public RequestCreateChatRoom(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1843771463u;
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x060029BE RID: 10686 RVA: 0x00015AC4 File Offset: 0x00013CC4
		// (set) Token: 0x060029BF RID: 10687 RVA: 0x00015ACC File Offset: 0x00013CCC
		public bool IsPrivate { get; set; }

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x060029C0 RID: 10688 RVA: 0x00015AD5 File Offset: 0x00013CD5
		// (set) Token: 0x060029C1 RID: 10689 RVA: 0x00015ADD File Offset: 0x00013CDD
		public string Password { get; set; }

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x060029C2 RID: 10690 RVA: 0x00015AE6 File Offset: 0x00013CE6
		// (set) Token: 0x060029C3 RID: 10691 RVA: 0x00015AEE File Offset: 0x00013CEE
		public string RoomName { get; set; }

		// Token: 0x060029C4 RID: 10692 RVA: 0x000FA190 File Offset: 0x000F8390
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
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsPrivate);
			ArrayManager.WriteString(ref newArray, ref newSize, this.Password);
			ArrayManager.WriteString(ref newArray, ref newSize, this.RoomName);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060029C5 RID: 10693 RVA: 0x000FA22C File Offset: 0x000F842C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.IsPrivate = ArrayManager.ReadBoolean(data, ref num);
			this.Password = ArrayManager.ReadString(data, ref num);
			this.RoomName = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x060029C6 RID: 10694 RVA: 0x00015AF7 File Offset: 0x00013CF7
		private void InitRefTypes()
		{
			this.IsPrivate = false;
			this.Password = string.Empty;
			this.RoomName = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040016AF RID: 5807
		public const uint cPacketType = 1843771463u;
	}
}
