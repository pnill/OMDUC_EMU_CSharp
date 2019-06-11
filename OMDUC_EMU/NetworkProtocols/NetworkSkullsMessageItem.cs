using System;

namespace NetworkProtocols
{
	// Token: 0x02000629 RID: 1577
	public class NetworkSkullsMessageItem : NetworkMessageItemBase
	{
		// Token: 0x060036E7 RID: 14055 RVA: 0x0001E128 File Offset: 0x0001C328
		public NetworkSkullsMessageItem()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3496502321u;
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x060036E8 RID: 14056 RVA: 0x0001E141 File Offset: 0x0001C341
		// (set) Token: 0x060036E9 RID: 14057 RVA: 0x0001E149 File Offset: 0x0001C349
		public int Amount { get; set; }

		// Token: 0x060036EA RID: 14058 RVA: 0x0010BB3C File Offset: 0x00109D3C
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteInt32(ref newArray, ref num, this.Amount);
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

		// Token: 0x060036EB RID: 14059 RVA: 0x0010BB9C File Offset: 0x00109D9C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Amount = ArrayManager.ReadInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x060036EC RID: 14060 RVA: 0x0001E152 File Offset: 0x0001C352
		private void InitRefTypes()
		{
			this.Amount = 0;
		}
	}
}
