using System;

namespace NetworkProtocols
{
	// Token: 0x02000624 RID: 1572
	public class PushMessageDeleted : BotNetMessage
	{
		// Token: 0x060036C7 RID: 14023 RVA: 0x0001DFE8 File Offset: 0x0001C1E8
		public PushMessageDeleted()
		{
			this.InitRefTypes();
			base.PacketType = 4001055609u;
		}

		// Token: 0x060036C8 RID: 14024 RVA: 0x0001E001 File Offset: 0x0001C201
		public PushMessageDeleted(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 4001055609u;
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x060036C9 RID: 14025 RVA: 0x0001E021 File Offset: 0x0001C221
		// (set) Token: 0x060036CA RID: 14026 RVA: 0x0001E029 File Offset: 0x0001C229
		public ulong PlayerMessageID { get; set; }

		// Token: 0x060036CB RID: 14027 RVA: 0x0010B848 File Offset: 0x00109A48
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.PlayerMessageID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060036CC RID: 14028 RVA: 0x0010B8C8 File Offset: 0x00109AC8
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.PlayerMessageID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x060036CD RID: 14029 RVA: 0x0001E032 File Offset: 0x0001C232
		private void InitRefTypes()
		{
			this.PlayerMessageID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001DA1 RID: 7585
		public const uint cPacketType = 4001055609u;
	}
}
