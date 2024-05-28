using System;

namespace CryptographyLib.Models.MSCryptographyModel
{
    public class AsymmetricDecryptionRequest
    {
        public string SecretKey { get; set; }
        public string InitVector { get; set; }
    }
}
