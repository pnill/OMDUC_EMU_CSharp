using System;

namespace NetworkProtocols
{
	// Token: 0x02000630 RID: 1584
	public class NetworkAchievementAwardMessage : NetworkPlayerMessage
	{
		// Token: 0x06003723 RID: 14115 RVA: 0x0001E371 File Offset: 0x0001C571
		public NetworkAchievementAwardMessage()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2400567095u;
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06003724 RID: 14116 RVA: 0x0001E38A File Offset: 0x0001C58A
		// (set) Token: 0x06003725 RID: 14117 RVA: 0x0001E392 File Offset: 0x0001C592
		public ulong AchievementGUID { get; set; }

		// Token: 0x06003726 RID: 14118 RVA: 0x0010C090 File Offset: 0x0010A290
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.AchievementGUID);
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

		// Token: 0x06003727 RID: 14119 RVA: 0x0010C0F0 File Offset: 0x0010A2F0
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.AchievementGUID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06003728 RID: 14120 RVA: 0x0001E39B File Offset: 0x0001C59B
		private void InitRefTypes()
		{
			this.AchievementGUID = 0UL;
		}
	}
}
