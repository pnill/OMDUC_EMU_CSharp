using System;

namespace NetworkProtocols
{
	// Token: 0x02000536 RID: 1334
	public class LevelUpAward : BaseAwardItem
	{
		// Token: 0x06002D9E RID: 11678 RVA: 0x000182B9 File Offset: 0x000164B9
		public LevelUpAward()
		{
			this.InitRefTypes();
			this.UniqueClassID = 4071604107u;
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06002D9F RID: 11679 RVA: 0x000182D2 File Offset: 0x000164D2
		// (set) Token: 0x06002DA0 RID: 11680 RVA: 0x000182DA File Offset: 0x000164DA
		public uint Level { get; set; }

		// Token: 0x06002DA1 RID: 11681 RVA: 0x000FED0C File Offset: 0x000FCF0C
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt32(ref newArray, ref num, this.Level);
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

		// Token: 0x06002DA2 RID: 11682 RVA: 0x000FED6C File Offset: 0x000FCF6C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Level = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002DA3 RID: 11683 RVA: 0x000182E3 File Offset: 0x000164E3
		private void InitRefTypes()
		{
			this.Level = 0u;
		}
	}
}
