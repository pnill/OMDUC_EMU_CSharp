using System;

namespace NetworkProtocols
{
	// Token: 0x0200048E RID: 1166
	public class RequestDiscordAuthentication : BotNetMessage
	{
		// Token: 0x06002A36 RID: 10806 RVA: 0x00016073 File Offset: 0x00014273
		public RequestDiscordAuthentication()
		{
			this.InitRefTypes();
			base.PacketType = 943052253u;
		}

		// Token: 0x06002A37 RID: 10807 RVA: 0x0001608C File Offset: 0x0001428C
		public RequestDiscordAuthentication(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 943052253u;
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06002A38 RID: 10808 RVA: 0x000160AC File Offset: 0x000142AC
		// (set) Token: 0x06002A39 RID: 10809 RVA: 0x000160B4 File Offset: 0x000142B4
		public eDiscordAuthenticationType Type { get; set; }

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06002A3A RID: 10810 RVA: 0x000160BD File Offset: 0x000142BD
		// (set) Token: 0x06002A3B RID: 10811 RVA: 0x000160C5 File Offset: 0x000142C5
		public string OAuthCode { get; set; }

		// Token: 0x06002A3C RID: 10812 RVA: 0x000FAEE8 File Offset: 0x000F90E8
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
			ArrayManager.WriteeDiscordAuthenticationType(ref newArray, ref newSize, this.Type);
			ArrayManager.WriteString(ref newArray, ref newSize, this.OAuthCode);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002A3D RID: 10813 RVA: 0x000FAF74 File Offset: 0x000F9174
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Type = ArrayManager.ReadeDiscordAuthenticationType(data, ref num);
			this.OAuthCode = ArrayManager.ReadString(data, ref num);
		}

		// Token: 0x06002A3E RID: 10814 RVA: 0x000160CE File Offset: 0x000142CE
		private void InitRefTypes()
		{
			this.Type = eDiscordAuthenticationType.Automatic;
			this.OAuthCode = string.Empty;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040016DA RID: 5850
		public const uint cPacketType = 943052253u;
	}
}
