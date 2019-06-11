using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x0200066B RID: 1643
	public class PushPlayerCommunityEventsListForNetwork : BotNetMessage
	{
		// Token: 0x060039A2 RID: 14754 RVA: 0x0001FD66 File Offset: 0x0001DF66
		public PushPlayerCommunityEventsListForNetwork()
		{
			this.InitRefTypes();
			base.PacketType = 2464273229u;
		}

		// Token: 0x060039A3 RID: 14755 RVA: 0x0001FD7F File Offset: 0x0001DF7F
		public PushPlayerCommunityEventsListForNetwork(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2464273229u;
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x060039A4 RID: 14756 RVA: 0x0001FD9F File Offset: 0x0001DF9F
		// (set) Token: 0x060039A5 RID: 14757 RVA: 0x0001FDA7 File Offset: 0x0001DFA7
		public List<PlayerCommunityEventsForNetwork> EventsInPreStartStage { get; set; }

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x060039A6 RID: 14758 RVA: 0x0001FDB0 File Offset: 0x0001DFB0
		// (set) Token: 0x060039A7 RID: 14759 RVA: 0x0001FDB8 File Offset: 0x0001DFB8
		public List<PlayerCommunityEventsForNetwork> EventsInRunningStage { get; set; }

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x060039A8 RID: 14760 RVA: 0x0001FDC1 File Offset: 0x0001DFC1
		// (set) Token: 0x060039A9 RID: 14761 RVA: 0x0001FDC9 File Offset: 0x0001DFC9
		public List<PlayerCommunityEventsForNetwork> EventsInPostEndStage { get; set; }

		// Token: 0x060039AA RID: 14762 RVA: 0x0010FA5C File Offset: 0x0010DC5C
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
			ArrayManager.WriteListPlayerCommunityEventsForNetwork(ref newArray, ref newSize, this.EventsInPreStartStage);
			ArrayManager.WriteListPlayerCommunityEventsForNetwork(ref newArray, ref newSize, this.EventsInRunningStage);
			ArrayManager.WriteListPlayerCommunityEventsForNetwork(ref newArray, ref newSize, this.EventsInPostEndStage);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x060039AB RID: 14763 RVA: 0x0010FAF8 File Offset: 0x0010DCF8
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.EventsInPreStartStage = ArrayManager.ReadListPlayerCommunityEventsForNetwork(data, ref num);
			this.EventsInRunningStage = ArrayManager.ReadListPlayerCommunityEventsForNetwork(data, ref num);
			this.EventsInPostEndStage = ArrayManager.ReadListPlayerCommunityEventsForNetwork(data, ref num);
		}

		// Token: 0x060039AC RID: 14764 RVA: 0x0001FDD2 File Offset: 0x0001DFD2
		private void InitRefTypes()
		{
			this.EventsInPreStartStage = new List<PlayerCommunityEventsForNetwork>();
			this.EventsInRunningStage = new List<PlayerCommunityEventsForNetwork>();
			this.EventsInPostEndStage = new List<PlayerCommunityEventsForNetwork>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001E94 RID: 7828
		public const uint cPacketType = 2464273229u;
	}
}
