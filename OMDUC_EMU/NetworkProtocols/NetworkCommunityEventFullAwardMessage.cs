using System;

namespace NetworkProtocols
{
	// Token: 0x02000639 RID: 1593
	public class NetworkCommunityEventFullAwardMessage : NetworkPlayerMessage
	{
		// Token: 0x0600376F RID: 14191 RVA: 0x0001E657 File Offset: 0x0001C857
		public NetworkCommunityEventFullAwardMessage()
		{
			this.InitRefTypes();
			this.UniqueClassID = 586908671u;
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x06003770 RID: 14192 RVA: 0x0001E670 File Offset: 0x0001C870
		// (set) Token: 0x06003771 RID: 14193 RVA: 0x0001E678 File Offset: 0x0001C878
		public ulong EventID { get; set; }

		// Token: 0x06003772 RID: 14194 RVA: 0x0010C758 File Offset: 0x0010A958
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

		// Token: 0x06003773 RID: 14195 RVA: 0x0010C7B8 File Offset: 0x0010A9B8
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.EventID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06003774 RID: 14196 RVA: 0x0001E681 File Offset: 0x0001C881
		private void InitRefTypes()
		{
			this.EventID = 0UL;
		}
	}
}
