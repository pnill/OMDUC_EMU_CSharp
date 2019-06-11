using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x02000661 RID: 1633
	public class KeystoneDetailPacket
	{
		// Token: 0x060038F5 RID: 14581 RVA: 0x0001F729 File Offset: 0x0001D929
		public KeystoneDetailPacket()
		{
			this.InitRefTypes();
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x060038F6 RID: 14582 RVA: 0x0001F737 File Offset: 0x0001D937
		// (set) Token: 0x060038F7 RID: 14583 RVA: 0x0001F73F File Offset: 0x0001D93F
		public ulong ID { get; set; }

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x060038F8 RID: 14584 RVA: 0x0001F748 File Offset: 0x0001D948
		// (set) Token: 0x060038F9 RID: 14585 RVA: 0x0001F750 File Offset: 0x0001D950
		public ulong ProtoGUID { get; set; }

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x060038FA RID: 14586 RVA: 0x0001F759 File Offset: 0x0001D959
		// (set) Token: 0x060038FB RID: 14587 RVA: 0x0001F761 File Offset: 0x0001D961
		public ulong MapGUID { get; set; }

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x060038FC RID: 14588 RVA: 0x0001F76A File Offset: 0x0001D96A
		// (set) Token: 0x060038FD RID: 14589 RVA: 0x0001F772 File Offset: 0x0001D972
		public bool IsNew { get; set; }

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x060038FE RID: 14590 RVA: 0x0001F77B File Offset: 0x0001D97B
		// (set) Token: 0x060038FF RID: 14591 RVA: 0x0001F783 File Offset: 0x0001D983
		public int Level { get; set; }

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x06003900 RID: 14592 RVA: 0x0001F78C File Offset: 0x0001D98C
		// (set) Token: 0x06003901 RID: 14593 RVA: 0x0001F794 File Offset: 0x0001D994
		public int LivesStarting { get; set; }

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x06003902 RID: 14594 RVA: 0x0001F79D File Offset: 0x0001D99D
		// (set) Token: 0x06003903 RID: 14595 RVA: 0x0001F7A5 File Offset: 0x0001D9A5
		public int LivesRemaining { get; set; }

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x06003904 RID: 14596 RVA: 0x0001F7AE File Offset: 0x0001D9AE
		// (set) Token: 0x06003905 RID: 14597 RVA: 0x0001F7B6 File Offset: 0x0001D9B6
		public ulong RunningScore { get; set; }

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06003906 RID: 14598 RVA: 0x0001F7BF File Offset: 0x0001D9BF
		// (set) Token: 0x06003907 RID: 14599 RVA: 0x0001F7C7 File Offset: 0x0001D9C7
		public uint RerollsRemaining { get; set; }

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06003908 RID: 14600 RVA: 0x0001F7D0 File Offset: 0x0001D9D0
		// (set) Token: 0x06003909 RID: 14601 RVA: 0x0001F7D8 File Offset: 0x0001D9D8
		public List<ulong> ModifierGUIDs { get; set; }

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x0600390A RID: 14602 RVA: 0x0001F7E1 File Offset: 0x0001D9E1
		// (set) Token: 0x0600390B RID: 14603 RVA: 0x0001F7E9 File Offset: 0x0001D9E9
		public DateTime UpdatedOn { get; set; }

		// Token: 0x0600390C RID: 14604 RVA: 0x0010EBF4 File Offset: 0x0010CDF4
		public byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.ID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.ProtoGUID);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.MapGUID);
			ArrayManager.WriteBoolean(ref newArray, ref newSize, this.IsNew);
			ArrayManager.WriteInt32(ref newArray, ref newSize, this.Level);
			ArrayManager.WriteInt32(ref newArray, ref newSize, this.LivesStarting);
			ArrayManager.WriteInt32(ref newArray, ref newSize, this.LivesRemaining);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, this.RunningScore);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, this.RerollsRemaining);
			ArrayManager.WriteListUInt64(ref newArray, ref newSize, this.ModifierGUIDs);
			ArrayManager.WriteDateTime(ref newArray, ref newSize, this.UpdatedOn);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600390D RID: 14605 RVA: 0x0010ECB8 File Offset: 0x0010CEB8
		public void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.ID = ArrayManager.ReadUInt64(data, ref num);
			this.ProtoGUID = ArrayManager.ReadUInt64(data, ref num);
			this.MapGUID = ArrayManager.ReadUInt64(data, ref num);
			this.IsNew = ArrayManager.ReadBoolean(data, ref num);
			this.Level = ArrayManager.ReadInt32(data, ref num);
			this.LivesStarting = ArrayManager.ReadInt32(data, ref num);
			this.LivesRemaining = ArrayManager.ReadInt32(data, ref num);
			this.RunningScore = ArrayManager.ReadUInt64(data, ref num);
			this.RerollsRemaining = ArrayManager.ReadUInt32(data, ref num);
			this.ModifierGUIDs = ArrayManager.ReadListUInt64(data, ref num);
			this.UpdatedOn = ArrayManager.ReadDateTime(data, ref num);
		}

		// Token: 0x0600390E RID: 14606 RVA: 0x0010ED64 File Offset: 0x0010CF64
		private void InitRefTypes()
		{
			this.ID = 0UL;
			this.ProtoGUID = 0UL;
			this.MapGUID = 0UL;
			this.IsNew = false;
			this.Level = 0;
			this.LivesStarting = 0;
			this.LivesRemaining = 0;
			this.RunningScore = 0UL;
			this.RerollsRemaining = 0u;
			this.ModifierGUIDs = new List<ulong>();
			this.UpdatedOn = default(DateTime);
		}
	}
}
