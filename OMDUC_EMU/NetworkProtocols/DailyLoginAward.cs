using System;

namespace NetworkProtocols
{
	// Token: 0x0200053C RID: 1340
	public class DailyLoginAward : BaseAwardItem
	{
		// Token: 0x06002DB8 RID: 11704 RVA: 0x00018369 File Offset: 0x00016569
		public DailyLoginAward()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3687677940u;
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06002DB9 RID: 11705 RVA: 0x00018382 File Offset: 0x00016582
		// (set) Token: 0x06002DBA RID: 11706 RVA: 0x0001838A File Offset: 0x0001658A
		public uint Day { get; set; }

		// Token: 0x06002DBB RID: 11707 RVA: 0x000FEDA8 File Offset: 0x000FCFA8
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt32(ref newArray, ref num, this.Day);
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

		// Token: 0x06002DBC RID: 11708 RVA: 0x000FEE08 File Offset: 0x000FD008
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Day = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002DBD RID: 11709 RVA: 0x00018393 File Offset: 0x00016593
		private void InitRefTypes()
		{
			this.Day = 0u;
		}
	}
}
