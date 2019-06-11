using System;

namespace NetworkProtocols
{
	// Token: 0x02000628 RID: 1576
	public class NetworkChestMessageItem : NetworkMessageItemBase
	{
		// Token: 0x060036E1 RID: 14049 RVA: 0x0001E0F4 File Offset: 0x0001C2F4
		public NetworkChestMessageItem()
		{
			this.InitRefTypes();
			this.UniqueClassID = 827514608u;
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x060036E2 RID: 14050 RVA: 0x0001E10D File Offset: 0x0001C30D
		// (set) Token: 0x060036E3 RID: 14051 RVA: 0x0001E115 File Offset: 0x0001C315
		public ulong EventChestGUID { get; set; }

		// Token: 0x060036E4 RID: 14052 RVA: 0x0010BAA0 File Offset: 0x00109CA0
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
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

		// Token: 0x060036E5 RID: 14053 RVA: 0x0010BB00 File Offset: 0x00109D00
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.EventChestGUID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x060036E6 RID: 14054 RVA: 0x0001E11E File Offset: 0x0001C31E
		private void InitRefTypes()
		{
			this.EventChestGUID = 0UL;
		}
	}
}
