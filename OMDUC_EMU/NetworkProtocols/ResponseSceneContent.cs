using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020005A0 RID: 1440
	public class ResponseSceneContent : BotNetMessage
	{
		// Token: 0x0600320A RID: 12810 RVA: 0x0001ADB1 File Offset: 0x00018FB1
		public ResponseSceneContent()
		{
			this.InitRefTypes();
			base.PacketType = 2330897222u;
		}

		// Token: 0x0600320B RID: 12811 RVA: 0x0001ADCA File Offset: 0x00018FCA
		public ResponseSceneContent(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2330897222u;
		}

		public ContentTemplate Template { get; set; }
		public List<ContentDefinition> ContentDefinitions { get; set; }

		// Token: 0x06003210 RID: 12816 RVA: 0x00104918 File Offset: 0x00102B18
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
			ArrayManager.WriteContentTemplate(ref newArray, ref newSize, this.Template);
			ArrayManager.WriteListContentDefinition(ref newArray, ref newSize, this.ContentDefinitions);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003211 RID: 12817 RVA: 0x001049A4 File Offset: 0x00102BA4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Template = ArrayManager.ReadContentTemplate(data, ref num);
			this.ContentDefinitions = ArrayManager.ReadListContentDefinition(data, ref num);
		}

		// Token: 0x06003212 RID: 12818 RVA: 0x0001AE0C File Offset: 0x0001900C
		private void InitRefTypes()
		{
			this.Template = new ContentTemplate();
			this.ContentDefinitions = new List<ContentDefinition>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001C2B RID: 7211
		public const uint cPacketType = 2330897222u;
	}
}
