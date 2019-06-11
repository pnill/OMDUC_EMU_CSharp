using System;

namespace NetworkProtocols
{
	// Token: 0x02000555 RID: 1365
	public class LevelUnlockAward : BaseAwardItem
	{
		// Token: 0x06002E84 RID: 11908 RVA: 0x00018A72 File Offset: 0x00016C72
		public LevelUnlockAward()
		{
			this.InitRefTypes();
			this.UniqueClassID = 419036965u;
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06002E85 RID: 11909 RVA: 0x00018A8B File Offset: 0x00016C8B
		// (set) Token: 0x06002E86 RID: 11910 RVA: 0x00018A93 File Offset: 0x00016C93
		public uint Level { get; set; }

		// Token: 0x06002E87 RID: 11911 RVA: 0x000FFDF8 File Offset: 0x000FDFF8
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

		// Token: 0x06002E88 RID: 11912 RVA: 0x000FFE58 File Offset: 0x000FE058
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Level = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002E89 RID: 11913 RVA: 0x00018A9C File Offset: 0x00016C9C
		private void InitRefTypes()
		{
			this.Level = 0u;
		}
	}
}
