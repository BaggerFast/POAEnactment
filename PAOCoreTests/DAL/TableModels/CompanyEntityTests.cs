// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using PAOCoreTests;
using NUnit.Framework;
using PAOCore.DAL.TableModels;
using System.Collections.Generic;
using System.Linq;
using PAOCore.DAL.Models;

namespace PAOCoreTests.DAL.TableModels
{
    [TestFixture]
    internal class CompanyEntityTests
    {
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
        public void AddressEntity_GetEntities_DoesNotThrow()
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
    }
}