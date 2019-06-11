using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x0200059D RID: 1437
	public class ContentTemplate
	{
		// Token: 0x060031D2 RID: 12754 RVA: 0x0001ABD3 File Offset: 0x00018DD3
		public ContentTemplate()
		{
			this.InitRefTypes();
		}

		public eSceneID SceneID { get; set; }
		public ulong TemplateID { get; set; }
		public ulong TemplateDefinitionID { get; set; }
		public List<ContentBox> ContentBoxes { get; set; }


		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteeSceneID(ref newArray, ref newSize, this.SceneID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.TemplateID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.TemplateDefinitionID);
			ArrayManager.WriteListContentBox(ref newArray, ref newSize, this.ContentBoxes);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060031DC RID: 12764 RVA: 0x001045D0 File Offset: 0x001027D0
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.SceneID = ArrayManager.ReadeSceneID(data, ref num);
			this.TemplateID = ArrayManager.ReadUInt64(data, ref num);
			this.TemplateDefinitionID = ArrayManager.ReadUInt64(data, ref num);
			this.ContentBoxes = ArrayManager.ReadListContentBox(data, ref num);
		}

		// Token: 0x060031DD RID: 12765 RVA: 0x0001AC25 File Offset: 0x00018E25
		private void InitRefTypes()
		{
			this.SceneID = eSceneID.LandingPage;
			this.TemplateID = 0UL;
			this.TemplateDefinitionID = 0UL;
			this.ContentBoxes = new List<ContentBox>();
		}
	}
}
