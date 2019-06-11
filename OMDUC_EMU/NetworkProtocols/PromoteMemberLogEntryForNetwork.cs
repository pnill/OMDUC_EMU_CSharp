using System;

namespace NetworkProtocols
{
	// Token: 0x0200077B RID: 1915
	public class PromoteMemberLogEntryForNetwork : GuildLogEntryForNetwork
	{
		// Token: 0x060043E0 RID: 17376 RVA: 0x000271C4 File Offset: 0x000253C4
		public PromoteMemberLogEntryForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 1764802419u;
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x060043E1 RID: 17377 RVA: 0x000271DD File Offset: 0x000253DD
		// (set) Token: 0x060043E2 RID: 17378 RVA: 0x000271E5 File Offset: 0x000253E5
		public string Rank { get; set; }

		// Token: 0x060043E3 RID: 17379 RVA: 0x001229F4 File Offset: 0x00120BF4
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteString(ref newArray, ref num, this.Rank);
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

		// Token: 0x060043E4 RID: 17380 RVA: 0x00122A54 File Offset: 0x00120C54
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Rank = ArrayManager.ReadString(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x060043E5 RID: 17381 RVA: 0x000271EE File Offset: 0x000253EE
		private void InitRefTypes()
		{
			this.Rank = string.Empty;
		}
	}
}
