using System;

namespace NetworkProtocols
{
	// Token: 0x02000780 RID: 1920
	public class ChangeMOTDLogEntryForNetwork : GuildLogEntryForNetwork
	{
		// Token: 0x060043F8 RID: 17400 RVA: 0x0002727D File Offset: 0x0002547D
		public ChangeMOTDLogEntryForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2341844887u;
		}

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x060043F9 RID: 17401 RVA: 0x00027296 File Offset: 0x00025496
		// (set) Token: 0x060043FA RID: 17402 RVA: 0x0002729E File Offset: 0x0002549E
		public string MOTD { get; set; }

		// Token: 0x060043FB RID: 17403 RVA: 0x00122B2C File Offset: 0x00120D2C
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteString(ref newArray, ref num, this.MOTD);
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

		// Token: 0x060043FC RID: 17404 RVA: 0x00122B8C File Offset: 0x00120D8C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.MOTD = ArrayManager.ReadString(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x060043FD RID: 17405 RVA: 0x000272A7 File Offset: 0x000254A7
		private void InitRefTypes()
		{
			this.MOTD = string.Empty;
		}
	}
}
