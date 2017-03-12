﻿namespace Skeleton.Web.Logging
{
    using System.IO;
    using Microsoft.Extensions.Configuration;
    using NLog;
    using NLog.Config;

    public static class ConfigurationBuilderExtensions
    {
        [ExcludeFromCodeCoverage]
        public static IConfigurationBuilder AddNLogConfig(this IConfigurationBuilder configurationBuilder, string relativeConfigPath)
        {
            var fullConfigPath = Path.Combine(configurationBuilder.GetFileProvider().GetFileInfo(relativeConfigPath).PhysicalPath);
            LogManager.Configuration = new XmlLoggingConfiguration(fullConfigPath, false);
            return configurationBuilder;
        }
    }
}