using System;

namespace NetworkProtocols
{
	// Token: 0x020005CA RID: 1482
	public class GetStarsTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x060033AB RID: 13227 RVA: 0x0001BEC0 File Offset: 0x0001A0C0
		public GetStarsTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3982397481u;
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x060033AC RID: 13228 RVA: 0x0001BED9 File Offset: 0x0001A0D9
		// (set) Token: 0x060033AD RID: 13229 RVA: 0x0001BEE1 File Offset: 0x0001A0E1
		public uint Denominator { get; set; }

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x060033AE RID: 13230 RVA: 0x0001BEEA File Offset: 0x0001A0EA
		// (set) Token: 0x060033AF RID: 13231 RVA: 0x0001BEF2 File Offset: 0x0001A0F2
		public uint Numerator { get; set; }

		// Token: 0x060033B0 RID: 13232 RVA: 0x00106AFC File Offset: 0x00104CFC
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

		// Token: 0x060033B1 RID: 13233 RVA: 0x00106B6C File Offset: 0x00104D6C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x060033B2 RID: 13234 RVA: 0x0001BEFB File Offset: 0x0001A0FB
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
