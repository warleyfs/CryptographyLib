using System.IO;

namespace CryptographyLib.Models
{
    public class DataKeyPair
    {
        public MemoryStream PublicKey { get; set; } = null;
        
        public MemoryStream EncryptedPrivateKey { get; set; } = null;

        public MemoryStream PlaintextPrivateKey { get; set; } = null;
    }
}
