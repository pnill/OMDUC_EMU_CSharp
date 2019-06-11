using System;

namespace NetworkProtocols
{
	// Token: 0x0200062B RID: 1579
	public class NetworkReferralAwardMessage : NetworkPlayerMessage
	{
		// Token: 0x060036F5 RID: 14069 RVA: 0x0001E1A7 File Offset: 0x0001C3A7
		public NetworkReferralAwardMessage()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2351393697u;
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x060036F6 RID: 14070 RVA: 0x0001E1C0 File Offset: 0x0001C3C0
		// (set) Token: 0x060036F7 RID: 14071 RVA: 0x0001E1C8 File Offset: 0x0001C3C8
		public string ReferralName { get; set; }

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x060036F8 RID: 14072 RVA: 0x0001E1D1 File Offset: 0x0001C3D1
		// (set) Token: 0x060036F9 RID: 14073 RVA: 0x0001E1D9 File Offset: 0x0001C3D9
		public eReferralRewardEventType EventType { get; set; }

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x060036FA RID: 14074 RVA: 0x0001E1E2 File Offset: 0x0001C3E2
		// (set) Token: 0x060036FB RID: 14075 RVA: 0x0001E1EA File Offset: 0x0001C3EA
		public uint EventCount { get; set; }

		// Token: 0x060036FC RID: 14076 RVA: 0x0010BC94 File Offset: 0x00109E94
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteString(ref newArray, ref num, this.ReferralName);
			ArrayManager.WriteeReferralRewardEventType(ref newArray, ref num, this.EventType);
			ArrayManager.WriteUInt32(ref newArray, ref num, this.EventCount);
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

		// Token: 0x060036FD RID: 14077 RVA: 0x0010BD14 File Offset: 0x00109F14
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.ReferralName = ArrayManager.ReadString(data, ref num);
			this.EventType = ArrayManager.ReadeReferralRewardEventType(data, ref num);
			this.EventCount = ArrayManager.ReadUInt32(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x060036FE RID: 14078 RVA: 0x0001E1F3 File Offset: 0x0001C3F3
		private void InitRefTypes()
		{
			this.ReferralName = string.Empty;
			this.EventType = eReferralRewardEventType.None;
			this.EventCount = 0u;
		}
	}
}
