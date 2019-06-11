using System;

namespace NetworkProtocols
{
	// Token: 0x020004FC RID: 1276
	public class TrapStrength : BaseAwardEntry
	{
		// Token: 0x06002C7A RID: 11386 RVA: 0x00017A0F File Offset: 0x00015C0F
		public TrapStrength()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1720564818u;
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06002C7B RID: 11387 RVA: 0x00017A28 File Offset: 0x00015C28
		// (set) Token: 0x06002C7C RID: 11388 RVA: 0x00017A30 File Offset: 0x00015C30
		public ulong TrapItemGUID { get; set; }

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06002C7D RID: 11389 RVA: 0x00017A39 File Offset: 0x00015C39
		// (set) Token: 0x06002C7E RID: 11390 RVA: 0x00017A41 File Offset: 0x00015C41
		public uint NewTrapStrength { get; set; }

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06002C7F RID: 11391 RVA: 0x00017A4A File Offset: 0x00015C4A
		// (set) Token: 0x06002C80 RID: 11392 RVA: 0x00017A52 File Offset: 0x00015C52
		public ulong RecipeGUID { get; set; }

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06002C81 RID: 11393 RVA: 0x00017A5B File Offset: 0x00015C5B
		// (set) Token: 0x06002C82 RID: 11394 RVA: 0x00017A63 File Offset: 0x00015C63
		public ulong LinkedObjectGUID { get; set; }

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06002C83 RID: 11395 RVA: 0x00017A6C File Offset: 0x00015C6C
		// (set) Token: 0x06002C84 RID: 11396 RVA: 0x00017A74 File Offset: 0x00015C74
		public int UpgradeTier { get; set; }

		// Token: 0x06002C85 RID: 11397 RVA: 0x000FDF70 File Offset: 0x000FC170
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.TrapItemGUID);
			ArrayManager.WriteUInt32(ref newArray, ref num, this.NewTrapStrength);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.RecipeGUID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.LinkedObjectGUID);
			ArrayManager.WriteInt32(ref newArray, ref num, this.UpgradeTier);
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

		// Token: 0x06002C86 RID: 11398 RVA: 0x000FE00C File Offset: 0x000FC20C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.TrapItemGUID = ArrayManager.ReadUInt64(data, ref num);
			this.NewTrapStrength = ArrayManager.ReadUInt32(data, ref num);
			this.RecipeGUID = ArrayManager.ReadUInt64(data, ref num);
			this.LinkedObjectGUID = ArrayManager.ReadUInt64(data, ref num);
			this.UpgradeTier = ArrayManager.ReadInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002C87 RID: 11399 RVA: 0x00017A7D File Offset: 0x00015C7D
		private void InitRefTypes()
		{
			this.TrapItemGUID = 0UL;
			this.NewTrapStrength = 0u;
			this.RecipeGUID = 0UL;
			this.LinkedObjectGUID = 0UL;
			this.UpgradeTier = 0;
		}
	}
}
