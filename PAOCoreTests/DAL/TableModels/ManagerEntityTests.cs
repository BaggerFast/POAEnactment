// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using NUnit.Framework;
using PAOCore.DAL.Models;
using PAOCore.DAL.TableModels;
using System.Collections.Generic;

namespace PAOCoreTests.DAL.TableModels
{
    [TestFixture]
    internal class ManagerEntityTests
    {
        [Test]
        public void ManagerEntity_Ctor_DoesNotThrow()
        {
            TestsUtils.MethodStart();

            Assert.DoesNotThrow(() =>
            {
                ManagerEntity manager = new();
                TestContext.WriteLine($"{nameof(manager).ToUpper()}: {manager}");
            });

            TestsUtils.MethodComplete();
        }

        [Test]
        public void ManagerEntity_GetEntities_DoesNotThrow()
        {
            TestsUtils.MethodStart();

            Assert.DoesNotThrow(() =>
            {
                if (TestsUtils.AppSettings.DataAccess != null)
                {
                    ManagerEntity[]? managers = TestsUtils.AppSettings.DataAccess.Crud.GetEntities<ManagerEntity>(null, null);
                    if (managers != null)
                    {
                        foreach (ManagerEntity manager in managers)
                        {
                            TestContext.WriteLine($"{manager}");
                        }
                    }
                }
            });

            TestsUtils.MethodComplete();
        }

        [Test]
        public void ManagerEntity_GetTestEntity()
        {

            TestsUtils.MethodStart();

            ManagerEntity? manager = null;

            if (TestsUtils.AppSettings.DataAccess != null)
            {
                manager = TestsUtils.AppSettings.DataAccess.Crud.GetEntity<ManagerEntity>(
                    new FieldListEntity(new Dictionary<string, object?> { { "Phone", "89004930393" } }), null);
            }

            Assert.IsTrue(manager != null);

            TestsUtils.MethodComplete();
        }

    }
}