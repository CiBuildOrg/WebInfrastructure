﻿namespace Skeleton.Web.Authorisation.JwtBearer
{
    using System;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.Extensions.Options;

    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseJwtBearerAuthorisationTokens(this IApplicationBuilder applicationBuilder)
        {
            if (applicationBuilder == null)
                throw new ArgumentNullException(nameof(applicationBuilder));

            return applicationBuilder
                .UseMiddleware<TokensIssuingMiddleware>()
                .UseJwtBearerAuthentication();
        }

        public static IApplicationBuilder UseJwtBearerAuthorisationTokens(this IApplicationBuilder applicationBuilder,
            TokensIssuingOptions issuingOptions, JwtBearerOptions verificationOptions)
        {
            if (applicationBuilder == null)
                throw new ArgumentNullException(nameof(applicationBuilder));
            if (issuingOptions == null)
                throw new ArgumentNullException(nameof(issuingOptions));
            if(verificationOptions == null)
                throw new ArgumentNullException(nameof(verificationOptions));

            return applicationBuilder
                .UseMiddleware<TokensIssuingMiddleware>(Options.Create(issuingOptions))
                .UseJwtBearerAuthentication(verificationOptions);
        }
    }
}