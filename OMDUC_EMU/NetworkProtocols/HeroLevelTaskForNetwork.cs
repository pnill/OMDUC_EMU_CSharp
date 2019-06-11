using System;

namespace NetworkProtocols
{
	// Token: 0x020005EC RID: 1516
	public class HeroLevelTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x060034C1 RID: 13505 RVA: 0x0001C901 File Offset: 0x0001AB01
		public HeroLevelTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3372718083u;
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x060034C2 RID: 13506 RVA: 0x0001C91A File Offset: 0x0001AB1A
		// (set) Token: 0x060034C3 RID: 13507 RVA: 0x0001C922 File Offset: 0x0001AB22
		public ulong HeroGUID { get; set; }

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x060034C4 RID: 13508 RVA: 0x0001C92B File Offset: 0x0001AB2B
		// (set) Token: 0x060034C5 RID: 13509 RVA: 0x0001C933 File Offset: 0x0001AB33
		public uint Denominator { get; set; }

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x060034C6 RID: 13510 RVA: 0x0001C93C File Offset: 0x0001AB3C
		// (set) Token: 0x060034C7 RID: 13511 RVA: 0x0001C944 File Offset: 0x0001AB44
		public uint Numerator { get; set; }

		// Token: 0x060034C8 RID: 13512 RVA: 0x00108448 File Offset: 0x00106648
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.HeroGUID);
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

		// Token: 0x060034C9 RID: 13513 RVA: 0x001084C8 File Offset: 0x001066C8
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.HeroGUID = ArrayManager.ReadUInt64(data, ref num);
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x060034CA RID: 13514 RVA: 0x0001C94D File Offset: 0x0001AB4D
		private void InitRefTypes()
		{
			this.HeroGUID = 0UL;
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
