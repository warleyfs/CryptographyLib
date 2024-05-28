using System.Threading.Tasks;
using CryptographyLib.Models.MSCryptographyModel;

namespace CryptographyLib.Services.Contracts
{
    public interface ISymmetricEncryptionService : IEncryptionService
    {
        Task<SymmetricEncryptionResponse> EncryptAsync(SymmetricEncryptionRequest request);
        Task<SymmetricDecryptionResponse> DecryptAsync(SymmetricDecryptionRequest request);
    }
}
