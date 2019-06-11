using System;

namespace NetworkProtocols
{
	// Token: 0x020005E8 RID: 1512
	public class KillPlayersOrAssistsTaskForNetwork : QuestTaskForNetwork
	{
		// Token: 0x0600349B RID: 13467 RVA: 0x0001C78A File Offset: 0x0001A98A
		public KillPlayersOrAssistsTaskForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1364594490u;
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x0600349C RID: 13468 RVA: 0x0001C7A3 File Offset: 0x0001A9A3
		// (set) Token: 0x0600349D RID: 13469 RVA: 0x0001C7AB File Offset: 0x0001A9AB
		public uint Denominator { get; set; }

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x0600349E RID: 13470 RVA: 0x0001C7B4 File Offset: 0x0001A9B4
		// (set) Token: 0x0600349F RID: 13471 RVA: 0x0001C7BC File Offset: 0x0001A9BC
		public uint Numerator { get; set; }

		// Token: 0x060034A0 RID: 13472 RVA: 0x00108104 File Offset: 0x00106304
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

		// Token: 0x060034A1 RID: 13473 RVA: 0x00108174 File Offset: 0x00106374
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Denominator = ArrayManager.ReadUInt32(data, ref num);
			this.Numerator = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x060034A2 RID: 13474 RVA: 0x0001C7C5 File Offset: 0x0001A9C5
		private void InitRefTypes()
		{
			this.Denominator = 0u;
			this.Numerator = 0u;
		}
	}
}
