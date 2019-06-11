using System;

namespace NetworkProtocols
{
	// Token: 0x0200051E RID: 1310
	public class GameCodeRedemptionEntry : BaseAwardEntry
	{
		// Token: 0x06002D36 RID: 11574 RVA: 0x00017FFD File Offset: 0x000161FD
		public GameCodeRedemptionEntry()
		{
			this.InitRefTypes();
			this.UniqueClassID = 465170201u;
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06002D37 RID: 11575 RVA: 0x00018016 File Offset: 0x00016216
		// (set) Token: 0x06002D38 RID: 11576 RVA: 0x0001801E File Offset: 0x0001621E
		public ulong GameCodeID { get; set; }

		// Token: 0x06002D39 RID: 11577 RVA: 0x000FEA68 File Offset: 0x000FCC68
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.GameCodeID);
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

		// Token: 0x06002D3A RID: 11578 RVA: 0x000FEAC8 File Offset: 0x000FCCC8
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.GameCodeID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002D3B RID: 11579 RVA: 0x00018027 File Offset: 0x00016227
		private void InitRefTypes()
		{
			this.GameCodeID = 0UL;
		}
	}
}
