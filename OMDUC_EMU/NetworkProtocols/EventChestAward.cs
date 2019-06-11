using System;

namespace NetworkProtocols
{
	// Token: 0x0200053D RID: 1341
	public class EventChestAward : BaseAwardItem
	{
		// Token: 0x06002DBE RID: 11710 RVA: 0x0001839C File Offset: 0x0001659C
		public EventChestAward()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1794149271u;
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06002DBF RID: 11711 RVA: 0x000183B5 File Offset: 0x000165B5
		// (set) Token: 0x06002DC0 RID: 11712 RVA: 0x000183BD File Offset: 0x000165BD
		public ulong EventChestGUID { get; set; }

		// Token: 0x06002DC1 RID: 11713 RVA: 0x000FEE44 File Offset: 0x000FD044
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

		// Token: 0x06002DC2 RID: 11714 RVA: 0x000FEEA4 File Offset: 0x000FD0A4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.EventChestGUID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002DC3 RID: 11715 RVA: 0x000183C6 File Offset: 0x000165C6
		private void InitRefTypes()
		{
			this.EventChestGUID = 0UL;
		}
	}
}
