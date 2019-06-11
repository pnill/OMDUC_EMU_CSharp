using System;

namespace NetworkProtocols
{
	// Token: 0x0200055D RID: 1373
	public class PlayerMessageCommunityEventFullAwardChestItem : BaseAwardItem
	{
		// Token: 0x06002EB2 RID: 11954 RVA: 0x00018BEE File Offset: 0x00016DEE
		public PlayerMessageCommunityEventFullAwardChestItem()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3419439331u;
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06002EB3 RID: 11955 RVA: 0x00018C07 File Offset: 0x00016E07
		// (set) Token: 0x06002EB4 RID: 11956 RVA: 0x00018C0F File Offset: 0x00016E0F
		public ulong AccountSUID { get; set; }

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06002EB5 RID: 11957 RVA: 0x00018C18 File Offset: 0x00016E18
		// (set) Token: 0x06002EB6 RID: 11958 RVA: 0x00018C20 File Offset: 0x00016E20
		public ulong EventID { get; set; }

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06002EB7 RID: 11959 RVA: 0x00018C29 File Offset: 0x00016E29
		// (set) Token: 0x06002EB8 RID: 11960 RVA: 0x00018C31 File Offset: 0x00016E31
		public ulong EventChestID { get; set; }

		// Token: 0x06002EB9 RID: 11961 RVA: 0x001000C4 File Offset: 0x000FE2C4
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

		// Token: 0x06002EBA RID: 11962 RVA: 0x00100144 File Offset: 0x000FE344
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

		// Token: 0x06002EBB RID: 11963 RVA: 0x00018C3A File Offset: 0x00016E3A
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.EventID = 0UL;
			this.EventChestID = 0UL;
		}
	}
}
