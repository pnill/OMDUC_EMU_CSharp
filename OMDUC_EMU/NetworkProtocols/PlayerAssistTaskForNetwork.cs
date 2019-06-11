using System;

namespace NetworkProtocols
{
	// Token: 0x020005EE RID: 1518
	public class PlayerAssistTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x060034D5 RID: 13525 RVA: 0x0001C9C8 File Offset: 0x0001ABC8
		public PlayerAssistTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3719413140u;
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x060034D6 RID: 13526 RVA: 0x0001C9E1 File Offset: 0x0001ABE1
		// (set) Token: 0x060034D7 RID: 13527 RVA: 0x0001C9E9 File Offset: 0x0001ABE9
		public uint Denominator { get; set; }

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x060034D8 RID: 13528 RVA: 0x0001C9F2 File Offset: 0x0001ABF2
		// (set) Token: 0x060034D9 RID: 13529 RVA: 0x0001C9FA File Offset: 0x0001ABFA
		public uint Numerator { get; set; }

		// Token: 0x060034DA RID: 13530 RVA: 0x001085F8 File Offset: 0x001067F8
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

		// Token: 0x060034DB RID: 13531 RVA: 0x00108668 File Offset: 0x00106868
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x060034DC RID: 13532 RVA: 0x0001CA03 File Offset: 0x0001AC03
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
