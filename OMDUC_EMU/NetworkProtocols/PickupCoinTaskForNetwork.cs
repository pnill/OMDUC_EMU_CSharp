using System;

namespace NetworkProtocols
{
	// Token: 0x020005E4 RID: 1508
	public class PickupCoinTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x0600347B RID: 13435 RVA: 0x0001C65E File Offset: 0x0001A85E
		public PickupCoinTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 333445641u;
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x0600347C RID: 13436 RVA: 0x0001C677 File Offset: 0x0001A877
		// (set) Token: 0x0600347D RID: 13437 RVA: 0x0001C67F File Offset: 0x0001A87F
		public uint Denominator { get; set; }

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x0600347E RID: 13438 RVA: 0x0001C688 File Offset: 0x0001A888
		// (set) Token: 0x0600347F RID: 13439 RVA: 0x0001C690 File Offset: 0x0001A890
		public uint Numerator { get; set; }

		// Token: 0x06003480 RID: 13440 RVA: 0x00107E14 File Offset: 0x00106014
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt32(ref newArray, ref num, this.Denominator);
			ArrayManager.WriteUInt32(ref newArray, ref num, this.Numerator);
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

		// Token: 0x06003481 RID: 13441 RVA: 0x00107E84 File Offset: 0x00106084
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06003482 RID: 13442 RVA: 0x0001C699 File Offset: 0x0001A899
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
