using System;

namespace NetworkProtocols
{
	// Token: 0x02000789 RID: 1929
	public class ResponseToggleGuildAcceptingApplications : BotNetMessage
	{
		// Token: 0x06004437 RID: 17463 RVA: 0x00027572 File Offset: 0x00025772
		public ResponseToggleGuildAcceptingApplications()
		{
			this.InitRefTypes();
			base.PacketType = 240668635u;
		}

		// Token: 0x06004438 RID: 17464 RVA: 0x0002758B File Offset: 0x0002578B
		public ResponseToggleGuildAcceptingApplications(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 240668635u;
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x06004439 RID: 17465 RVA: 0x000275AB File Offset: 0x000257AB
		// (set) Token: 0x0600443A RID: 17466 RVA: 0x000275B3 File Offset: 0x000257B3
		public bool IsAcceptingApplications { get; set; }

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x0600443B RID: 17467 RVA: 0x000275BC File Offset: 0x000257BC
		// (set) Token: 0x0600443C RID: 17468 RVA: 0x000275C4 File Offset: 0x000257C4
		public eGuildOperationStatus Status { get; set; }

		// Token: 0x0600443D RID: 17469 RVA: 0x00123140 File Offset: 0x00121340
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
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsAcceptingApplications);
			ArrayManager.WriteeGuildOperationStatus(ref newArray, ref newSize, this.Status);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600443E RID: 17470 RVA: 0x001231CC File Offset: 0x001213CC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.IsAcceptingApplications = ArrayManager.ReadBoolean(data, ref num);
			this.Status = ArrayManager.ReadeGuildOperationStatus(data, ref num);
		}

		// Token: 0x0600443F RID: 17471 RVA: 0x000275CD File Offset: 0x000257CD
		private void InitRefTypes()
		{
			this.IsAcceptingApplications = false;
			this.Status = eGuildOperationStatus.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002344 RID: 9028
		public const uint cPacketType = 240668635u;
	}
}
