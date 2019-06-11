using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x0200049F RID: 1183
	public class PlayerCommunityEventsUpdatePush : BotNetMessage
	{
		// Token: 0x06002A71 RID: 10865 RVA: 0x00016375 File Offset: 0x00014575
		public PlayerCommunityEventsUpdatePush()
		{
			this.InitRefTypes();
			base.PacketType = 2937563507u;
		}

		// Token: 0x06002A72 RID: 10866 RVA: 0x0001638E File Offset: 0x0001458E
		public PlayerCommunityEventsUpdatePush(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 2937563507u;
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06002A73 RID: 10867 RVA: 0x000163AE File Offset: 0x000145AE
		// (set) Token: 0x06002A74 RID: 10868 RVA: 0x000163B6 File Offset: 0x000145B6
		public List<PlayerCommunityEventUpdateInfo> EventGoals { get; set; }

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06002A75 RID: 10869 RVA: 0x000163BF File Offset: 0x000145BF
		// (set) Token: 0x06002A76 RID: 10870 RVA: 0x000163C7 File Offset: 0x000145C7
		public List<CommunityContributionForEvent> CommunityContributionForEvents { get; set; }

		// Token: 0x06002A77 RID: 10871 RVA: 0x000FB5CC File Offset: 0x000F97CC
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
			ArrayManager.WriteListPlayerCommunityEventUpdateInfo(ref newArray, ref newSize, this.EventGoals);
			ArrayManager.WriteListCommunityContributionForEvent(ref newArray, ref newSize, this.CommunityContributionForEvents);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06002A78 RID: 10872 RVA: 0x000FB658 File Offset: 0x000F9858
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.EventGoals = ArrayManager.ReadListPlayerCommunityEventUpdateInfo(data, ref num);
			this.CommunityContributionForEvents = ArrayManager.ReadListCommunityContributionForEvent(data, ref num);
		}

		// Token: 0x06002A79 RID: 10873 RVA: 0x000163D0 File Offset: 0x000145D0
		private void InitRefTypes()
		{
			this.EventGoals = new List<PlayerCommunityEventUpdateInfo>();
			this.CommunityContributionForEvents = new List<CommunityContributionForEvent>();
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001771 RID: 6001
		public const uint cPacketType = 2937563507u;
	}
}
