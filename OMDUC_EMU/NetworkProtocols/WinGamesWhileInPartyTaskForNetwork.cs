using System;

namespace NetworkProtocols
{
	// Token: 0x020005D4 RID: 1492
	public class WinGamesWhileInPartyTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x060033FB RID: 13307 RVA: 0x0001C1AE File Offset: 0x0001A3AE
		public WinGamesWhileInPartyTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2353097081u;
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x060033FC RID: 13308 RVA: 0x0001C1C7 File Offset: 0x0001A3C7
		// (set) Token: 0x060033FD RID: 13309 RVA: 0x0001C1CF File Offset: 0x0001A3CF
		public uint Denominator { get; set; }

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x060033FE RID: 13310 RVA: 0x0001C1D8 File Offset: 0x0001A3D8
		// (set) Token: 0x060033FF RID: 13311 RVA: 0x0001C1E0 File Offset: 0x0001A3E0
		public uint Numerator { get; set; }

		// Token: 0x06003400 RID: 13312 RVA: 0x00107254 File Offset: 0x00105454
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

		// Token: 0x06003401 RID: 13313 RVA: 0x001072C4 File Offset: 0x001054C4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06003402 RID: 13314 RVA: 0x0001C1E9 File Offset: 0x0001A3E9
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
