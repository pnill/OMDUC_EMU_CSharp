using System;
using System.Security.Cryptography;
using System.Text;

namespace NetworkProtocols
{
	// Token: 0x0200047A RID: 1146
	public abstract class BotNetMessage
	{
		// Token: 0x1700039B RID: 923
		// (get) Token: 0x060029B0 RID: 10672 RVA: 0x00015A2F File Offset: 0x00013C2F
		// (set) Token: 0x060029B1 RID: 10673 RVA: 0x00015A37 File Offset: 0x00013C37
		public uint PacketType { get; set; }

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x060029B2 RID: 10674 RVA: 0x00015A40 File Offset: 0x00013C40
		// (set) Token: 0x060029B3 RID: 10675 RVA: 0x00015A48 File Offset: 0x00013C48
		public ulong SessionToken { get; set; }

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x060029B4 RID: 10676 RVA: 0x00015A51 File Offset: 0x00013C51
		// (set) Token: 0x060029B5 RID: 10677 RVA: 0x00015A59 File Offset: 0x00013C59
		public ulong SecurityToken { get; set; }

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x060029B6 RID: 10678 RVA: 0x00015A62 File Offset: 0x00013C62
		// (set) Token: 0x060029B7 RID: 10679 RVA: 0x00015A6A File Offset: 0x00013C6A
		public uint RequestID { get; set; }

		// Token: 0x060029B8 RID: 10680 RVA: 0x00015A73 File Offset: 0x00013C73
		public virtual byte[] SerializeMessage()
		{
			throw new Exception("Not Implemented.  Do not call base SerializeMessage from instance classes.");
		}

		// Token: 0x060029B9 RID: 10681 RVA: 0x00015A7F File Offset: 0x00013C7F
		public virtual void DeserializeMessage(byte[] data)
		{
			throw new Exception("Not Implemented.  Do not call base DeserializeMessage from instance classes.");
		}

		// Token: 0x060029BA RID: 10682 RVA: 0x000FA100 File Offset: 0x000F8300
		public static string SerializeToString(BotNetMessage message)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine(string.Format("PacketType: [ {0} ]", message.GetType()));
			stringBuilder.AppendLine(string.Format("SessionToken: [ {0} ]", message.SessionToken));
			stringBuilder.AppendLine(string.Format("SecurityToken: [ {0} ]", message.SecurityToken));
			return stringBuilder.ToString();
		}

		// Token: 0x060029BB RID: 10683 RVA: 0x000FA168 File Offset: 0x000F8368
		public static uint GetRandomUInt32()
		{
			byte[] array = new byte[4];
			RNGCryptoServiceProvider rngcryptoServiceProvider = new RNGCryptoServiceProvider();
			rngcryptoServiceProvider.GetBytes(array);
			return BitConverter.ToUInt32(array, 0);
		}
	}
}
