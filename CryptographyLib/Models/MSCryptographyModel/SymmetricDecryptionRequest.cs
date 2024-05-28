using System;

namespace CryptographyLib.Models.MSCryptographyModel
{
    public class SymmetricDecryptionRequest
    {
        public string SecretKey { get; set; }
        public string InitVector { get; set; }
    }
}
