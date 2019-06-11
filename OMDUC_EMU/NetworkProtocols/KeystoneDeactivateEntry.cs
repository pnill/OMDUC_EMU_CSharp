using System;

namespace NetworkProtocols
{
	// Token: 0x020004F8 RID: 1272
	public class KeystoneDeactivateEntry : BaseAwardEntry
	{
		// Token: 0x06002C46 RID: 11334 RVA: 0x000177E2 File Offset: 0x000159E2
		public KeystoneDeactivateEntry()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1599513057u;
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06002C47 RID: 11335 RVA: 0x000177FB File Offset: 0x000159FB
		// (set) Token: 0x06002C48 RID: 11336 RVA: 0x00017803 File Offset: 0x00015A03
		public ulong KeystoneDetailID { get; set; }

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06002C49 RID: 11337 RVA: 0x0001780C File Offset: 0x00015A0C
		// (set) Token: 0x06002C4A RID: 11338 RVA: 0x00017814 File Offset: 0x00015A14
		public ulong RunningScore { get; set; }

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06002C4B RID: 11339 RVA: 0x0001781D File Offset: 0x00015A1D
		// (set) Token: 0x06002C4C RID: 11340 RVA: 0x00017825 File Offset: 0x00015A25
		public int LivesStarting { get; set; }

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06002C4D RID: 11341 RVA: 0x0001782E File Offset: 0x00015A2E
		// (set) Token: 0x06002C4E RID: 11342 RVA: 0x00017836 File Offset: 0x00015A36
		public int LivesRemaining { get; set; }

		// Token: 0x06002C4F RID: 11343 RVA: 0x000FDB64 File Offset: 0x000FBD64
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.KeystoneDetailID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.RunningScore);
			ArrayManager.WriteInt32(ref newArray, ref num, this.LivesStarting);
			ArrayManager.WriteInt32(ref newArray, ref num, this.LivesRemaining);
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

		// Token: 0x06002C50 RID: 11344 RVA: 0x000FDBF0 File Offset: 0x000FBDF0
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.KeystoneDetailID = ArrayManager.ReadUInt64(data, ref num);
			this.RunningScore = ArrayManager.ReadUInt64(data, ref num);
			this.LivesStarting = ArrayManager.ReadInt32(data, ref num);
			this.LivesRemaining = ArrayManager.ReadInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002C51 RID: 11345 RVA: 0x0001783F File Offset: 0x00015A3F
		private void InitRefTypes()
		{
			this.KeystoneDetailID = 0UL;
			this.RunningScore = 0UL;
			this.LivesStarting = 0;
			this.LivesRemaining = 0;
		}
	}
}
