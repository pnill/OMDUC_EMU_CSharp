using System;

namespace NetworkProtocols
{
	// Token: 0x020005D5 RID: 1493
	public class WinNumberOfGamesTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x06003403 RID: 13315 RVA: 0x0001C1F9 File Offset: 0x0001A3F9
		public WinNumberOfGamesTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 438611061u;
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06003404 RID: 13316 RVA: 0x0001C212 File Offset: 0x0001A412
		// (set) Token: 0x06003405 RID: 13317 RVA: 0x0001C21A File Offset: 0x0001A41A
		public uint Denominator { get; set; }

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06003406 RID: 13318 RVA: 0x0001C223 File Offset: 0x0001A423
		// (set) Token: 0x06003407 RID: 13319 RVA: 0x0001C22B File Offset: 0x0001A42B
		public uint Numerator { get; set; }

		// Token: 0x06003408 RID: 13320 RVA: 0x00107310 File Offset: 0x00105510
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

		// Token: 0x06003409 RID: 13321 RVA: 0x00107380 File Offset: 0x00105580
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x0600340A RID: 13322 RVA: 0x0001C234 File Offset: 0x0001A434
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
