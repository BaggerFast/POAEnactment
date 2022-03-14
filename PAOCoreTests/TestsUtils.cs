// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using PAOCore.DAL.Models;
using PAOCore.Models;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


namespace PAOCoreTests
{
    /// <summary>
    /// Utilites.
    /// </summary>
    public static class TestsUtils
    {
        #region Public and private fields and properties

        public static AppSettingsHelper AppSettings { get; private set; } = AppSettingsHelper.Instance;

        #endregion

        #region Public and private methods

        public static void Setup()
        {
            Dictionary<string, string>? inMemorySettings = new()
            {
                { "sql:server", "CREATIO\\INS1" },
                { "sql:db", "PAO" },
                { "sql:trusted", "false" },
                { "sql:username", "pao_admin" },
                { "sql:password", "Asdfg12345" },
                { "sql:schema", "dbo" },
                { "sql:trustservercertificate", "true" },
            };
            IConfiguration Configuration = new ConfigurationBuilder().AddInMemoryCollection(inMemorySettings).Build();
            JsonSettingsEntity jsonSettings = new(Configuration);
            AppSettings.SetupJsonSettings(jsonSettings);
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

        #endregion
    }
}