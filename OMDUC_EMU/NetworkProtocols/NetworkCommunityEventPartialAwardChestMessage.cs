using System;

namespace NetworkProtocols
{
	// Token: 0x02000638 RID: 1592
	public class NetworkCommunityEventPartialAwardChestMessage : NetworkPlayerMessage
	{
		// Token: 0x06003767 RID: 14183 RVA: 0x0001E60A File Offset: 0x0001C80A
		public NetworkCommunityEventPartialAwardChestMessage()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3699086199u;
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x06003768 RID: 14184 RVA: 0x0001E623 File Offset: 0x0001C823
		// (set) Token: 0x06003769 RID: 14185 RVA: 0x0001E62B File Offset: 0x0001C82B
		public ulong EventID { get; set; }

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x0600376A RID: 14186 RVA: 0x0001E634 File Offset: 0x0001C834
		// (set) Token: 0x0600376B RID: 14187 RVA: 0x0001E63C File Offset: 0x0001C83C
		public ulong EventChestID { get; set; }

		// Token: 0x0600376C RID: 14188 RVA: 0x0010C69C File Offset: 0x0010A89C
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.EventID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.EventChestID);
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

		// Token: 0x0600376D RID: 14189 RVA: 0x0010C70C File Offset: 0x0010A90C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.EventID = ArrayManager.ReadUInt64(data, ref num);
			this.EventChestID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x0600376E RID: 14190 RVA: 0x0001E645 File Offset: 0x0001C845
		private void InitRefTypes()
		{
			this.EventID = 0UL;
			this.EventChestID = 0UL;
		}
	}
}
