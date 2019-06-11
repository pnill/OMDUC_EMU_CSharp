using System;

namespace NetworkProtocols
{
	// Token: 0x0200054E RID: 1358
	public class DailyLoginAwardChestItem : BaseAwardItem
	{
		// Token: 0x06002E4E RID: 11854 RVA: 0x000188BB File Offset: 0x00016ABB
		public DailyLoginAwardChestItem()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2940640369u;
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06002E4F RID: 11855 RVA: 0x000188D4 File Offset: 0x00016AD4
		// (set) Token: 0x06002E50 RID: 11856 RVA: 0x000188DC File Offset: 0x00016ADC
		public uint Day { get; set; }

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06002E51 RID: 11857 RVA: 0x000188E5 File Offset: 0x00016AE5
		// (set) Token: 0x06002E52 RID: 11858 RVA: 0x000188ED File Offset: 0x00016AED
		public ulong EventChestGUID { get; set; }

		// Token: 0x06002E53 RID: 11859 RVA: 0x000FFAA4 File Offset: 0x000FDCA4
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt32(ref newArray, ref num, this.Day);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.EventChestGUID);
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

		// Token: 0x06002E54 RID: 11860 RVA: 0x000FFB14 File Offset: 0x000FDD14
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Day = ArrayManager.ReadUInt32(data, ref num);
			this.EventChestGUID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002E55 RID: 11861 RVA: 0x000188F6 File Offset: 0x00016AF6
		private void InitRefTypes()
		{
			this.Day = 0u;
			this.EventChestGUID = 0UL;
		}
	}
}
