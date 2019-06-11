using System;

namespace NetworkProtocols
{
	// Token: 0x020005E7 RID: 1511
	public class KillPlayersTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x06003493 RID: 13459 RVA: 0x0001C73F File Offset: 0x0001A93F
		public KillPlayersTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1744587998u;
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06003494 RID: 13460 RVA: 0x0001C758 File Offset: 0x0001A958
		// (set) Token: 0x06003495 RID: 13461 RVA: 0x0001C760 File Offset: 0x0001A960
		public uint Denominator { get; set; }

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06003496 RID: 13462 RVA: 0x0001C769 File Offset: 0x0001A969
		// (set) Token: 0x06003497 RID: 13463 RVA: 0x0001C771 File Offset: 0x0001A971
		public uint Numerator { get; set; }

		// Token: 0x06003498 RID: 13464 RVA: 0x00108048 File Offset: 0x00106248
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

		// Token: 0x06003499 RID: 13465 RVA: 0x001080B8 File Offset: 0x001062B8
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x0600349A RID: 13466 RVA: 0x0001C77A File Offset: 0x0001A97A
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
