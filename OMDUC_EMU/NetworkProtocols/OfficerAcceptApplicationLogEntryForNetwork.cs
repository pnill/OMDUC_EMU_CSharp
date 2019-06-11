using System;

namespace NetworkProtocols
{
	// Token: 0x02000778 RID: 1912
	public class OfficerAcceptApplicationLogEntryForNetwork : GuildLogEntryForNetwork
	{
		// Token: 0x060043D4 RID: 17364 RVA: 0x00027179 File Offset: 0x00025379
		public OfficerAcceptApplicationLogEntryForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1455330346u;
		}

		// Token: 0x060043D5 RID: 17365 RVA: 0x00122974 File Offset: 0x00120B74
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

		// Token: 0x060043D6 RID: 17366 RVA: 0x001229C4 File Offset: 0x00120BC4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x060043D7 RID: 17367 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
