using System;

namespace NetworkProtocols
{
	// Token: 0x02000636 RID: 1590
	public class NetworkCommunityEventGoalAwardChestMessage : NetworkPlayerMessage
	{
		// Token: 0x06003757 RID: 14167 RVA: 0x0001E570 File Offset: 0x0001C770
		public NetworkCommunityEventGoalAwardChestMessage()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1017217289u;
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x06003758 RID: 14168 RVA: 0x0001E589 File Offset: 0x0001C789
		// (set) Token: 0x06003759 RID: 14169 RVA: 0x0001E591 File Offset: 0x0001C791
		public ulong EventID { get; set; }

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x0600375A RID: 14170 RVA: 0x0001E59A File Offset: 0x0001C79A
		// (set) Token: 0x0600375B RID: 14171 RVA: 0x0001E5A2 File Offset: 0x0001C7A2
		public ulong GoalID { get; set; }

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x0600375C RID: 14172 RVA: 0x0001E5AB File Offset: 0x0001C7AB
		// (set) Token: 0x0600375D RID: 14173 RVA: 0x0001E5B3 File Offset: 0x0001C7B3
		public ulong EventChestID { get; set; }

		// Token: 0x0600375E RID: 14174 RVA: 0x0010C528 File Offset: 0x0010A728
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.EventID);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.GoalID);
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

		// Token: 0x0600375F RID: 14175 RVA: 0x0010C5A8 File Offset: 0x0010A7A8
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.EventID = ArrayManager.ReadUInt64(data, ref num);
			this.GoalID = ArrayManager.ReadUInt64(data, ref num);
			this.EventChestID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06003760 RID: 14176 RVA: 0x0001E5BC File Offset: 0x0001C7BC
		private void InitRefTypes()
		{
			this.EventID = 0UL;
			this.GoalID = 0UL;
			this.EventChestID = 0UL;
		}
	}
}
