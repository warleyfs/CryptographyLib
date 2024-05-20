using CryptographyLib.Models;
using System.Threading.Tasks;

namespace CryptographyLib.Services.Contracts
{
    public interface IAsymmetricEncryptionService : IEncryptionService
    {
        Task<DataKeyPair> GenerateDataKeyPairAsync(string keyId);
    }
}
