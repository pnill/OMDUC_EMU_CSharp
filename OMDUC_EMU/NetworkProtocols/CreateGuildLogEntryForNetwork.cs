using System;

namespace NetworkProtocols
{
	// Token: 0x02000775 RID: 1909
	public class CreateGuildLogEntryForNetwork : GuildLogEntryForNetwork
	{
		// Token: 0x060043C8 RID: 17352 RVA: 0x0002712E File Offset: 0x0002532E
		public CreateGuildLogEntryForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1486585326u;
		}

		// Token: 0x060043C9 RID: 17353 RVA: 0x00122974 File Offset: 0x00120B74
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

		// Token: 0x060043CA RID: 17354 RVA: 0x001229C4 File Offset: 0x00120BC4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x060043CB RID: 17355 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
