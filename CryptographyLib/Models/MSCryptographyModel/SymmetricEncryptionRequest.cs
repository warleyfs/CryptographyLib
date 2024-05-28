using System;

namespace CryptographyLib.Models.MSCryptographyModel
{
    public class SymmetricEncryptionRequest
    {
        public string PlainText { get; set; }
        public string SecretKey { get; set; }
        public string InitVector { get; set; }
    }
}
