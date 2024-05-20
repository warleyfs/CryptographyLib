﻿using CryptographyLib.Models;
using CryptographyLib.Services.Contracts;
using System.Threading.Tasks;

namespace CryptographyLib.Services
{
    public class AsymmetricEncryptionService : IAsymmetricEncryptionService
    {
        public async Task<DataKeyPair> GenerateDataKeyPairAsync(string keyId) {
            return new DataKeyPair 
            {
            };
        }

        public async Task<EncryptedResult> EncryptAsync(string plainText) {
            return await Task.Run(() => {
                return new EncryptedResult();
                // //Initialize the byte arrays to the public key information.
                // byte[] modulus =
                // {
                //     214,46,220,83,160,73,40,39,201,155,19,202,3,11,191,178,56,
                //     74,90,36,248,103,18,144,170,163,145,87,54,61,34,220,222,
                //     207,137,149,173,14,92,120,206,222,158,28,40,24,30,16,175,
                //     108,128,35,230,118,40,121,113,125,216,130,11,24,90,48,194,
                //     240,105,44,76,34,57,249,228,125,80,38,9,136,29,117,207,139,
                //     168,181,85,137,126,10,126,242,120,247,121,8,100,12,201,171,
                //     38,226,193,180,190,117,177,87,143,242,213,11,44,180,113,93,
                //     106,99,179,68,175,211,164,116,64,148,226,254,172,147
                // };

                // byte[] exponent = { 1, 0, 1 };

                // //Create values to store encrypted symmetric keys.
                // byte[] encryptedSymmetricKey;
                // byte[] encryptedSymmetricIV;

                // //Create a new instance of the RSA class.
                // RSA rsa = RSA.Create();

                // //Create a new instance of the RSAParameters structure.
                // RSAParameters rsaKeyInfo = new RSAParameters();

                // //Set rsaKeyInfo to the public key values.
                // rsaKeyInfo.Modulus = modulus;
                // rsaKeyInfo.Exponent = exponent;

                // //Import key parameters into rsa.
                // rsa.ImportParameters(rsaKeyInfo);

                // //Create a new instance of the default Aes implementation class.
                // Aes aes = Aes.Create();

                // //Encrypt the symmetric key and IV.
                // encryptedSymmetricKey = rsa.Encrypt(aes.Key, RSAEncryptionPadding.Pkcs1);
                // encryptedSymmetricIV = rsa.Encrypt(aes.IV, RSAEncryptionPadding.Pkcs1);
            });
        }

        public async Task<DecryptedResult> DecryptAsync(string cipherText) {
            return await Task.Run(() => {
                return new DecryptedResult();
            });
        }

        public Task<EncryptedResult> Encrypt(string plainText)
        {
            throw new System.NotImplementedException();
        }

        public Task<EncryptedResult> EncryptAsync(string inName, string outName, byte[] aesKey, byte[] aesIV)
        {
            throw new System.NotImplementedException();
        }

        public Task<DecryptedResult> Decrypt(string cipherText)
        {
            throw new System.NotImplementedException();
        }
    }
}
