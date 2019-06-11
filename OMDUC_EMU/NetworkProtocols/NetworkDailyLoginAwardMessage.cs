using System;

namespace NetworkProtocols
{
	// Token: 0x0200062D RID: 1581
	public class NetworkDailyLoginAwardMessage : NetworkPlayerMessage
	{
		// Token: 0x06003707 RID: 14087 RVA: 0x0001E25B File Offset: 0x0001C45B
		public NetworkDailyLoginAwardMessage()
		{
			this.InitRefTypes();
			this.UniqueClassID = 3151405179u;
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06003708 RID: 14088 RVA: 0x0001E274 File Offset: 0x0001C474
		// (set) Token: 0x06003709 RID: 14089 RVA: 0x0001E27C File Offset: 0x0001C47C
		public uint Day { get; set; }

		// Token: 0x0600370A RID: 14090 RVA: 0x0010BE28 File Offset: 0x0010A028
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt32(ref newArray, ref num, this.Day);
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

		// Token: 0x0600370B RID: 14091 RVA: 0x0010BE88 File Offset: 0x0010A088
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Day = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x0600370C RID: 14092 RVA: 0x0001E285 File Offset: 0x0001C485
		private void InitRefTypes()
		{
			this.Day = 0u;
		}
	}
}
