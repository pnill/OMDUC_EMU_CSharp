using System;

namespace NetworkProtocols
{
	// Token: 0x020005F4 RID: 1524
	public class AddFriendTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x06003505 RID: 13573 RVA: 0x0001CB8A File Offset: 0x0001AD8A
		public AddFriendTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1990719653u;
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06003506 RID: 13574 RVA: 0x0001CBA3 File Offset: 0x0001ADA3
		// (set) Token: 0x06003507 RID: 13575 RVA: 0x0001CBAB File Offset: 0x0001ADAB
		public uint Denominator { get; set; }

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06003508 RID: 13576 RVA: 0x0001CBB4 File Offset: 0x0001ADB4
		// (set) Token: 0x06003509 RID: 13577 RVA: 0x0001CBBC File Offset: 0x0001ADBC
		public uint Numerator { get; set; }

		// Token: 0x0600350A RID: 13578 RVA: 0x00108A60 File Offset: 0x00106C60
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

		// Token: 0x0600350B RID: 13579 RVA: 0x00108AD0 File Offset: 0x00106CD0
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x0600350C RID: 13580 RVA: 0x0001CBC5 File Offset: 0x0001ADC5
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
