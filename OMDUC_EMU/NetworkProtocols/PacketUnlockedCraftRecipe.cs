using System;

namespace NetworkProtocols
{
	// Token: 0x020005A8 RID: 1448
	public class PacketUnlockedCraftRecipe
	{
		// Token: 0x06003266 RID: 12902 RVA: 0x0001B1C7 File Offset: 0x000193C7
		public PacketUnlockedCraftRecipe()
		{
			this.InitRefTypes();
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06003267 RID: 12903 RVA: 0x0001B1D5 File Offset: 0x000193D5
		// (set) Token: 0x06003268 RID: 12904 RVA: 0x0001B1DD File Offset: 0x000193DD
		public ulong CraftRecipeGUID { get; set; }

		// Token: 0x06003269 RID: 12905 RVA: 0x001051AC File Offset: 0x001033AC
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.CraftRecipeGUID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600326A RID: 12906 RVA: 0x001051DC File Offset: 0x001033DC
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.CraftRecipeGUID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x0600326B RID: 12907 RVA: 0x0001B1E6 File Offset: 0x000193E6
		private void InitRefTypes()
		{
			this.CraftRecipeGUID = 0UL;
		}
	}
}
