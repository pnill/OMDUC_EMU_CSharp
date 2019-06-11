using System;
using System.Collections.Generic;

namespace NetworkProtocols
{
	// Token: 0x020004F9 RID: 1273
	public class KeystoneRerollRequestEntry : BaseAwardEntry
	{
		// Token: 0x06002C52 RID: 11346 RVA: 0x0001785F File Offset: 0x00015A5F
		public KeystoneRerollRequestEntry()
		{
			this.InitRefTypes();
			this.UniqueClassID = 669766743u;
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06002C53 RID: 11347 RVA: 0x00017878 File Offset: 0x00015A78
		// (set) Token: 0x06002C54 RID: 11348 RVA: 0x00017880 File Offset: 0x00015A80
		public ulong ProtoGUID { get; set; }

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06002C55 RID: 11349 RVA: 0x00017889 File Offset: 0x00015A89
		// (set) Token: 0x06002C56 RID: 11350 RVA: 0x00017891 File Offset: 0x00015A91
		public uint NewRerolls { get; set; }

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06002C57 RID: 11351 RVA: 0x0001789A File Offset: 0x00015A9A
		// (set) Token: 0x06002C58 RID: 11352 RVA: 0x000178A2 File Offset: 0x00015AA2
		public ulong RerollKeystoneID { get; set; }

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06002C59 RID: 11353 RVA: 0x000178AB File Offset: 0x00015AAB
		// (set) Token: 0x06002C5A RID: 11354 RVA: 0x000178B3 File Offset: 0x00015AB3
		public int Level { get; set; }

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06002C5B RID: 11355 RVA: 0x000178BC File Offset: 0x00015ABC
		// (set) Token: 0x06002C5C RID: 11356 RVA: 0x000178C4 File Offset: 0x00015AC4
		public int LivesRemaining { get; set; }

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06002C5D RID: 11357 RVA: 0x000178CD File Offset: 0x00015ACD
		// (set) Token: 0x06002C5E RID: 11358 RVA: 0x000178D5 File Offset: 0x00015AD5
		public List<ulong> ModifierGUIDs { get; set; }

		// Token: 0x06002C5F RID: 11359 RVA: 0x000FDC58 File Offset: 0x000FBE58
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			ArrayManager.WriteUInt64(ref newArray, ref num, this.ProtoGUID);
			ArrayManager.WriteUInt32(ref newArray, ref num, this.NewRerolls);
			ArrayManager.WriteUInt64(ref newArray, ref num, this.RerollKeystoneID);
			ArrayManager.WriteInt32(ref newArray, ref num, this.Level);
			ArrayManager.WriteInt32(ref newArray, ref num, this.LivesRemaining);
			ArrayManager.WriteListUInt64(ref newArray, ref num, this.ModifierGUIDs);
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

		// Token: 0x06002C60 RID: 11360 RVA: 0x000FDD04 File Offset: 0x000FBF04
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			this.ProtoGUID = ArrayManager.ReadUInt64(data, ref num);
			this.NewRerolls = ArrayManager.ReadUInt32(data, ref num);
			this.RerollKeystoneID = ArrayManager.ReadUInt64(data, ref num);
			this.Level = ArrayManager.ReadInt32(data, ref num);
			this.LivesRemaining = ArrayManager.ReadInt32(data, ref num);
			this.ModifierGUIDs = ArrayManager.ReadListUInt64(data, ref num);
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002C61 RID: 11361 RVA: 0x000178DE File Offset: 0x00015ADE
		private void InitRefTypes()
		{
			this.ProtoGUID = 0UL;
			this.NewRerolls = 0u;
			this.RerollKeystoneID = 0UL;
			this.Level = 0;
			this.LivesRemaining = 0;
			this.ModifierGUIDs = new List<ulong>();
		}
	}
}
