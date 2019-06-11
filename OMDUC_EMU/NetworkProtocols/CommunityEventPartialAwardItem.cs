using System;

namespace NetworkProtocols
{
	// Token: 0x02000566 RID: 1382
	public class CommunityEventPartialAwardItem : BaseAwardItem
	{
		// Token: 0x06002F10 RID: 12048 RVA: 0x00018FB6 File Offset: 0x000171B6
		public CommunityEventPartialAwardItem()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1605572915u;
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06002F11 RID: 12049 RVA: 0x00018FCF File Offset: 0x000171CF
		// (set) Token: 0x06002F12 RID: 12050 RVA: 0x00018FD7 File Offset: 0x000171D7
		public ulong AccountSUID { get; set; }

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06002F13 RID: 12051 RVA: 0x00018FE0 File Offset: 0x000171E0
		// (set) Token: 0x06002F14 RID: 12052 RVA: 0x00018FE8 File Offset: 0x000171E8
		public ulong EventID { get; set; }

		// Token: 0x06002F15 RID: 12053 RVA: 0x00100894 File Offset: 0x000FEA94
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.AccountSUID);
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

		// Token: 0x06002F16 RID: 12054 RVA: 0x00100904 File Offset: 0x000FEB04
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.AccountSUID = ArrayManager.ReadUInt64(data, ref num);
			this.EventID = ArrayManager.ReadUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002F17 RID: 12055 RVA: 0x00018FF1 File Offset: 0x000171F1
		private void InitRefTypes()
		{
			this.AccountSUID = 0UL;
			this.EventID = 0UL;
		}
	}
}
