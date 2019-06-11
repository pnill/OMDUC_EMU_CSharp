using System;

namespace NetworkProtocols
{
	// Token: 0x020005D0 RID: 1488
	public class SurviveEndlessWaveTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x060033DB RID: 13275 RVA: 0x0001C082 File Offset: 0x0001A282
		public SurviveEndlessWaveTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3613682038u;
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x060033DC RID: 13276 RVA: 0x0001C09B File Offset: 0x0001A29B
		// (set) Token: 0x060033DD RID: 13277 RVA: 0x0001C0A3 File Offset: 0x0001A2A3
		public uint Denominator { get; set; }

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x060033DE RID: 13278 RVA: 0x0001C0AC File Offset: 0x0001A2AC
		// (set) Token: 0x060033DF RID: 13279 RVA: 0x0001C0B4 File Offset: 0x0001A2B4
		public uint Numerator { get; set; }

		// Token: 0x060033E0 RID: 13280 RVA: 0x00106F64 File Offset: 0x00105164
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

		// Token: 0x060033E1 RID: 13281 RVA: 0x00106FD4 File Offset: 0x001051D4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x060033E2 RID: 13282 RVA: 0x0001C0BD File Offset: 0x0001A2BD
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
