using CryptographyLib.Models;
using System.Threading.Tasks;

namespace CryptographyLib.Services.Contracts
{
    public interface IEncryptionService
    {
        Task<EncryptedResult> Encrypt(string plainText);
        Task<EncryptedResult> EncryptAsync(string plainText);
        Task<EncryptedResult> EncryptAsync(string inName, string outName, byte[] aesKey, byte[] aesIV);
        Task<DecryptedResult> Decrypt(string cipherText);
        Task<DecryptedResult> DecryptAsync(string cipherText);
    }
}
