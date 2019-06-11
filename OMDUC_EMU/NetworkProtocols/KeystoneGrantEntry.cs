using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020004F5 RID: 1269
	public class KeystoneGrantEntry : BaseAwardEntry
	{
		// Token: 0x06002C18 RID: 11288 RVA: 0x0001762B File Offset: 0x0001582B
		public KeystoneGrantEntry()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1360832035u;
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06002C19 RID: 11289 RVA: 0x00017644 File Offset: 0x00015844
		// (set) Token: 0x06002C1A RID: 11290 RVA: 0x0001764C File Offset: 0x0001584C
		public ulong KeystoneDetailID { get; set; }

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06002C1B RID: 11291 RVA: 0x00017655 File Offset: 0x00015855
		// (set) Token: 0x06002C1C RID: 11292 RVA: 0x0001765D File Offset: 0x0001585D
		public ulong TemplateProtoGUID { get; set; }

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06002C1D RID: 11293 RVA: 0x00017666 File Offset: 0x00015866
		// (set) Token: 0x06002C1E RID: 11294 RVA: 0x0001766E File Offset: 0x0001586E
		public int Level { get; set; }

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06002C1F RID: 11295 RVA: 0x00017677 File Offset: 0x00015877
		// (set) Token: 0x06002C20 RID: 11296 RVA: 0x0001767F File Offset: 0x0001587F
		public ulong MapGUID { get; set; }

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06002C21 RID: 11297 RVA: 0x00017688 File Offset: 0x00015888
		// (set) Token: 0x06002C22 RID: 11298 RVA: 0x00017690 File Offset: 0x00015890
		public int LivesStarting { get; set; }

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06002C23 RID: 11299 RVA: 0x00017699 File Offset: 0x00015899
		// (set) Token: 0x06002C24 RID: 11300 RVA: 0x000176A1 File Offset: 0x000158A1
		public int LivesRemaining { get; set; }

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06002C25 RID: 11301 RVA: 0x000176AA File Offset: 0x000158AA
		// (set) Token: 0x06002C26 RID: 11302 RVA: 0x000176B2 File Offset: 0x000158B2
		public uint RerollsRemaining { get; set; }

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06002C27 RID: 11303 RVA: 0x000176BB File Offset: 0x000158BB
		// (set) Token: 0x06002C28 RID: 11304 RVA: 0x000176C3 File Offset: 0x000158C3
		public List<ulong> ModifierGUIDs { get; set; }

		// Token: 0x06002C29 RID: 11305 RVA: 0x000FD7A8 File Offset: 0x000FB9A8
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.KeystoneDetailID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.TemplateProtoGUID);
			ArrayManager.WriteInt32(ref newArray, ref num, this.Level);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.MapGUID);
			ArrayManager.WriteInt32(ref newArray, ref num, this.LivesStarting);
			ArrayManager.WriteInt32(ref newArray, ref num, this.LivesRemaining);
			ArrayManager.WriteUInt32(ref newArray, ref num, this.RerollsRemaining);
			ArrayManager.WriteListUInt64(ref newArray, ref num, this.ModifierGUIDs);
			byte[] array = base.SerializeMessage();
			if (array.Length + num > newArray.Length)
			{
				Array.Resize<byte>(ref newArray, array.Length + num);
			}
			Array.Copy(array, 0, newArray, num, array.Length);
			num += array.Length;
			Array.Resize<byte>(ref newArray, num);
			return newArray;
		}

		// Token: 0x06002C2A RID: 11306 RVA: 0x000FD870 File Offset: 0x000FBA70
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.KeystoneDetailID = ArrayManager.ReadUInt64(data, ref num);
			this.TemplateProtoGUID = ArrayManager.ReadUInt64(data, ref num);
			this.Level = ArrayManager.ReadInt32(data, ref num);
			this.MapGUID = ArrayManager.ReadUInt64(data, ref num);
			this.LivesStarting = ArrayManager.ReadInt32(data, ref num);
			this.LivesRemaining = ArrayManager.ReadInt32(data, ref num);
			this.RerollsRemaining = ArrayManager.ReadUInt32(data, ref num);
			this.ModifierGUIDs = ArrayManager.ReadListUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002C2B RID: 11307 RVA: 0x000FD910 File Offset: 0x000FBB10
		private void InitRefTypes()
		{
			this.KeystoneDetailID = 0UL;
			this.TemplateProtoGUID = 0UL;
			this.Level = 0;
			this.MapGUID = 0UL;
			this.LivesStarting = 0;
			this.LivesRemaining = 0;
			this.RerollsRemaining = 0u;
			this.ModifierGUIDs = new List<ulong>();
		}
	}
}
