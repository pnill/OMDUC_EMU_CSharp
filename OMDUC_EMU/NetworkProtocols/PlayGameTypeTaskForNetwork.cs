using System;

namespace NetworkProtocols
{
	// Token: 0x020005ED RID: 1517
	public class PlayGameTypeTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x060034CB RID: 13515 RVA: 0x0001C965 File Offset: 0x0001AB65
		public PlayGameTypeTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1941499997u;
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x060034CC RID: 13516 RVA: 0x0001C97E File Offset: 0x0001AB7E
		// (set) Token: 0x060034CD RID: 13517 RVA: 0x0001C986 File Offset: 0x0001AB86
		public eGameType GameType { get; set; }

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x060034CE RID: 13518 RVA: 0x0001C98F File Offset: 0x0001AB8F
		// (set) Token: 0x060034CF RID: 13519 RVA: 0x0001C997 File Offset: 0x0001AB97
		public uint Denominator { get; set; }

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x060034D0 RID: 13520 RVA: 0x0001C9A0 File Offset: 0x0001ABA0
		// (set) Token: 0x060034D1 RID: 13521 RVA: 0x0001C9A8 File Offset: 0x0001ABA8
		public uint Numerator { get; set; }

		// Token: 0x060034D2 RID: 13522 RVA: 0x00108520 File Offset: 0x00106720
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteeGameType(ref newArray, ref num, this.GameType);
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

		// Token: 0x060034D3 RID: 13523 RVA: 0x001085A0 File Offset: 0x001067A0
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.GameType = ArrayManager.ReadeGameType(data, ref num);
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x060034D4 RID: 13524 RVA: 0x0001C9B1 File Offset: 0x0001ABB1
		private void InitRefTypes()
		{
			this.GameType = eGameType.None;
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
