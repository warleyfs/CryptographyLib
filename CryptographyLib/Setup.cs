using CryptographyLib.Services;
using CryptographyLib.Services.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace CryptographyLib
{
    public static class Setup
    {
        public static IServiceCollection AddAwsKmsEncryptionService(this IServiceCollection services, string awsAccessKeyId, string awsSecretAccessKey)
        {
            return services.AddScoped<IEncryptionService>(provider => new AwsKmsAsymmetricEncryptionService(awsAccessKeyId, awsSecretAccessKey));
        }
    }
}
