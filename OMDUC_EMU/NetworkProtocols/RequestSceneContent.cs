using System;

namespace NetworkProtocols
{
	// Token: 0x0200059C RID: 1436
	public class RequestSceneContent : BotNetMessage
	{
		// Token: 0x060031C9 RID: 12745 RVA: 0x0001AB5D File Offset: 0x00018D5D
		public RequestSceneContent()
		{
			this.InitRefTypes();
			base.PacketType = 1035154563u;
		}

		// Token: 0x060031CA RID: 12746 RVA: 0x0001AB76 File Offset: 0x00018D76
		public RequestSceneContent(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1035154563u;
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x060031CB RID: 12747 RVA: 0x0001AB96 File Offset: 0x00018D96
		// (set) Token: 0x060031CC RID: 12748 RVA: 0x0001AB9E File Offset: 0x00018D9E
		public string Locale { get; set; }

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x060031CD RID: 12749 RVA: 0x0001ABA7 File Offset: 0x00018DA7
		// (set) Token: 0x060031CE RID: 12750 RVA: 0x0001ABAF File Offset: 0x00018DAF
		public eSceneID SceneID { get; set; }

		// Token: 0x060031CF RID: 12751 RVA: 0x00104470 File Offset: 0x00102670
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
			ArrayManager.WriteString(ref newArray, ref newSize, this.Locale);
			ArrayManager.WriteeSceneID(ref newArray, ref newSize, this.SceneID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060031D0 RID: 12752 RVA: 0x001044FC File Offset: 0x001026FC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Locale = ArrayManager.ReadString(data, ref num);
			this.SceneID = ArrayManager.ReadeSceneID(data, ref num);
		}

		// Token: 0x060031D1 RID: 12753 RVA: 0x0001ABB8 File Offset: 0x00018DB8
		private void InitRefTypes()
		{
			this.Locale = string.Empty;
			this.SceneID = eSceneID.LandingPage;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001C12 RID: 7186
		public const uint cPacketType = 1035154563u;
	}
}
