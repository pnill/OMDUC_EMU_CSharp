using System;

namespace NetworkProtocols
{
	// Token: 0x02000564 RID: 1380
	public class CommunityEventFullAwardItem : BaseAwardItem
	{
		// Token: 0x06002EFE RID: 12030 RVA: 0x00018F03 File Offset: 0x00017103
		public CommunityEventFullAwardItem()
		{
			this.InitRefTypes();
			this.UniqueClassID = 4168978622u;
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06002EFF RID: 12031 RVA: 0x00018F1C File Offset: 0x0001711C
		// (set) Token: 0x06002F00 RID: 12032 RVA: 0x00018F24 File Offset: 0x00017124
		public ulong AccountSUID { get; set; }

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06002F01 RID: 12033 RVA: 0x00018F2D File Offset: 0x0001712D
		// (set) Token: 0x06002F02 RID: 12034 RVA: 0x00018F35 File Offset: 0x00017135
		public ulong EventID { get; set; }

		// Token: 0x06002F03 RID: 12035 RVA: 0x00100700 File Offset: 0x000FE900
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

		// Token: 0x06002F04 RID: 12036 RVA: 0x00100770 File Offset: 0x000FE970
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.EventID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002F05 RID: 12037 RVA: 0x00018F3E File Offset: 0x0001713E
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.EventID = 0UL;
		}
	}
}
