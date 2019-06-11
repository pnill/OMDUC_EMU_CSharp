using System;

namespace NetworkProtocols
{
	// Token: 0x020005D1 RID: 1489
	public class WinWeeklyChallengesTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x060033E3 RID: 13283 RVA: 0x0001C0CD File Offset: 0x0001A2CD
		public WinWeeklyChallengesTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1258796817u;
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x060033E4 RID: 13284 RVA: 0x0001C0E6 File Offset: 0x0001A2E6
		// (set) Token: 0x060033E5 RID: 13285 RVA: 0x0001C0EE File Offset: 0x0001A2EE
		public uint Denominator { get; set; }

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x060033E6 RID: 13286 RVA: 0x0001C0F7 File Offset: 0x0001A2F7
		// (set) Token: 0x060033E7 RID: 13287 RVA: 0x0001C0FF File Offset: 0x0001A2FF
		public uint Numerator { get; set; }

		// Token: 0x060033E8 RID: 13288 RVA: 0x00107020 File Offset: 0x00105220
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

		// Token: 0x060033E9 RID: 13289 RVA: 0x00107090 File Offset: 0x00105290
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x060033EA RID: 13290 RVA: 0x0001C108 File Offset: 0x0001A308
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
