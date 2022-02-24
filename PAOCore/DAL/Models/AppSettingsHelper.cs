// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com/

using PAOCore.Models;
using System.Threading;

namespace PAOCore.DAL.Models
{
    public class AppSettingsHelper
    {
        #region Design pattern "Lazy Singleton"

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private static AppSettingsHelper _instance;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public static AppSettingsHelper Instance => LazyInitializer.EnsureInitialized(ref _instance);

        #endregion

        #region Public and private fields and properties

        public DataAccessEntity? DataAccess { get; private set; } = null;

        #endregion

        #region Public and private methods

        public void SetupJsonSettings(JsonSettingsEntity jsonSettings)
        {
            DataAccess = new DataAccessEntity(jsonSettings);
        }

        #endregion
    }
}
