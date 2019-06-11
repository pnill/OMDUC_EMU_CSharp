using System;

namespace NetworkProtocols
{
	// Token: 0x0200070F RID: 1807
	public class PlayerPresenceChanged : BotNetMessage
	{
		// Token: 0x06004010 RID: 16400 RVA: 0x000245D5 File Offset: 0x000227D5
		public PlayerPresenceChanged()
		{
			this.InitRefTypes();
			base.PacketType = 2000782293u;
		}

		// Token: 0x06004011 RID: 16401 RVA: 0x000245EE File Offset: 0x000227EE
		public PlayerPresenceChanged(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2000782293u;
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06004012 RID: 16402 RVA: 0x0002460E File Offset: 0x0002280E
		// (set) Token: 0x06004013 RID: 16403 RVA: 0x00024616 File Offset: 0x00022816
		public eDashboardPresence Presence { get; set; }

		// Token: 0x06004014 RID: 16404 RVA: 0x0011C8C4 File Offset: 0x0011AAC4
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
			ArrayManager.WriteeDashboardPresence(ref newArray, ref newSize, this.Presence);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06004015 RID: 16405 RVA: 0x0011C944 File Offset: 0x0011AB44
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Presence = ArrayManager.ReadeDashboardPresence(data, ref num);
		}

		// Token: 0x06004016 RID: 16406 RVA: 0x0002461F File Offset: 0x0002281F
		private void InitRefTypes()
		{
			this.Presence = eDashboardPresence.None;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040021F3 RID: 8691
		public const uint cPacketType = 2000782293u;
	}
}
