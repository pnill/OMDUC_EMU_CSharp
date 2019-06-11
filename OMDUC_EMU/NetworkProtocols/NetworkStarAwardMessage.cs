using System;

namespace NetworkProtocols
{
	// Token: 0x0200062E RID: 1582
	public class NetworkStarAwardMessage : NetworkPlayerMessage
	{
		// Token: 0x0600370D RID: 14093 RVA: 0x0001E28E File Offset: 0x0001C48E
		public NetworkStarAwardMessage()
		{
			this.InitRefTypes();
			this.UniqueClassID = 798645747u;
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x0600370E RID: 14094 RVA: 0x0001E2A7 File Offset: 0x0001C4A7
		// (set) Token: 0x0600370F RID: 14095 RVA: 0x0001E2AF File Offset: 0x0001C4AF
		public ulong GameMapID { get; set; }

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x06003710 RID: 14096 RVA: 0x0001E2B8 File Offset: 0x0001C4B8
		// (set) Token: 0x06003711 RID: 14097 RVA: 0x0001E2C0 File Offset: 0x0001C4C0
		public eGameType GameType { get; set; }

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x06003712 RID: 14098 RVA: 0x0001E2C9 File Offset: 0x0001C4C9
		// (set) Token: 0x06003713 RID: 14099 RVA: 0x0001E2D1 File Offset: 0x0001C4D1
		public ulong BucketID { get; set; }

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x06003714 RID: 14100 RVA: 0x0001E2DA File Offset: 0x0001C4DA
		// (set) Token: 0x06003715 RID: 14101 RVA: 0x0001E2E2 File Offset: 0x0001C4E2
		public uint StarsAwarded { get; set; }

		// Token: 0x06003716 RID: 14102 RVA: 0x0010BEC4 File Offset: 0x0010A0C4
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.GameMapID);
			ArrayManager.WriteeGameType(ref newArray, ref num, this.GameType);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.BucketID);
			ArrayManager.WriteUInt32(ref newArray, ref num, this.StarsAwarded);
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

		// Token: 0x06003717 RID: 14103 RVA: 0x0010BF50 File Offset: 0x0010A150
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.GameMapID = ArrayManager.ReadUInt64(data, ref num);
			this.GameType = ArrayManager.ReadeGameType(data, ref num);
			this.BucketID = ArrayManager.ReadUInt64(data, ref num);
			this.StarsAwarded = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06003718 RID: 14104 RVA: 0x0001E2EB File Offset: 0x0001C4EB
		private void InitRefTypes()
		{
			this.GameMapID = 0UL;
			this.GameType = eGameType.None;
			this.BucketID = 0UL;
			this.StarsAwarded = 0u;
		}
	}
}
