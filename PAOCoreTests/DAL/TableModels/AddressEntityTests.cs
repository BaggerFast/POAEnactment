// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com


using NUnit.Framework;
using PAOCore.DAL.Models;
using PAOCore.DAL.TableModels;
using System.Collections.Generic;

namespace PAOCoreTests.DAL.TableModels
{
    [TestFixture]
    internal class AddressEntityTests
    {

        public AddressEntityTests()
        {
            TestsUtils.Setup();
        }

        private AddressEntity? GetTestAddress()
        {
            if (TestsUtils.AppSettings.DataAccess != null)
            {
                AddressEntity? address = TestsUtils.AppSettings.DataAccess.Crud.GetEntity<AddressEntity>(
                    new FieldListEntity(new Dictionary<string, object> { { "Company.name", "���������������� �����������" } }), null);
                if (address != null)
                    return address;
                TestContext.WriteLine($"�������� ������ ����������");
            }
            return null;
        }

        [Test]
        public void AddressEntity_Ctor_DoesNotThrow()
        {
            TestsUtils.MethodStart();

            Assert.DoesNotThrow(() =>
            {
                AddressEntity address = new();
                TestContext.WriteLine($"{nameof(address).ToUpper()}: {address}");
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
                    AddressEntity[]? adresses = TestsUtils.AppSettings.DataAccess.Crud.GetEntities<AddressEntity>(null, null);
                    if (adresses != null)
                        foreach (AddressEntity address in adresses)
                            TestContext.WriteLine($"{address}");
                }
            });

            TestsUtils.MethodComplete();
        }

        [Test]
        public void AddressEntity_GetEntitiesWithFilter_DoesNotThrow()
        {
            TestsUtils.MethodStart();

            Assert.DoesNotThrow(() =>
            {
                AddressEntity? address = GetTestAddress();
                if (address != null)
                    TestContext.WriteLine($"{address}");

            });
            TestsUtils.MethodComplete();
        }
    }

}
