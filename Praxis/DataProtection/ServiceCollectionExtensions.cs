﻿using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.DataProtection.XmlEncryption;
using Praxis.Security;

namespace Praxis.DataProtection
{
    // https://docs.microsoft.com/en-us/aspnet/core/security/data-protection/extensibility/key-management
    public static class ServiceCollectionExtensions
    {
        public static void DisableDataProtection(this IServiceCollection services)
        {
            services.AddSingleton<IDataProtectionProvider>(new PassthroughDataProtectionProvider());
            services.AddSingleton<IAuthenticatedEncryptorConfiguration>(new NoEncryptionConfiguration());
            services.AddSingleton<IXmlEncryptor>(new NoXmlEncryption());
            services.AddSingleton<IXmlDecryptor>(new NoXmlDecryption());
            services.AddSingleton<IXmlRepository>(new NoXmlRepository());
        }
    }
}
