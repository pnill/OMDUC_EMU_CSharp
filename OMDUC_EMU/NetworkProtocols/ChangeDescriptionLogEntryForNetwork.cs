using System;

namespace NetworkProtocols
{
	// Token: 0x02000781 RID: 1921
	public class ChangeDescriptionLogEntryForNetwork : GuildLogEntryForNetwork
	{
		// Token: 0x060043FE RID: 17406 RVA: 0x000272B4 File Offset: 0x000254B4
		public ChangeDescriptionLogEntryForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 320400704u;
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x060043FF RID: 17407 RVA: 0x000272CD File Offset: 0x000254CD
		// (set) Token: 0x06004400 RID: 17408 RVA: 0x000272D5 File Offset: 0x000254D5
		public string Description { get; set; }

		// Token: 0x06004401 RID: 17409 RVA: 0x00122BC8 File Offset: 0x00120DC8
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteString(ref newArray, ref num, this.Description);
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

		// Token: 0x06004402 RID: 17410 RVA: 0x00122C28 File Offset: 0x00120E28
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Description = ArrayManager.ReadString(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06004403 RID: 17411 RVA: 0x000272DE File Offset: 0x000254DE
		private void InitRefTypes()
		{
			this.Description = string.Empty;
		}
	}
}
