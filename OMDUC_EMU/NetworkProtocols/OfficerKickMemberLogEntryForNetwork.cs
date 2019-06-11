using System;

namespace NetworkProtocols
{
	// Token: 0x0200077A RID: 1914
	public class OfficerKickMemberLogEntryForNetwork : GuildLogEntryForNetwork
	{
		// Token: 0x060043DC RID: 17372 RVA: 0x000271AB File Offset: 0x000253AB
		public OfficerKickMemberLogEntryForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3917609880u;
		}

		// Token: 0x060043DD RID: 17373 RVA: 0x00122974 File Offset: 0x00120B74
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

		// Token: 0x060043DE RID: 17374 RVA: 0x001229C4 File Offset: 0x00120BC4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x060043DF RID: 17375 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
