using System;

namespace NetworkProtocols
{
	// Token: 0x02000779 RID: 1913
	public class MemberLeaveGuildLogEntryForNetwork : GuildLogEntryForNetwork
	{
		// Token: 0x060043D8 RID: 17368 RVA: 0x00027192 File Offset: 0x00025392
		public MemberLeaveGuildLogEntryForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 303520518u;
		}

		// Token: 0x060043D9 RID: 17369 RVA: 0x00122974 File Offset: 0x00120B74
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

		// Token: 0x060043DA RID: 17370 RVA: 0x001229C4 File Offset: 0x00120BC4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x060043DB RID: 17371 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
