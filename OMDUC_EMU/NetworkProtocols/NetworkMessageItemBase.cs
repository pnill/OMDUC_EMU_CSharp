using System;

namespace NetworkProtocols
{
	// Token: 0x02000627 RID: 1575
	public class NetworkMessageItemBase
	{
		// Token: 0x060036DD RID: 14045 RVA: 0x0001E0E6 File Offset: 0x0001C2E6
		public NetworkMessageItemBase()
		{
			this.InitRefTypes();
		}

		// Token: 0x060036DE RID: 14046 RVA: 0x0010BA80 File Offset: 0x00109C80
		public virtual byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060036DF RID: 14047 RVA: 0x00006297 File Offset: 0x00004497
		public virtual void DeserializeMessage(byte[] data)
		{
		}

		// Token: 0x060036E0 RID: 14048 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}

		// Token: 0x04001DA8 RID: 7592
		public uint UniqueClassID;
	}
}
