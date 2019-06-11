using System;

namespace NetworkProtocols
{
	// Token: 0x0200062C RID: 1580
	public class NetworkHeroWinAwardMessage : NetworkPlayerMessage
	{
		// Token: 0x060036FF RID: 14079 RVA: 0x0001E20E File Offset: 0x0001C40E
		public NetworkHeroWinAwardMessage()
		{
			this.InitRefTypes();
			this.UniqueClassID = 178032672u;
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06003700 RID: 14080 RVA: 0x0001E227 File Offset: 0x0001C427
		// (set) Token: 0x06003701 RID: 14081 RVA: 0x0001E22F File Offset: 0x0001C42F
		public ulong HeroGUID { get; set; }

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06003702 RID: 14082 RVA: 0x0001E238 File Offset: 0x0001C438
		// (set) Token: 0x06003703 RID: 14083 RVA: 0x0001E240 File Offset: 0x0001C440
		public ulong MapGUID { get; set; }

		// Token: 0x06003704 RID: 14084 RVA: 0x0010BD6C File Offset: 0x00109F6C
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.HeroGUID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.MapGUID);
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

		// Token: 0x06003705 RID: 14085 RVA: 0x0010BDDC File Offset: 0x00109FDC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.HeroGUID = ArrayManager.ReadUInt64(data, ref num);
			this.MapGUID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06003706 RID: 14086 RVA: 0x0001E249 File Offset: 0x0001C449
		private void InitRefTypes()
		{
			this.HeroGUID = 0UL;
			this.MapGUID = 0UL;
		}
	}
}
