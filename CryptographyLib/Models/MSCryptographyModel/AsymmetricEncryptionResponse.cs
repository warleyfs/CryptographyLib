using System;

namespace CryptographyLib.Models.MSCryptographyModel
{
    public class AsymmetricEncryptionResponse
    {
        public string SecretKey { get; set; }
        public string InitVector { get; set; }
    }
}
