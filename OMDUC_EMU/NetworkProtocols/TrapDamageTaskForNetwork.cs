using System;

namespace NetworkProtocols
{
	// Token: 0x020005DB RID: 1499
	public class TrapDamageTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x06003433 RID: 13363 RVA: 0x0001C3BB File Offset: 0x0001A5BB
		public TrapDamageTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2523640248u;
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06003434 RID: 13364 RVA: 0x0001C3D4 File Offset: 0x0001A5D4
		// (set) Token: 0x06003435 RID: 13365 RVA: 0x0001C3DC File Offset: 0x0001A5DC
		public uint Denominator { get; set; }

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06003436 RID: 13366 RVA: 0x0001C3E5 File Offset: 0x0001A5E5
		// (set) Token: 0x06003437 RID: 13367 RVA: 0x0001C3ED File Offset: 0x0001A5ED
		public uint Numerator { get; set; }

		// Token: 0x06003438 RID: 13368 RVA: 0x00107778 File Offset: 0x00105978
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt32(ref newArray, ref num, this.Denominator);
			ArrayManager.WriteUInt32(ref newArray, ref num, this.Numerator);
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

		// Token: 0x06003439 RID: 13369 RVA: 0x001077E8 File Offset: 0x001059E8
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x0600343A RID: 13370 RVA: 0x0001C3F6 File Offset: 0x0001A5F6
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
