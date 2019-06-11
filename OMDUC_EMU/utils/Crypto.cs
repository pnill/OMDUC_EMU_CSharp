using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace OMDUC_EMU.utils
{
    public class Crypto
    {
        //Placement of this data must be per-socket as each client generates new IV/Key on every connection.
        public byte[] mSymmetricKey;
        public byte[] mSymmetricIV;

        public void DecryptSymmetricKeys(NetworkProtocols.RequestSecurityHandshake message)
        {
            try
            {
                RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider();
                rsacryptoServiceProvider.FromXmlString("<RSAKeyValue><Modulus>re/Nl9VVkhhQ6B7Qw1ic9G1KUt2AE8mSAvULWG0fvXRWEU2VP4rD73Iy/3LRkOYHEzfKMiwBk9RU+abG2tluKw==</Modulus><Exponent>AQAB</Exponent><P>1rmag2p2fQ4HN0bDTRVKw39RPfcCeASZUNGKB2LzIcM=</P><Q>z18M2Z51g6guaUY7Z1zGOgR4fuDsUYY9VE381LAPE3k=</Q><DP>sLthPqsAzVsfe1Kl6qsMty3ye1L0WD5IxmlA92VtAis=</DP><DQ>QYVTxxK1KKMj/ulM7ay3iS9ObzBcGqoiiJeXkhAKw2k=</DQ><InverseQ>oGj2T4z7eMAcyjPKOiPJQvfm/nfAokrdPJpRSZ9hJZM=</InverseQ><D>lYfD0pT3dJps67CaPmXuwP831xdPJTOzz9EECOf/UmnHOFcFmodQQ+N77uM9qaTyDBlLZ1mb07bsN/QabeTrsQ==</D></RSAKeyValue>");

                this.mSymmetricIV = rsacryptoServiceProvider.Decrypt(Convert.FromBase64String(message.SharedIV), false);
                this.mSymmetricKey = rsacryptoServiceProvider.Decrypt(Convert.FromBase64String(message.SharedKey), false);
            }
            catch (Exception e)
            {
                Console.WriteLine("[!] There was a problem while decrypting security handshake keys!");
            }
        }

        //Ripped from RDBSocket.EncryptPayload
        public byte[] EncryptPayload(byte[] buffer)
        {
            byte[] result;
            using (AesManaged aesManaged = new AesManaged())
            {
                aesManaged.Key = this.mSymmetricKey;
                aesManaged.IV = this.mSymmetricIV;
                ICryptoTransform transform = aesManaged.CreateEncryptor(aesManaged.Key, aesManaged.IV);
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(buffer, 0, buffer.Length);
                        cryptoStream.Close();
                        byte[] array = memoryStream.ToArray();
                        result = array;
                    }
                }
            }
            return result;
        }

        //Ripped from RDBSocket.DecryptPayload
        public byte[] DecryptPayload(byte[] buffer)
        {
            byte[] result;
            using (AesManaged aesManaged = new AesManaged())
            {
                aesManaged.Key = this.mSymmetricKey;
                aesManaged.IV = this.mSymmetricIV;
                ICryptoTransform transform = aesManaged.CreateDecryptor(aesManaged.Key, aesManaged.IV);
                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read))
                    {
                        using (BinaryReader binaryReader = new BinaryReader(cryptoStream))
                        {
                            byte[] array = binaryReader.ReadBytes(buffer.Length);
                            result = array;
                        }
                    }
                }
            }
            return result;
        }


    }
}
