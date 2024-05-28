using System;

namespace CryptographyLib.Models.MSCryptographyModel
{
    public class SymmetricDecryptionResponse
    {
        public string SecretKey { get; set; }
        public string InitVector { get; set; }
    }
}
