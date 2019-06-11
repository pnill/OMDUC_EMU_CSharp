using System;

namespace NetworkProtocols
{
	// Token: 0x0200077E RID: 1918
	public class AbsenteeLeaderReplacedLogEntryForNetwork : GuildLogEntryForNetwork
	{
		// Token: 0x060043F0 RID: 17392 RVA: 0x0002724B File Offset: 0x0002544B
		public AbsenteeLeaderReplacedLogEntryForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1943638642u;
		}

		// Token: 0x060043F1 RID: 17393 RVA: 0x00122974 File Offset: 0x00120B74
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

		// Token: 0x060043F2 RID: 17394 RVA: 0x001229C4 File Offset: 0x00120BC4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x060043F3 RID: 17395 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
