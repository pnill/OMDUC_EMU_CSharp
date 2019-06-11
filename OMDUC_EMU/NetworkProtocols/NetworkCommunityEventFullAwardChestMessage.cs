using System;

namespace NetworkProtocols
{
	// Token: 0x0200063A RID: 1594
	public class NetworkCommunityEventFullAwardChestMessage : NetworkPlayerMessage
	{
		// Token: 0x06003775 RID: 14197 RVA: 0x0001E68B File Offset: 0x0001C88B
		public NetworkCommunityEventFullAwardChestMessage()
		{
			this.InitRefTypes();
			this.UniqueClassID = 595827123u;
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x06003776 RID: 14198 RVA: 0x0001E6A4 File Offset: 0x0001C8A4
		// (set) Token: 0x06003777 RID: 14199 RVA: 0x0001E6AC File Offset: 0x0001C8AC
		public ulong EventID { get; set; }

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06003778 RID: 14200 RVA: 0x0001E6B5 File Offset: 0x0001C8B5
		// (set) Token: 0x06003779 RID: 14201 RVA: 0x0001E6BD File Offset: 0x0001C8BD
		public ulong EventChestID { get; set; }

		// Token: 0x0600377A RID: 14202 RVA: 0x0010C7F4 File Offset: 0x0010A9F4
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

		// Token: 0x0600377B RID: 14203 RVA: 0x0010C864 File Offset: 0x0010AA64
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.EventID = ArrayManager.ReadUInt64(data, ref num);
			this.EventChestID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x0600377C RID: 14204 RVA: 0x0001E6C6 File Offset: 0x0001C8C6
		private void InitRefTypes()
		{
			this.EventID = 0UL;
			this.EventChestID = 0UL;
		}
	}
}
