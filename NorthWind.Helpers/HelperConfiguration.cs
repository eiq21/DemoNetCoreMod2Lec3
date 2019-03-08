using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace NorthWind.Helpers
{
    public static class HelperConfiguration
    {
        public static AppConfiguration GetAppConfiguration(string configurationFile = "App.Json")
        {
            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile(configurationFile, optional: false).Build();
            var result = configuration.Get<AppConfiguration>();
            return result;
        }
    }
}
