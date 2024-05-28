using CryptographyLib.Models;
using CryptographyLib.Models.MSCryptographyModel;
using CryptographyLib.Services.Contracts;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CryptographyLib.Services
{
    public class SymmetricEncryptionService : ISymmetricEncryptionService
    {
        public async Task<SymmetricEncryptionResponse> EncryptAsync(SymmetricEncryptionRequest request)
        {
            try
            {
                return await Task.Run<SymmetricEncryptionResponse>(() =>
                {
                    byte[] clearBytes = Encoding.Unicode.GetBytes(request.PlainText);
                    using (Aes encryptor = Aes.Create())
                    {
                        Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(request.SecretKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                        encryptor.Key = pdb.GetBytes(32);
                        encryptor.IV = pdb.GetBytes(16);

                        using (MemoryStream ms = new MemoryStream())
                        {
                            using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                            {
                                cs.Write(clearBytes, 0, clearBytes.Length);
                                cs.Close();
                            }

                            return new SymmetricEncryptionResponse
                            {
                                SecretKey = ms.ToArray(),
                                InitVector = ms.ToArray()
                            };
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"The encryption failed. {ex}");
                return new SymmetricEncryptionResponse();
            }
        }
    
        public async Task<SymmetricDecryptionResponse> DecryptAsync(SymmetricDecryptionRequest request)
        {
            try
            {
                return await Task.Run<SymmetricDecryptionResponse>(async () => {
                    

                    return new SymmetricDecryptionResponse();
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"The decryption failed. {ex}");
                return new SymmetricDecryptionResponse();
            }
        }
    }
}
