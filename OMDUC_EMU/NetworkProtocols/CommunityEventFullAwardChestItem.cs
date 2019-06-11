using System;

namespace NetworkProtocols
{
	// Token: 0x02000565 RID: 1381
	public class CommunityEventFullAwardChestItem : BaseAwardItem
	{
		// Token: 0x06002F06 RID: 12038 RVA: 0x00018F50 File Offset: 0x00017150
		public CommunityEventFullAwardChestItem()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1090580056u;
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06002F07 RID: 12039 RVA: 0x00018F69 File Offset: 0x00017169
		// (set) Token: 0x06002F08 RID: 12040 RVA: 0x00018F71 File Offset: 0x00017171
		public ulong AccountSUID { get; set; }

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06002F09 RID: 12041 RVA: 0x00018F7A File Offset: 0x0001717A
		// (set) Token: 0x06002F0A RID: 12042 RVA: 0x00018F82 File Offset: 0x00017182
		public ulong EventID { get; set; }

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06002F0B RID: 12043 RVA: 0x00018F8B File Offset: 0x0001718B
		// (set) Token: 0x06002F0C RID: 12044 RVA: 0x00018F93 File Offset: 0x00017193
		public ulong EventChestID { get; set; }

		// Token: 0x06002F0D RID: 12045 RVA: 0x001007BC File Offset: 0x000FE9BC
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.AccountSUID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.EventID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.EventChestID);
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

		// Token: 0x06002F0E RID: 12046 RVA: 0x0010083C File Offset: 0x000FEA3C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.EventID = ArrayManager.ReadUInt64(data, ref num);
			this.EventChestID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002F0F RID: 12047 RVA: 0x00018F9C File Offset: 0x0001719C
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.EventID = 0UL;
			this.EventChestID = 0UL;
		}
	}
}
