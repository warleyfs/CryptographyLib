using CryptographyLib.Services;
using CryptographyLib.Services.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace CryptographyLib
{
    public static class Setup
    {
        public static IServiceCollection AddAwsKmsEncryptionService(this IServiceCollection services, string awsAccessKeyId, string awsSecretAccessKey)
        {
            return services.AddScoped<IAsymmetricEncryptionService>(provider => new AwsKmsAsymmetricEncryptionService(awsAccessKeyId, awsSecretAccessKey));
        }

        public static IServiceCollection AddSymmetricEncryptionService(this IServiceCollection services)
        {
            return services.AddScoped<ISymmetricEncryptionService>(provider => new SymmetricEncryptionService());
        }

        public static IServiceCollection AddAsymmetricEncryptionService(this IServiceCollection services)
        {
            return services.AddScoped<IAsymmetricEncryptionService>(provider => new AsymmetricEncryptionService());
        }
    }
}
