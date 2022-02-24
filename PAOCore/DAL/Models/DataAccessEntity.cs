// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com/

using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using PAOCore.DAL.TableModels;
using PAOCore.Models;
using System;

namespace PAOCore.DAL.Models
{
    public class DataAccessEntity : IDisposable
    {
        #region Public and private fields and properties

        public JsonSettingsEntity JsonSettings { get; private set; }
        private readonly object _locker = new();

        private ISessionFactory? _sessionFactory = null;
        private ISessionFactory? SessionFactory
        {
            get
            {
                if (_sessionFactory != null)
                    return _sessionFactory;
                lock (_locker)
                {
                    if (JsonSettings == null)
                        throw new ArgumentException($"{nameof(JsonSettings)} is null!");
                    if (!JsonSettings.Trusted && (string.IsNullOrEmpty(JsonSettings.Username) || string.IsNullOrEmpty(JsonSettings.Password)))
                        throw new ArgumentException("CoreSettings.Username or CoreSettings.Password is null!");
                    MsSqlConfiguration config = MsSqlConfiguration.MsSql2012.ConnectionString(GetConnectionString());
                    config.Driver<NHibernate.Driver.MicrosoftDataSqlClientDriver>();
                    FluentConfiguration configuration = Fluently.Configure().Database(config);
                    AddConfigurationMappings(configuration, JsonSettings);
                    configuration.ExposeConfiguration(cfg => cfg.SetProperty("hbm2ddl.keywords", "auto-quote"));
                    // Be careful. If there are errors in the mapping, this line will make an Exception!
                    _sessionFactory = configuration.BuildSessionFactory();
                    return _sessionFactory;
                }
            }
        }

        public CrudController Crud { get; private set; }

        public bool IsDisabled
        {
            get
            {
                ISession? session = GetSession();
                return session == null || !session.IsConnected;
            }
        }
        public bool IsOpen
        {
            get
            {
                ISession? session = GetSession();
                return session == null || session.IsOpen;
            }
        }
        public bool IsConnected
        {
            get
            {
                ISession? session = GetSession();
                return session == null || session.IsConnected;
            }
        }
        public bool IsDirty
        {
            get
            {
                ISession? session = GetSession();
                return session == null || session.IsDirty();
            }
        }

        #endregion

        #region Constructor and destructor

        public DataAccessEntity(JsonSettingsEntity jsonSettings)
        {
            JsonSettings = jsonSettings ?? throw new ArgumentException("jsonAppSettings must be not null!");
            Crud = new CrudController(this, SessionFactory);
        }

        private string GetConnectionString() => JsonSettings.Trusted
            ? $"Data Source={JsonSettings.Server};Initial Catalog={JsonSettings.Db};Persist Security Info=True;" +
              $"Trusted Connection=True;TrustServerCertificate={JsonSettings.TrustServerCertificate};"
            : $"Data Source={JsonSettings.Server};Initial Catalog={JsonSettings.Db};Persist Security Info=True;" +
              $"User ID={JsonSettings.Username};Password={JsonSettings.Password};TrustServerCertificate={JsonSettings.TrustServerCertificate};";

        private void AddConfigurationMappings(FluentConfiguration configuration, JsonSettingsEntity jsonSettings)
        {
            if (configuration == null || jsonSettings == null || string.IsNullOrEmpty(jsonSettings.Db))
                return;

            switch (jsonSettings.Db.ToUpper())
            {
                case "PAO":
                    AddConfigurationMappingsForPao(configuration);
                    break;
            }
        }

        private void AddConfigurationMappingsForPao(FluentConfiguration configuration)
        {
            configuration.Mappings(m => m.FluentMappings.Add<AddressMap>());
            configuration.Mappings(m => m.FluentMappings.Add<AuthorityMap>());
            configuration.Mappings(m => m.FluentMappings.Add<CompanyMap>());
            configuration.Mappings(m => m.FluentMappings.Add<ManagerMap>());
            configuration.Mappings(m => m.FluentMappings.Add<PassportMap>());
            configuration.Mappings(m => m.FluentMappings.Add<PersonMap>());
        }

        #endregion

        #region Public and private methods - Share

        public ISession? GetSession() => SessionFactory?.OpenSession();

        public void Dispose()
        {
            _sessionFactory?.Dispose();
        }

        #endregion
    }
}
