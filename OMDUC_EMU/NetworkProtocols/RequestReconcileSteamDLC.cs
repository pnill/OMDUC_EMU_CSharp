using System;

namespace NetworkProtocols
{
	// Token: 0x0200060F RID: 1551
	public class RequestReconcileSteamDLC : BotNetMessage
	{
		// Token: 0x06003625 RID: 13861 RVA: 0x0001D7DB File Offset: 0x0001B9DB
		public RequestReconcileSteamDLC()
		{
			this.InitRefTypes();
			base.PacketType = 3222202674u;
		}

		// Token: 0x06003626 RID: 13862 RVA: 0x0001D7F4 File Offset: 0x0001B9F4
		public RequestReconcileSteamDLC(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3222202674u;
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06003627 RID: 13863 RVA: 0x0001D814 File Offset: 0x0001BA14
		// (set) Token: 0x06003628 RID: 13864 RVA: 0x0001D81C File Offset: 0x0001BA1C
		public ulong SteamID { get; set; }

		// Token: 0x06003629 RID: 13865 RVA: 0x0010A690 File Offset: 0x00108890
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt32(ref newArray, ref newSize, base.PacketType);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, base.SessionToken);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, base.SecurityToken);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, base.RequestID);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, 0u);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, 0u);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.SteamID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600362A RID: 13866 RVA: 0x0010A710 File Offset: 0x00108910
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.SteamID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x0600362B RID: 13867 RVA: 0x0001D825 File Offset: 0x0001BA25
		private void InitRefTypes()
		{
			this.SteamID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001D70 RID: 7536
		public const uint cPacketType = 3222202674u;
	}
}
