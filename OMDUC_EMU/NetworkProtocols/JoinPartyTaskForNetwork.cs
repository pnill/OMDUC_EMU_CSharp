using System;

namespace NetworkProtocols
{
	// Token: 0x020005F6 RID: 1526
	public class JoinPartyTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x06003515 RID: 13589 RVA: 0x0001CC20 File Offset: 0x0001AE20
		public JoinPartyTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2003587898u;
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06003516 RID: 13590 RVA: 0x0001CC39 File Offset: 0x0001AE39
		// (set) Token: 0x06003517 RID: 13591 RVA: 0x0001CC41 File Offset: 0x0001AE41
		public uint Denominator { get; set; }

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06003518 RID: 13592 RVA: 0x0001CC4A File Offset: 0x0001AE4A
		// (set) Token: 0x06003519 RID: 13593 RVA: 0x0001CC52 File Offset: 0x0001AE52
		public uint Numerator { get; set; }

		// Token: 0x0600351A RID: 13594 RVA: 0x00108BD8 File Offset: 0x00106DD8
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

		// Token: 0x0600351B RID: 13595 RVA: 0x00108C48 File Offset: 0x00106E48
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x0600351C RID: 13596 RVA: 0x0001CC5B File Offset: 0x0001AE5B
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
