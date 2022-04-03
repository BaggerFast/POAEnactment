// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using FluentNHibernate.Conventions;
using NHibernate;
using NHibernate.Criterion;
using PAOCore.DAL.TableModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace PAOCore.DAL.Models
{
    public class CrudController
    {
        #region Public and private fields and properties

        public DataAccessEntity DataAccess { get; private set; }
        public DataConfigurationEntity DataConfig { get; private set; }
        public ISessionFactory? SessionFactory { get; private set; }
        private delegate void ExecCallback(ISession session);

        #endregion

        #region Constructor and destructor

        public CrudController(DataAccessEntity dataAccess, ISessionFactory? sessionFactory)
        {
            DataAccess = dataAccess;
            DataConfig = new DataConfigurationEntity();
            SessionFactory = sessionFactory;
        }

        #endregion

        #region Public and private methods

        public ISession? GetSession() => SessionFactory?.OpenSession();

        private ICriteria GetCriteria<T>(ISession session, FieldListEntity? fieldList, FieldOrderEntity? order, int maxResults)
            where T : BaseEntity, new()
        {
            Type type = typeof(T);
            ICriteria criteria = session.CreateCriteria(type);
            if (maxResults > 0)
            {
                criteria.SetMaxResults(maxResults);
            }
            if (fieldList is { Use: true, Fields: { } })
            {
                AbstractCriterion fieldsWhere = Restrictions.AllEq(fieldList.Fields);
                criteria.Add(fieldsWhere);
            }
            if (order != null && order is { Use: true })
            {
                Order fieldOrder = order.Direction == ShareEnums.DbOrderDirection.Asc
                    ? Order.Asc(order.Name.ToString()) : Order.Desc(order.Name.ToString());
                criteria.AddOrder(fieldOrder);
            }
            return criteria;
        }

        private void ExecuteTransaction(ExecCallback callback, 
            string filePath, int lineNumber, string memberName)
        {
            using ISession? session = GetSession();
            if (session != null)
            {
                using ITransaction transaction = session.BeginTransaction();
                try
                {
                    callback?.Invoke(session);
                    session.Flush();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Exception innerEx = new($"{nameof(filePath)}: {filePath}." + $"{nameof(lineNumber)}: {lineNumber}. " + 
                        $"{nameof(memberName)}: {memberName}. ");
                    throw new Exception(ex.Message, innerEx);
                }
                finally
                {
                    session.Disconnect();
                }
            }
        }

        public ISQLQuery? GetSqlQuery(ISession session, string query)
        {
            if (string.IsNullOrEmpty(query))
                return null;

            return session.CreateSQLQuery(query);
        }

        public T[] GetEntitiesWithoutReferences<T>(FieldListEntity? fieldList, FieldOrderEntity? order, int maxResults,
            string filePath, int lineNumber, string memberName) where T : BaseEntity, new()
        {
            T[] result = new T[0];
            ExecuteTransaction((session) =>
            {
                result = GetCriteria<T>(session, fieldList, order, maxResults).List<T>().ToArray();
            }, filePath, lineNumber, memberName);
            return result;
        }

        public void FillReferences<T>(T item) where T : BaseEntity, new()
        {
            switch (item)
            {
                case CompanyEntity company:
                    if (company.Director != null)
                        company.Director = GetEntity<PersonEntity>(company.Director.Uid);
                    break;
                case AddressEntity address:
                    if (address.Company != null)
                        address.Company = GetEntity<CompanyEntity>(address.Company.Uid);
                    break;
                case AuthorityEntity autority:
                    if (autority.Company != null)
                        autority.Company = GetEntity<CompanyEntity>(autority.Company.Uid);
                    break;
                case ManagerEntity manager:
                    if (manager.Fio != null)
                        manager.Fio = GetEntity<PersonEntity>(manager.Fio.Uid);
                    break;
                case PassportEntity passport:
                    if (passport.Manager != null)
                        passport.Manager = GetEntity<ManagerEntity>(passport.Manager.Uid);
                    break;
            }
        }

        public T GetEntity<T>(FieldListEntity? fieldList, FieldOrderEntity? order,
            [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string memberName = "")
            where T : BaseEntity, new()
        {
            T? item = new();
            ExecuteTransaction((session) =>
            {
                ICriteria criteria = GetCriteria<T>(session, fieldList, order, 1);
                IList<T>? list = criteria?.List<T>();
                item = list == null ? new T() : list.FirstOrDefault() ?? new T();
            }, filePath, lineNumber, memberName);
            FillReferences(item);
            return item;
        }

        public T GetEntity<T>(long id) where T : BaseEntity, new()
        {
            return GetEntity<T>(
                new FieldListEntity(new Dictionary<string, object?> { { ShareEnums.DbField.Id.ToString(), id } }),
                new FieldOrderEntity(ShareEnums.DbField.Id, ShareEnums.DbOrderDirection.Desc));
        }

        public T GetEntity<T>(Guid uid) where T : BaseEntity, new()
        {
            return GetEntity<T>(
                new FieldListEntity(new Dictionary<string, object?> { { ShareEnums.DbField.Uid.ToString(), uid } }),
                new FieldOrderEntity(ShareEnums.DbField.Uid, ShareEnums.DbOrderDirection.Desc));
        }

        public T[]? GetEntities<T>(FieldListEntity? fieldList, FieldOrderEntity? order, int maxResults = 0,
            [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string memberName = "")
            where T : BaseEntity, new()
        {
            T[]? items = GetEntitiesWithoutReferences<T>(fieldList, order, maxResults, filePath, lineNumber, memberName);
            if (items != null)
            {
                foreach (T item in items)
                {
                    FillReferences(item);
                }
            }
            return items;
        }

        public T[] GetEntitiesNativeMappingInside<T>(string query, string filePath, int lineNumber, string memberName) where T : BaseEntity, new()
        {
            T[] result = new T[0];
            ExecuteTransaction((session) =>
            {
                ISQLQuery? sqlQuery = GetSqlQuery(session, query);
                if (sqlQuery != null)
                {
                    sqlQuery.AddEntity(typeof(T));
                    System.Collections.IList listEntities = sqlQuery.List();
                    result = new T[listEntities.Count];
                    for (int i = 0; i < result.Length; i++)
                    {
                        result[i] = (T)listEntities[i];
                    }
                }
            }, filePath, lineNumber, memberName);
            return result;
        }

        public T[] GetEntitiesNativeMapping<T>(string query,
            [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string memberName = "")
            where T : BaseEntity, new()
            => GetEntitiesNativeMappingInside<T>(query, filePath, lineNumber, memberName);

        public object[] GetEntitiesNativeObject(string query,
            [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string memberName = "")
        {
            object[] result = new object[0];
            ExecuteTransaction((session) =>
            {
                ISQLQuery? sqlQuery = GetSqlQuery(session, query);
                if (sqlQuery != null)
                {
                    System.Collections.IList listEntities = sqlQuery.List();
                    result = new object[listEntities.Count];
                    for (int i = 0; i < result.Length; i++)
                    {
                        if (listEntities[i] is object[] records)
                            result[i] = records;
                        else
                            result[i] = listEntities[i];
                    }
                }
            }, filePath, lineNumber, memberName);
            return result;
        }

        public int ExecQueryNativeInside(string query, Dictionary<string, object> parameters, string filePath, int lineNumber, string memberName)
        {
            int result = 0;
            ExecuteTransaction((session) =>
            {
                ISQLQuery? sqlQuery = GetSqlQuery(session, query);
                if (sqlQuery != null && parameters != null)
                {
                    foreach (KeyValuePair<string, object> parameter in parameters)
                    {
                        if (parameter.Value is byte[] imagedata)
                            sqlQuery.SetParameter(parameter.Key, imagedata);
                        else
                            sqlQuery.SetParameter(parameter.Key, parameter.Value);
                    }
                    result = sqlQuery.ExecuteUpdate();
                }
            }, filePath, lineNumber, memberName);
            return result;
        }

        public int ExecQueryNative(string query, Dictionary<string, object> parameters,
            [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string memberName = "")
            => ExecQueryNativeInside(query, parameters, filePath, lineNumber, memberName);

        public void SaveEntity<T>(T item,
            [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string memberName = "")
            where T : BaseEntity, new()
        {
            switch (item)
            {
                case AddressEntity address:
                    ExecuteTransaction((session) =>
                    {
                        session.Save(address);
                    }, filePath, lineNumber, memberName);
                    break;
                //
            }
        }

        public void UpdateEntity<T>(T item,
            [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string memberName = "")
            where T : BaseEntity, new()
        {
            switch (item)
            {
                default:
                    ExecuteTransaction((session) => { session.SaveOrUpdate(item); }, filePath, lineNumber, memberName);
                    break;
            }
        }

        public void DeleteEntity<T>(T item,
            [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string memberName = "")
            where T : BaseEntity, new()
        {
            ExecuteTransaction((session) => { session.Delete(item); }, filePath, lineNumber, memberName);
        }

        public bool ExistsEntityInside<T>(T item, string filePath, int lineNumber, string memberName) where T : BaseEntity, new()
        {
            bool result = false;
            ExecuteTransaction((session) =>
            {
                result = session.Query<T>().Any(x => x.IsAny(item));
            }, filePath, lineNumber, memberName);
            return result;
        }

        public bool ExistsEntity<T>(T item,
            [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string memberName = "")
            where T : BaseEntity, new()
        {
            return ExistsEntityInside(item, filePath, lineNumber, memberName);
        }

        public bool ExistsEntityInside<T>(FieldListEntity fieldList, FieldOrderEntity? order,
            string filePath, int lineNumber, string memberName) where T : BaseEntity, new()
        {
            bool result = false;
            ExecuteTransaction((session) =>
            {
                result = GetCriteria<T>(session, fieldList, order, 1).List<T>().Count > 0;
            }, filePath, lineNumber, memberName);
            return result;
        }

        public bool ExistsEntity<T>(FieldListEntity fieldList, FieldOrderEntity? order,
            [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string memberName = "")
            where T : BaseEntity, new()
        {
            return ExistsEntityInside<T>(fieldList, order, filePath, lineNumber, memberName);
        }

        #endregion
    }
}
