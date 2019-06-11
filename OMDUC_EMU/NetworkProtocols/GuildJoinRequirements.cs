using System;

namespace NetworkProtocols
{
	// Token: 0x02000757 RID: 1879
	public class GuildJoinRequirements
	{
		// Token: 0x060042C3 RID: 17091 RVA: 0x000264F6 File Offset: 0x000246F6
		public GuildJoinRequirements()
		{
			this.InitRefTypes();
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x060042C4 RID: 17092 RVA: 0x00026504 File Offset: 0x00024704
		// (set) Token: 0x060042C5 RID: 17093 RVA: 0x0002650C File Offset: 0x0002470C
		public uint MinimumLevel { get; set; }

		// Token: 0x060042C6 RID: 17094 RVA: 0x00120DE0 File Offset: 0x0011EFE0
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.MinimumLevel);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060042C7 RID: 17095 RVA: 0x00120E10 File Offset: 0x0011F010
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.MinimumLevel = ArrayManager.ReadUInt32(data, ref num);
		}

		// Token: 0x060042C8 RID: 17096 RVA: 0x00026515 File Offset: 0x00024715
		private void InitRefTypes()
		{
			this.MinimumLevel = 0u;
		}
	}
}
