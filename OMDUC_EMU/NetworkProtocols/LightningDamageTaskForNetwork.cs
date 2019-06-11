using System;

namespace NetworkProtocols
{
	// Token: 0x020005E2 RID: 1506
	public class LightningDamageTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x0600346B RID: 13419 RVA: 0x0001C5C8 File Offset: 0x0001A7C8
		public LightningDamageTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2668310269u;
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x0600346C RID: 13420 RVA: 0x0001C5E1 File Offset: 0x0001A7E1
		// (set) Token: 0x0600346D RID: 13421 RVA: 0x0001C5E9 File Offset: 0x0001A7E9
		public uint Denominator { get; set; }

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x0600346E RID: 13422 RVA: 0x0001C5F2 File Offset: 0x0001A7F2
		// (set) Token: 0x0600346F RID: 13423 RVA: 0x0001C5FA File Offset: 0x0001A7FA
		public uint Numerator { get; set; }

		// Token: 0x06003470 RID: 13424 RVA: 0x00107C9C File Offset: 0x00105E9C
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

		// Token: 0x06003471 RID: 13425 RVA: 0x00107D0C File Offset: 0x00105F0C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06003472 RID: 13426 RVA: 0x0001C603 File Offset: 0x0001A803
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
