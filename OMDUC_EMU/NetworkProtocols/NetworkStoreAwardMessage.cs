using System;

namespace NetworkProtocols
{
	// Token: 0x02000631 RID: 1585
	public class NetworkStoreAwardMessage : NetworkPlayerMessage
	{
		// Token: 0x06003729 RID: 14121 RVA: 0x0001E3A5 File Offset: 0x0001C5A5
		public NetworkStoreAwardMessage()
		{
			this.InitRefTypes();
			this.UniqueClassID = 4172187887u;
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x0600372A RID: 14122 RVA: 0x0001E3BE File Offset: 0x0001C5BE
		// (set) Token: 0x0600372B RID: 14123 RVA: 0x0001E3C6 File Offset: 0x0001C5C6
		public ulong OfferID { get; set; }

		// Token: 0x0600372C RID: 14124 RVA: 0x0010C12C File Offset: 0x0010A32C
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.OfferID);
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

		// Token: 0x0600372D RID: 14125 RVA: 0x0010C18C File Offset: 0x0010A38C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.OfferID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x0600372E RID: 14126 RVA: 0x0001E3CF File Offset: 0x0001C5CF
		private void InitRefTypes()
		{
			this.OfferID = 0UL;
		}
	}
}
