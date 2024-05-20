using System.ComponentModel;

namespace CryptographyLib.Enums
{
    public enum KeyTypes
    {
        [Description("Chave compartilhada")]
        Shared = 1,
        [Description("Chave pública")]
        Public = 2,
        [Description("Chave privada")]
        Private = 3,
    }
}
