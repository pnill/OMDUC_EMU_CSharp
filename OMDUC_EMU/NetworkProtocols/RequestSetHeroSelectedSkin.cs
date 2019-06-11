using System;

namespace NetworkProtocols
{
	// Token: 0x02000579 RID: 1401
	public class RequestSetHeroSelectedSkin : BotNetMessage
	{
		// Token: 0x0600302B RID: 12331 RVA: 0x000199F8 File Offset: 0x00017BF8
		public RequestSetHeroSelectedSkin()
		{
			this.InitRefTypes();
			base.PacketType = 1086350166u;
		}

		// Token: 0x0600302C RID: 12332 RVA: 0x00019A11 File Offset: 0x00017C11
		public RequestSetHeroSelectedSkin(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 1086350166u;
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x0600302D RID: 12333 RVA: 0x00019A31 File Offset: 0x00017C31
		// (set) Token: 0x0600302E RID: 12334 RVA: 0x00019A39 File Offset: 0x00017C39
		public ulong HeroCardGUID { get; set; }

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x0600302F RID: 12335 RVA: 0x00019A42 File Offset: 0x00017C42
		// (set) Token: 0x06003030 RID: 12336 RVA: 0x00019A4A File Offset: 0x00017C4A
		public ulong SelectedSkinCardGUID { get; set; }

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06003031 RID: 12337 RVA: 0x00019A53 File Offset: 0x00017C53
		// (set) Token: 0x06003032 RID: 12338 RVA: 0x00019A5B File Offset: 0x00017C5B
		public ulong SelectedHeroicDyeID { get; set; }

		// Token: 0x06003033 RID: 12339 RVA: 0x00101F28 File Offset: 0x00100128
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
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.HeroCardGUID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.SelectedSkinCardGUID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.SelectedHeroicDyeID);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x06003034 RID: 12340 RVA: 0x00101FC4 File Offset: 0x001001C4
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			this.HeroCardGUID = ArrayManager.ReadUInt64(data, ref num);
			this.SelectedSkinCardGUID = ArrayManager.ReadUInt64(data, ref num);
			this.SelectedHeroicDyeID = ArrayManager.ReadUInt64(data, ref num);
		}

		// Token: 0x06003035 RID: 12341 RVA: 0x00019A64 File Offset: 0x00017C64
		private void InitRefTypes()
		{
			this.HeroCardGUID = 0UL;
			this.SelectedSkinCardGUID = 0UL;
			this.SelectedHeroicDyeID = 0UL;
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001B7C RID: 7036
		public const uint cPacketType = 1086350166u;
	}
}
