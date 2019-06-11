using System;

namespace NetworkProtocols
{
	// Token: 0x02000504 RID: 1284
	public class GoldCredit : BaseAwardEntry
	{
		// Token: 0x06002CAE RID: 11438 RVA: 0x00017BD7 File Offset: 0x00015DD7
		public GoldCredit()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1310993843u;
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06002CAF RID: 11439 RVA: 0x00017BF0 File Offset: 0x00015DF0
		// (set) Token: 0x06002CB0 RID: 11440 RVA: 0x00017BF8 File Offset: 0x00015DF8
		public bool IsRefund { get; set; }

		// Token: 0x06002CB1 RID: 11441 RVA: 0x000FE390 File Offset: 0x000FC590
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteBoolean(ref newArray, ref num, this.IsRefund);
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

		// Token: 0x06002CB2 RID: 11442 RVA: 0x000FE3F0 File Offset: 0x000FC5F0
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.IsRefund = ArrayManager.ReadBoolean(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002CB3 RID: 11443 RVA: 0x00017C01 File Offset: 0x00015E01
		private void InitRefTypes()
		{
			this.IsRefund = false;
		}
	}
}
