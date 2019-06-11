using System;

namespace NetworkProtocols
{
	// Token: 0x0200077C RID: 1916
	public class DemoteMemberLogEntryForNetwork : GuildLogEntryForNetwork
	{
		// Token: 0x060043E6 RID: 17382 RVA: 0x000271FB File Offset: 0x000253FB
		public DemoteMemberLogEntryForNetwork()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2449400184u;
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x060043E7 RID: 17383 RVA: 0x00027214 File Offset: 0x00025414
		// (set) Token: 0x060043E8 RID: 17384 RVA: 0x0002721C File Offset: 0x0002541C
		public string Rank { get; set; }

		// Token: 0x060043E9 RID: 17385 RVA: 0x00122A90 File Offset: 0x00120C90
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

		// Token: 0x060043EA RID: 17386 RVA: 0x00122AF0 File Offset: 0x00120CF0
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.Rank = ArrayManager.ReadString(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x060043EB RID: 17387 RVA: 0x00027225 File Offset: 0x00025425
		private void InitRefTypes()
		{
			this.Rank = string.Empty;
		}
	}
}
