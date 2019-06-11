using System;

namespace NetworkProtocols
{
	// Token: 0x02000632 RID: 1586
	public class NetworkKeystoneWinAwardMessage : NetworkPlayerMessage
	{
		// Token: 0x0600372F RID: 14127 RVA: 0x0001E3D9 File Offset: 0x0001C5D9
		public NetworkKeystoneWinAwardMessage()
		{
			this.InitRefTypes();
			this.UniqueClassID = 671867295u;
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06003730 RID: 14128 RVA: 0x0001E3F2 File Offset: 0x0001C5F2
		// (set) Token: 0x06003731 RID: 14129 RVA: 0x0001E3FA File Offset: 0x0001C5FA
		public ulong KeystoneID { get; set; }

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x06003732 RID: 14130 RVA: 0x0001E403 File Offset: 0x0001C603
		// (set) Token: 0x06003733 RID: 14131 RVA: 0x0001E40B File Offset: 0x0001C60B
		public ulong BucketID { get; set; }

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06003734 RID: 14132 RVA: 0x0001E414 File Offset: 0x0001C614
		// (set) Token: 0x06003735 RID: 14133 RVA: 0x0001E41C File Offset: 0x0001C61C
		public int Level { get; set; }

		// Token: 0x06003736 RID: 14134 RVA: 0x0010C1C8 File Offset: 0x0010A3C8
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.KeystoneID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.BucketID);
			ArrayManager.WriteInt32(ref newArray, ref num, this.Level);
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

		// Token: 0x06003737 RID: 14135 RVA: 0x0010C248 File Offset: 0x0010A448
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.KeystoneID = ArrayManager.ReadUInt64(data, ref num);
			this.BucketID = ArrayManager.ReadUInt64(data, ref num);
			this.Level = ArrayManager.ReadInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06003738 RID: 14136 RVA: 0x0001E425 File Offset: 0x0001C625
		private void InitRefTypes()
		{
			this.KeystoneID = 0UL;
			this.BucketID = 0UL;
			this.Level = 0;
		}
	}
}
