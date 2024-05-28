using System;

namespace CryptographyLib.Models.MSCryptographyModel
{
    public class AsymmetricEncryptionRequest
    {
        public string SecretKey { get; set; }
        public string InitVector { get; set; }
    }
}
