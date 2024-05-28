using CryptographyLib.Models;
using CryptographyLib.Models.MSCryptographyModel;
using CryptographyLib.Services.Contracts;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace CryptographyLib.Services
{
    public class AsymmetricEncryptionService : IAsymmetricEncryptionService
    {
        public async Task<AsymmetricEncryptionResponse> EncryptAsync(AsymmetricEncryptionRequest request) {
            return await Task.Run(() => {
                return new AsymmetricEncryptionResponse();
            });
        }

        public async Task<AsymmetricDecryptionResponse> DecryptAsync(AsymmetricDecryptionRequest request) {
            return await Task.Run(() => {
                return new AsymmetricDecryptionResponse();
            });
        }
    }
}
