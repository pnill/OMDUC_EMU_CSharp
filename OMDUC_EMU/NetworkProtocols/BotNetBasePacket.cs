using System;

namespace NetworkProtocols
{
	// Token: 0x02000479 RID: 1145
	public class BotNetBasePacket
	{
		// Token: 0x060029A8 RID: 10664 RVA: 0x000069C3 File Offset: 0x00004BC3
		public BotNetBasePacket()
		{
		}

		// Token: 0x060029A9 RID: 10665 RVA: 0x000069C3 File Offset: 0x00004BC3
		public BotNetBasePacket(BotNetMessage message)
		{
		}

		// Token: 0x060029AB RID: 10667 RVA: 0x00015A0A File Offset: 0x00013C0A
		public void Reset()
		{
			this.Length = 0u;
			this.PacketBuffer = null;
			this.HeaderParsed = false;
			this.RemainingCount = 0u;
			this.IsCompressed = false;
		}

		// Token: 0x060029AC RID: 10668 RVA: 0x000FA014 File Offset: 0x000F8214
		public void Parse(byte[] header)
		{
			uint num = BitConverter.ToUInt32(header, 0);
			this.IsCompressed = ((num & 16777216u) == 16777216u);
			num &= 4278190079u;
			this.Length = num;
			this.RemainingCount = this.Length;
			this.HeaderParsed = true;
		}

		// Token: 0x060029AD RID: 10669 RVA: 0x000FA060 File Offset: 0x000F8260
		public static byte[] SerializePacket(BotNetMessage message)
		{
			byte[] array = message.SerializeMessage();
			uint num = (uint)array.Length;
			byte[] array2 = new byte[(ulong)num + (ulong)((long)BotNetBasePacket.PacketSize)];
			Array.Copy(array, 0, array2, BotNetBasePacket.PacketSize, array.Length);
			array = BitConverter.GetBytes(num);
			Array.Copy(array, 0, array2, 0, 4);
			return array2;
		}

		// Token: 0x060029AE RID: 10670 RVA: 0x000FA0AC File Offset: 0x000F82AC
		public static byte[] SerializePacket(byte[] encryptedBytes, bool isCompressed)
		{
			uint num = (uint)encryptedBytes.Length;
			byte[] array = new byte[(ulong)num + (ulong)((long)BotNetBasePacket.PacketSize)];
			Array.Copy(encryptedBytes, 0, array, BotNetBasePacket.PacketSize, encryptedBytes.Length);
			if (isCompressed)
			{
				num |= 16777216u;
			}
			encryptedBytes = BitConverter.GetBytes(num);
			Array.Copy(encryptedBytes, 0, array, 0, 4);
			return array;
		}

		// Token: 0x0400167F RID: 5759
		public const uint COMPRESSION_ENABLED = 16777216u;

		// Token: 0x04001680 RID: 5760
		public static int PacketSize = 4;

		// Token: 0x04001681 RID: 5761
		public byte[] PacketBuffer;

		// Token: 0x04001682 RID: 5762
		public bool HeaderParsed;

		// Token: 0x04001683 RID: 5763
		public uint RemainingCount;

		// Token: 0x04001684 RID: 5764
		public uint Length;

		// Token: 0x04001685 RID: 5765
		public bool IsCompressed;
	}
}
