using System;

namespace NetworkProtocols
{
	// Token: 0x020006C8 RID: 1736
	public class ResponseSubscribeToLobbyList : BotNetMessage
	{
		// Token: 0x06003E44 RID: 15940 RVA: 0x00022FC5 File Offset: 0x000211C5
		public ResponseSubscribeToLobbyList()
		{
			this.InitRefTypes();
			base.PacketType = 1398724449u;
		}

		// Token: 0x06003E45 RID: 15941 RVA: 0x00022FDE File Offset: 0x000211DE
		public ResponseSubscribeToLobbyList(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1398724449u;
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x06003E46 RID: 15942 RVA: 0x00022FFE File Offset: 0x000211FE
		// (set) Token: 0x06003E47 RID: 15943 RVA: 0x00023006 File Offset: 0x00021206
		public eLobbyRequestResult Status { get; set; }

		// Token: 0x06003E48 RID: 15944 RVA: 0x00116700 File Offset: 0x00114900
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
			ArrayManager.WriteeLobbyRequestResult(ref newArray, ref newSize, this.Status);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003E49 RID: 15945 RVA: 0x00116780 File Offset: 0x00114980
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.Status = ArrayManager.ReadeLobbyRequestResult(data, ref num);
		}

		// Token: 0x06003E4A RID: 15946 RVA: 0x0002300F File Offset: 0x0002120F
		private void InitRefTypes()
		{
			this.Status = eLobbyRequestResult.LobbyRequest_Succeeded;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x040020B0 RID: 8368
		public const uint cPacketType = 1398724449u;
	}
}
