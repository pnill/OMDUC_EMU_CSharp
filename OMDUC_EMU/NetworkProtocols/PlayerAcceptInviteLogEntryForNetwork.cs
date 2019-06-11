using System;

namespace NetworkProtocols
{
	// Token: 0x02000777 RID: 1911
	public class PlayerAcceptInviteLogEntryForNetwork : GuildLogEntryForNetwork
	{
		// Token: 0x060043D0 RID: 17360 RVA: 0x00027160 File Offset: 0x00025360
		public PlayerAcceptInviteLogEntryForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3483166037u;
		}

		// Token: 0x060043D1 RID: 17361 RVA: 0x00122974 File Offset: 0x00120B74
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

		// Token: 0x060043D2 RID: 17362 RVA: 0x001229C4 File Offset: 0x00120BC4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x060043D3 RID: 17363 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
