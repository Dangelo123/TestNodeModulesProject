﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Otc.AspNetCore.ApiBoot;
using System.Diagnostics.CodeAnalysis;

namespace TestNodeModulesProject.WebApi
{
    /// <summary>
    /// API Startup class. 
    /// </summary>
    public class Startup : ApiBootStartup
    {
        protected override ApiMetadata ApiMetadata => new ApiMetadata()
        {
            Name = "TestNodeModulesProject",
            Description = "ApiBoot based API (https://github.com/OleConsignado/otc-aspnetcore-apiboot)",
            DefaultApiVersion = "1.0"
        };

        public Startup(IConfiguration configuration)
            : base(configuration)
        {
            // Disable request body capturing for AuthController in order
            // to prevent capture creedentials
            RequestTrackingDisableBodyCapturingForUrl("v[0-9.]+/auth");
        }

        /// <summary>
        /// API service registration.
        /// </summary>
        /// <param name="services">The service collection</param>
        [ExcludeFromCodeCoverage]
        protected override void ConfigureApiServices(IServiceCollection services)
        {
            services.AddNodeServices();
            // API service registration goes here
        }
    }
}
