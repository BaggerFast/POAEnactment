// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

//using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using PAOCore.Models;
using System.Runtime.CompilerServices;

namespace PAOCoreTests
{
    /// <summary>
    /// Utilites.
    /// </summary>
    public static class TestsUtils
    {
        public static void SqlPrepare()
        {
            //IConfiguration config = new ConfigurationBuilder()
            //    .AddJsonFile("appsettings.json")
            //    .AddEnvironmentVariables()
            //    .Build();
            //JsonSettingsEntity jsonSettings = new JsonSettingsEntity(config);
            //TestContext.WriteLine($"{AppSettings.DataAccess}");
        }

        public static void MethodStart([CallerMemberName] string memberName = "")
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{memberName} start.");
            TestContext.WriteLine();
        }

        public static void MethodComplete([CallerMemberName] string memberName = "")
        {
            TestContext.WriteLine();
            TestContext.WriteLine($@"{memberName} complete.");
        }
    }
}