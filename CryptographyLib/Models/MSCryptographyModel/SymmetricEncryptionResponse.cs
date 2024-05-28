using System;

namespace CryptographyLib.Models.MSCryptographyModel
{
    public class SymmetricEncryptionResponse
    {
        public byte[] SecretKey { get; set; }
        public byte[] InitVector { get; set; }
    }
}
