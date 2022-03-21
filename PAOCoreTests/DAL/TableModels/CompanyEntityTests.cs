// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using NUnit.Framework;
using PAOCore.DAL.Models;
using PAOCore.DAL.TableModels;
using System.Collections.Generic;

namespace PAOCoreTests.DAL.TableModels
{
    [TestFixture]
    internal class CompanyEntityTests
    {
        private CompanyEntity? GetTestCompany()
        {
            if (TestsUtils.AppSettings.DataAccess != null)
            {
                CompanyEntity? company = TestsUtils.AppSettings.DataAccess.Crud.GetEntity<CompanyEntity>(
                    new FieldListEntity(new Dictionary<string, object> { { "Name", "Владимирскииииий стандартттт" } }), null);
                if (company != null)
                    return company;
                else 
                    TestContext.WriteLine($"Тестовые данные отсутсвуют");
            }
            return null;
        }

        [Test]
        public void CompanyEntity_Ctor_DoesNotThrow()
        {
            TestsUtils.MethodStart();

            Assert.DoesNotThrow(() =>
            {
                CompanyEntity company = new();
                TestContext.WriteLine($"{nameof(company).ToUpper()}: {company}");
            });

            TestsUtils.MethodComplete();
        }

        [Test]
        public void CompanyEntity_GetEntities_DoesNotThrow()
        {
            TestsUtils.MethodStart();

            Assert.DoesNotThrow(() =>
            {
                if (TestsUtils.AppSettings.DataAccess != null)
                {
                    CompanyEntity[]? companies = TestsUtils.AppSettings.DataAccess.Crud.GetEntities<CompanyEntity>(null, null);
                    if (companies != null)
                    {
                        foreach (CompanyEntity company in companies)
                        {
                            TestContext.WriteLine($"{company}");
                        }
                    }
                }
            });

            TestsUtils.MethodComplete();
        }

        [Test]
        public void ComapanyEntity_GetEntitiesWithFilter_DoesNotThrow()
        {
            TestsUtils.MethodStart();

            Assert.DoesNotThrow(() =>
            {
                CompanyEntity? company = GetTestCompany();
                if (company != null)
                    TestContext.WriteLine($"{company}");

            });
            TestsUtils.MethodComplete();
        }

        [Test]
        public void CompanyEntity_ChangedEntitiesSave_IsValid()
        {
            TestsUtils.MethodStart();
            if (TestsUtils.AppSettings.DataAccess != null)
            {
                CompanyEntity? oldCompany = GetTestCompany();

                if (oldCompany == null) return;

                oldCompany.Kpp = TestsUtils.RandomizeText(9);
                TestsUtils.AppSettings.DataAccess.Crud.UpdateEntity(oldCompany);
                CompanyEntity? actualCompany = GetTestCompany();

                if (actualCompany != null) Assert.IsTrue(oldCompany.Kpp == actualCompany.Kpp);
            }                                        

            TestsUtils.MethodComplete();
        }
    }
}