using System;

namespace NetworkProtocols
{
	// Token: 0x0200055C RID: 1372
	public class PlayerMessageCommunityEventFullAwardItem : BaseAwardItem
	{
		// Token: 0x06002EAA RID: 11946 RVA: 0x00018BA1 File Offset: 0x00016DA1
		public PlayerMessageCommunityEventFullAwardItem()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1030536601u;
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06002EAB RID: 11947 RVA: 0x00018BBA File Offset: 0x00016DBA
		// (set) Token: 0x06002EAC RID: 11948 RVA: 0x00018BC2 File Offset: 0x00016DC2
		public ulong AccountSUID { get; set; }

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06002EAD RID: 11949 RVA: 0x00018BCB File Offset: 0x00016DCB
		// (set) Token: 0x06002EAE RID: 11950 RVA: 0x00018BD3 File Offset: 0x00016DD3
		public ulong EventID { get; set; }

		// Token: 0x06002EAF RID: 11951 RVA: 0x00100008 File Offset: 0x000FE208
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.AccountSUID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.EventID);
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

		// Token: 0x06002EB0 RID: 11952 RVA: 0x00100078 File Offset: 0x000FE278
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.EventID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002EB1 RID: 11953 RVA: 0x00018BDC File Offset: 0x00016DDC
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.EventID = 0UL;
		}
	}
}
