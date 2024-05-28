using System;

namespace CryptographyLib.Models.MSCryptographyModel
{
    public class AsymmetricDecryptionResponse
    {
        public string SecretKey { get; set; }
        public string InitVector { get; set; }
    }
}
