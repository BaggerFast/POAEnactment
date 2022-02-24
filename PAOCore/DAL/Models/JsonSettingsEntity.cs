// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System;
using Microsoft.Extensions.Configuration;

namespace PAOCore.Models
{
    /// <summary>
    /// Data model for appsettings.json.
    /// </summary>
    public class JsonSettingsEntity
    {
        #region Public and private fields and properties

        public IConfiguration Configuration { get; }

        public string Server
        {
            get => Configuration["sql:server"];
            set => Configuration["sql:server"] = value;
        }
        public string Db
        {
            get => Configuration["sql:db"];
            set => Configuration["sql:db"] = value;
        }
        public bool Trusted
        {
            get => Convert.ToBoolean(Configuration["sql:trusted"]);
            set => Configuration["sql:trusted"] = Convert.ToString(value);
        }
        public string Username
        {
            get => Configuration["sql:username"];
            set => Configuration["sql:username"] = value;
        }
        public string Password
        {
            get => Configuration["sql:password"];
            set => Configuration["sql:password"] = value;
        }
        public string Schema
        {
            get => Configuration["sql:server"];
            set => Configuration["sql:server"] = value;
        }
        public bool TrustServerCertificate
        {
            get => Convert.ToBoolean(Configuration["sql:trustservercertificate"]);
            set => Configuration["sql:trustservercertificate"] = Convert.ToString(value);
        }
        public bool IsDebug
        {
            get => Convert.ToBoolean(Configuration["isdebug"]);
            set => Configuration["isdebug"] = Convert.ToString(value);
        }

        #endregion

        #region Constructor and destructor

        public JsonSettingsEntity(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        #endregion

        #region Public and private methods

        public override string ToString()
        {
            string strTrusted = Trusted ? $"{nameof(Trusted)}: true." : $"{nameof(Username)}: {Username}. {nameof(Password)}: {Password}.";
            return $"{nameof(Server)}: {Server}. " +
                   $"{nameof(Db)}: {Db}. " +
                   $"{strTrusted} " +
                   $"{nameof(TrustServerCertificate)}: {TrustServerCertificate}. " +
                   $"{nameof(IsDebug)}: {IsDebug}. ";
        }

        #endregion
    }
}
