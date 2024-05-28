using Amazon.KeyManagementService;
using Amazon.KeyManagementService.Model;
using CryptographyLib.Models;
using CryptographyLib.Models.MSCryptographyModel;
using CryptographyLib.Services.Contracts;
using System.Threading.Tasks;

namespace CryptographyLib.Services
{
    public class AwsKmsAsymmetricEncryptionService : IAsymmetricEncryptionService
    {
        private readonly AmazonKeyManagementServiceClient _kmsClient;

        public AwsKmsAsymmetricEncryptionService(string awsAccessKeyId, string awsSecretAccessKey)
        {
            _kmsClient = new AmazonKeyManagementServiceClient(awsAccessKeyId, awsSecretAccessKey);
        }

        public Task<AsymmetricDecryptionResponse> Decrypt(AsymmetricDecryptionRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<AsymmetricDecryptionResponse> DecryptAsync(AsymmetricDecryptionRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<AsymmetricEncryptionResponse> Encrypt(AsymmetricEncryptionRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<AsymmetricEncryptionResponse> EncryptAsync(AsymmetricEncryptionRequest request)
        {
            throw new System.NotImplementedException();
        }

        // public async Task<DataKeyPair> GenerateDataKeyPairAsync(string keyId) {

        //     var request = new GenerateDataKeyPairRequest{
        //         KeyId = keyId,
        //         KeyPairSpec = "RSA_2048"
        //     };

        //     var dataKeyPair = await _kmsClient.GenerateDataKeyPairAsync(request);
        //     var publicKey = dataKeyPair.PublicKey;
        //     var privateKeyCiphertext = dataKeyPair.PrivateKeyCiphertextBlob;
        //     var privateKeyPlaintext = dataKeyPair.PrivateKeyPlaintext;

        //     return new DataKeyPair {
        //         PublicKey = publicKey,
        //         EncryptedPrivateKey = privateKeyCiphertext,
        //         PlaintextPrivateKey = privateKeyPlaintext
        //     };
        // }

        // public async Task<EncryptedResult> EncryptAsync(string plainText) {
        //     return await Task.Run(() => {
        //         return new EncryptedResult();
        //     });
        // }

        // public async Task<DecryptedResult> DecryptAsync(string cipherText) {
        //     return await Task.Run(() => {
        //         return new DecryptedResult();
        //     });
        // }

        // Task<DataKeyPair> IAsymmetricEncryptionService.GenerateDataKeyPairAsync(string keyId)
        // {
        //     throw new System.NotImplementedException();
        // }

        // public Task<EncryptedResult> Encrypt(string plainText)
        // {
        //     throw new System.NotImplementedException();
        // }

        // Task<EncryptedResult> IEncryptionService.EncryptAsync(string plainText)
        // {
        //     throw new System.NotImplementedException();
        // }

        // public Task<EncryptedResult> EncryptAsync(string inName, string outName, byte[] aesKey, byte[] aesIV)
        // {
        //     throw new System.NotImplementedException();
        // }

        // public Task<DecryptedResult> Decrypt(string cipherText)
        // {
        //     throw new System.NotImplementedException();
        // }

        // Task<DecryptedResult> IEncryptionService.DecryptAsync(string cipherText)
        // {
        //     throw new System.NotImplementedException();
        // }
    }
}
