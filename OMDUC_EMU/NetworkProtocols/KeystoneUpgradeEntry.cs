using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020004F6 RID: 1270
	public class KeystoneUpgradeEntry : BaseAwardEntry
	{
		// Token: 0x06002C2C RID: 11308 RVA: 0x000176CC File Offset: 0x000158CC
		public KeystoneUpgradeEntry()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2997943509u;
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06002C2D RID: 11309 RVA: 0x000176E5 File Offset: 0x000158E5
		// (set) Token: 0x06002C2E RID: 11310 RVA: 0x000176ED File Offset: 0x000158ED
		public ulong KeystoneDetailID { get; set; }

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06002C2F RID: 11311 RVA: 0x000176F6 File Offset: 0x000158F6
		// (set) Token: 0x06002C30 RID: 11312 RVA: 0x000176FE File Offset: 0x000158FE
		public int Level { get; set; }

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06002C31 RID: 11313 RVA: 0x00017707 File Offset: 0x00015907
		// (set) Token: 0x06002C32 RID: 11314 RVA: 0x0001770F File Offset: 0x0001590F
		public ulong MapGUID { get; set; }

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06002C33 RID: 11315 RVA: 0x00017718 File Offset: 0x00015918
		// (set) Token: 0x06002C34 RID: 11316 RVA: 0x00017720 File Offset: 0x00015920
		public int LivesStarting { get; set; }

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06002C35 RID: 11317 RVA: 0x00017729 File Offset: 0x00015929
		// (set) Token: 0x06002C36 RID: 11318 RVA: 0x00017731 File Offset: 0x00015931
		public int LivesRemaining { get; set; }

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06002C37 RID: 11319 RVA: 0x0001773A File Offset: 0x0001593A
		// (set) Token: 0x06002C38 RID: 11320 RVA: 0x00017742 File Offset: 0x00015942
		public ulong Score { get; set; }

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06002C39 RID: 11321 RVA: 0x0001774B File Offset: 0x0001594B
		// (set) Token: 0x06002C3A RID: 11322 RVA: 0x00017753 File Offset: 0x00015953
		public List<ulong> NewModifierGUIDs { get; set; }

		// Token: 0x06002C3B RID: 11323 RVA: 0x000FD95C File Offset: 0x000FBB5C
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.KeystoneDetailID);
			ArrayManager.WriteInt32(ref newArray, ref num, this.Level);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.MapGUID);
			ArrayManager.WriteInt32(ref newArray, ref num, this.LivesStarting);
			ArrayManager.WriteInt32(ref newArray, ref num, this.LivesRemaining);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.Score);
			ArrayManager.WriteListUInt64(ref newArray, ref num, this.NewModifierGUIDs);
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

		// Token: 0x06002C3C RID: 11324 RVA: 0x000FDA18 File Offset: 0x000FBC18
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.KeystoneDetailID = ArrayManager.ReadUInt64(data, ref num);
			this.Level = ArrayManager.ReadInt32(data, ref num);
			this.MapGUID = ArrayManager.ReadUInt64(data, ref num);
			this.LivesStarting = ArrayManager.ReadInt32(data, ref num);
			this.LivesRemaining = ArrayManager.ReadInt32(data, ref num);
			this.Score = ArrayManager.ReadUInt64(data, ref num);
			this.NewModifierGUIDs = ArrayManager.ReadListUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002C3D RID: 11325 RVA: 0x0001775C File Offset: 0x0001595C
		private void InitRefTypes()
		{
			this.KeystoneDetailID = 0UL;
			this.Level = 0;
			this.MapGUID = 0UL;
			this.LivesStarting = 0;
			this.LivesRemaining = 0;
			this.Score = 0UL;
			this.NewModifierGUIDs = new List<ulong>();
		}
	}
}
