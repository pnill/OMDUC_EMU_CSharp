using System;

namespace NetworkProtocols
{
	// Token: 0x02000663 RID: 1635
	public class RequestUpdateNameplate : BotNetMessage
	{
		// Token: 0x06003916 RID: 14614 RVA: 0x0001F850 File Offset: 0x0001DA50
		public RequestUpdateNameplate()
		{
			this.InitRefTypes();
			base.PacketType = 2221870570u;
		}

		// Token: 0x06003917 RID: 14615 RVA: 0x0001F869 File Offset: 0x0001DA69
		public RequestUpdateNameplate(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2221870570u;
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x06003918 RID: 14616 RVA: 0x0001F889 File Offset: 0x0001DA89
		// (set) Token: 0x06003919 RID: 14617 RVA: 0x0001F891 File Offset: 0x0001DA91
		public ulong SelectedAvatar { get; set; }

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x0600391A RID: 14618 RVA: 0x0001F89A File Offset: 0x0001DA9A
		// (set) Token: 0x0600391B RID: 14619 RVA: 0x0001F8A2 File Offset: 0x0001DAA2
		public ulong SelectedBackground { get; set; }

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x0600391C RID: 14620 RVA: 0x0001F8AB File Offset: 0x0001DAAB
		// (set) Token: 0x0600391D RID: 14621 RVA: 0x0001F8B3 File Offset: 0x0001DAB3
		public ulong SelectedBadge { get; set; }

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x0600391E RID: 14622 RVA: 0x0001F8BC File Offset: 0x0001DABC
		// (set) Token: 0x0600391F RID: 14623 RVA: 0x0001F8C4 File Offset: 0x0001DAC4
		public ulong SelectedTitle { get; set; }

		// Token: 0x06003920 RID: 14624 RVA: 0x0010EEB8 File Offset: 0x0010D0B8
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.SelectedAvatar);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.SelectedBackground);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.SelectedBadge);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.SelectedTitle);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003921 RID: 14625 RVA: 0x0010EF64 File Offset: 0x0010D164
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.SelectedAvatar = ArrayManager.ReadUInt64(data, ref num);
			this.SelectedBackground = ArrayManager.ReadUInt64(data, ref num);
			this.SelectedBadge = ArrayManager.ReadUInt64(data, ref num);
			this.SelectedTitle = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06003922 RID: 14626 RVA: 0x0001F8CD File Offset: 0x0001DACD
		private void InitRefTypes()
		{
			this.SelectedAvatar = 0UL;
			this.SelectedBackground = 0UL;
			this.SelectedBadge = 0UL;
			this.SelectedTitle = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001E5C RID: 7772
		public const uint cPacketType = 2221870570u;
	}
}
