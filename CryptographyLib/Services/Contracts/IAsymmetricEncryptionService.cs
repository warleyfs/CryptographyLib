using CryptographyLib.Models.MSCryptographyModel;
using System.Threading.Tasks;

namespace CryptographyLib.Services.Contracts
{
    public interface IAsymmetricEncryptionService : IEncryptionService
    {
        Task<AsymmetricEncryptionResponse> EncryptAsync(AsymmetricEncryptionRequest request);
        Task<AsymmetricDecryptionResponse> DecryptAsync(AsymmetricDecryptionRequest request);
    }
}
