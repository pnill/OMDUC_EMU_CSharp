using System;

namespace NetworkProtocols
{
	// Token: 0x0200077F RID: 1919
	public class GuildSeasonalRewardLogEntryForNetwork : GuildLogEntryForNetwork
	{
		// Token: 0x060043F4 RID: 17396 RVA: 0x00027264 File Offset: 0x00025464
		public GuildSeasonalRewardLogEntryForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1780481054u;
		}

		// Token: 0x060043F5 RID: 17397 RVA: 0x00122974 File Offset: 0x00120B74
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

		// Token: 0x060043F6 RID: 17398 RVA: 0x001229C4 File Offset: 0x00120BC4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x060043F7 RID: 17399 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
