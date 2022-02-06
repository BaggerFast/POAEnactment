// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using PAOCore.Models;
using PAOCoreTests;
using System.IO;
using System.Reflection;

namespace PAOTests
{
    [TestFixture]
    internal class SqlConfigurationTest
    {
        [Test]
        public static void SqlConfigFound()
        {
            TestsUtils.MethodStart();
            
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string jsonLocation = Path.Combine(executableLocation, "appsettings.json");

            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile(jsonLocation)
                .Build();
            JsonSettingsEntity jsonSettings = new (config);
            TestContext.WriteLine($"{jsonSettings}");
            
            TestsUtils.MethodComplete();
        }
    }
}
