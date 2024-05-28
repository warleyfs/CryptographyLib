using System.IO;

namespace CryptographyLib.Models.AwsEncryptionSdk
{
    public class DataKeyPair
    {
        public MemoryStream PublicKey { get; set; } = null;
        
        public MemoryStream EncryptedPrivateKey { get; set; } = null;

        public MemoryStream PlaintextPrivateKey { get; set; } = null;
    }
}
