using System;

namespace NetworkProtocols
{
	// Token: 0x020005D6 RID: 1494
	public class PlayGamesTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x0600340B RID: 13323 RVA: 0x0001C244 File Offset: 0x0001A444
		public PlayGamesTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 567682249u;
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x0600340C RID: 13324 RVA: 0x0001C25D File Offset: 0x0001A45D
		// (set) Token: 0x0600340D RID: 13325 RVA: 0x0001C265 File Offset: 0x0001A465
		public uint Denominator { get; set; }

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x0600340E RID: 13326 RVA: 0x0001C26E File Offset: 0x0001A46E
		// (set) Token: 0x0600340F RID: 13327 RVA: 0x0001C276 File Offset: 0x0001A476
		public uint Numerator { get; set; }

		// Token: 0x06003410 RID: 13328 RVA: 0x001073CC File Offset: 0x001055CC
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt32(ref newArray, ref num, this.Denominator);
			ArrayManager.WriteUInt32(ref newArray, ref num, this.Numerator);
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

		// Token: 0x06003411 RID: 13329 RVA: 0x0010743C File Offset: 0x0010563C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06003412 RID: 13330 RVA: 0x0001C27F File Offset: 0x0001A47F
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
