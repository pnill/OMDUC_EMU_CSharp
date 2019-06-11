using System;

namespace NetworkProtocols
{
	// Token: 0x020005E5 RID: 1509
	public class PlayMatchmadeGameTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x06003483 RID: 13443 RVA: 0x0001C6A9 File Offset: 0x0001A8A9
		public PlayMatchmadeGameTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1282244478u;
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06003484 RID: 13444 RVA: 0x0001C6C2 File Offset: 0x0001A8C2
		// (set) Token: 0x06003485 RID: 13445 RVA: 0x0001C6CA File Offset: 0x0001A8CA
		public uint Denominator { get; set; }

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06003486 RID: 13446 RVA: 0x0001C6D3 File Offset: 0x0001A8D3
		// (set) Token: 0x06003487 RID: 13447 RVA: 0x0001C6DB File Offset: 0x0001A8DB
		public uint Numerator { get; set; }

		// Token: 0x06003488 RID: 13448 RVA: 0x00107ED0 File Offset: 0x001060D0
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

		// Token: 0x06003489 RID: 13449 RVA: 0x00107F40 File Offset: 0x00106140
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x0600348A RID: 13450 RVA: 0x0001C6E4 File Offset: 0x0001A8E4
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
