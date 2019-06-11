using System;

namespace NetworkProtocols
{
	// Token: 0x02000637 RID: 1591
	public class NetworkCommunityEventPartialAwardMessage : NetworkPlayerMessage
	{
		// Token: 0x06003761 RID: 14177 RVA: 0x0001E5D6 File Offset: 0x0001C7D6
		public NetworkCommunityEventPartialAwardMessage()
		{
			this.InitRefTypes();
			this.UniqueClassID = 4017048851u;
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x06003762 RID: 14178 RVA: 0x0001E5EF File Offset: 0x0001C7EF
		// (set) Token: 0x06003763 RID: 14179 RVA: 0x0001E5F7 File Offset: 0x0001C7F7
		public ulong EventID { get; set; }

		// Token: 0x06003764 RID: 14180 RVA: 0x0010C600 File Offset: 0x0010A800
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.EventID);
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

		// Token: 0x06003765 RID: 14181 RVA: 0x0010C660 File Offset: 0x0010A860
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.EventID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06003766 RID: 14182 RVA: 0x0001E600 File Offset: 0x0001C800
		private void InitRefTypes()
		{
			this.EventID = 0UL;
		}
	}
}
