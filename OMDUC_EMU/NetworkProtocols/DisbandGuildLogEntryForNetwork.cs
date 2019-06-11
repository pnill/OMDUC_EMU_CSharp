using System;

namespace NetworkProtocols
{
	// Token: 0x02000776 RID: 1910
	public class DisbandGuildLogEntryForNetwork : GuildLogEntryForNetwork
	{
		// Token: 0x060043CC RID: 17356 RVA: 0x00027147 File Offset: 0x00025347
		public DisbandGuildLogEntryForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2995116941u;
		}

		// Token: 0x060043CD RID: 17357 RVA: 0x00122974 File Offset: 0x00120B74
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
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

		// Token: 0x060043CE RID: 17358 RVA: 0x001229C4 File Offset: 0x00120BC4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x060043CF RID: 17359 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
