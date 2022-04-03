// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com


using NUnit.Framework;
using PAOCore.DAL.TableModels;

namespace PAOCoreTests.DAL.TableModels
{
    [TestFixture]
    internal class AddressEntityTests
    {

        public AddressEntityTests()
        {
            TestsUtils.Setup();
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

    }

}
