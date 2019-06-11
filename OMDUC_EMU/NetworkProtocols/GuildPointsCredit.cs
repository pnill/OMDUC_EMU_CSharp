using System;

namespace NetworkProtocols
{
	// Token: 0x02000521 RID: 1313
	public class GuildPointsCredit : BaseAwardEntry
	{
		// Token: 0x06002D46 RID: 11590 RVA: 0x0001807E File Offset: 0x0001627E
		public GuildPointsCredit()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1411098756u;
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06002D47 RID: 11591 RVA: 0x00018097 File Offset: 0x00016297
		// (set) Token: 0x06002D48 RID: 11592 RVA: 0x0001809F File Offset: 0x0001629F
		public ulong GuildID { get; set; }

		// Token: 0x06002D49 RID: 11593 RVA: 0x000FEBA0 File Offset: 0x000FCDA0
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.GuildID);
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

		// Token: 0x06002D4A RID: 11594 RVA: 0x000FEC00 File Offset: 0x000FCE00
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.GuildID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002D4B RID: 11595 RVA: 0x000180A8 File Offset: 0x000162A8
		private void InitRefTypes()
		{
			this.GuildID = 0UL;
		}
	}
}
