using System;

namespace NetworkProtocols
{
	// Token: 0x0200077D RID: 1917
	public class AssignLeaderLogEntryForNetwork : GuildLogEntryForNetwork
	{
		// Token: 0x060043EC RID: 17388 RVA: 0x00027232 File Offset: 0x00025432
		public AssignLeaderLogEntryForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 934871032u;
		}

		// Token: 0x060043ED RID: 17389 RVA: 0x00122974 File Offset: 0x00120B74
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

		// Token: 0x060043EE RID: 17390 RVA: 0x001229C4 File Offset: 0x00120BC4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x060043EF RID: 17391 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
