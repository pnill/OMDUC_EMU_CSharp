using System;

namespace NetworkProtocols
{
	// Token: 0x0200054F RID: 1359
	public class HeroWinAwardChestItem : BaseAwardItem
	{
		// Token: 0x06002E56 RID: 11862 RVA: 0x00018907 File Offset: 0x00016B07
		public HeroWinAwardChestItem()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1547156522u;
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06002E57 RID: 11863 RVA: 0x00018920 File Offset: 0x00016B20
		// (set) Token: 0x06002E58 RID: 11864 RVA: 0x00018928 File Offset: 0x00016B28
		public ulong EventChestGUID { get; set; }

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06002E59 RID: 11865 RVA: 0x00018931 File Offset: 0x00016B31
		// (set) Token: 0x06002E5A RID: 11866 RVA: 0x00018939 File Offset: 0x00016B39
		public ulong HeroGUID { get; set; }

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06002E5B RID: 11867 RVA: 0x00018942 File Offset: 0x00016B42
		// (set) Token: 0x06002E5C RID: 11868 RVA: 0x0001894A File Offset: 0x00016B4A
		public ulong MapGUID { get; set; }

		// Token: 0x06002E5D RID: 11869 RVA: 0x000FFB60 File Offset: 0x000FDD60
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.EventChestGUID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.HeroGUID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.MapGUID);
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

		// Token: 0x06002E5E RID: 11870 RVA: 0x000FFBE0 File Offset: 0x000FDDE0
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.EventChestGUID = ArrayManager.ReadUInt64(data, ref num);
			this.HeroGUID = ArrayManager.ReadUInt64(data, ref num);
			this.MapGUID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002E5F RID: 11871 RVA: 0x00018953 File Offset: 0x00016B53
		private void InitRefTypes()
		{
			this.EventChestGUID = 0UL;
			this.HeroGUID = 0UL;
			this.MapGUID = 0UL;
		}
	}
}
