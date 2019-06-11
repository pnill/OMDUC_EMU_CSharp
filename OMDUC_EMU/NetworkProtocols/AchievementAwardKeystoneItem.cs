using System;

namespace NetworkProtocols
{
	// Token: 0x0200054A RID: 1354
	public class AchievementAwardKeystoneItem : BaseAwardItem
	{
		// Token: 0x06002E26 RID: 11814 RVA: 0x0001874F File Offset: 0x0001694F
		public AchievementAwardKeystoneItem()
		{
			this.InitRefTypes();
			this.UniqueClassID = 808764528u;
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06002E27 RID: 11815 RVA: 0x00018768 File Offset: 0x00016968
		// (set) Token: 0x06002E28 RID: 11816 RVA: 0x00018770 File Offset: 0x00016970
		public ulong AchievementGUID { get; set; }

		// Token: 0x06002E29 RID: 11817 RVA: 0x000FF710 File Offset: 0x000FD910
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.AchievementGUID);
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

		// Token: 0x06002E2A RID: 11818 RVA: 0x000FF770 File Offset: 0x000FD970
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.AchievementGUID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002E2B RID: 11819 RVA: 0x00018779 File Offset: 0x00016979
		private void InitRefTypes()
		{
			this.AchievementGUID = 0UL;
		}
	}
}
