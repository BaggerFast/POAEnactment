// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using NUnit.Framework;
using PAOCore.DAL.TableModels;

namespace PAOCoreTests.DAL.TableModels
{
    [TestFixture]
    internal class PersonEntityTests
    {
        [Test]
        public void PersonEntity_Ctor_DoesNotThrow()
        {
            TestsUtils.MethodStart();

            Assert.DoesNotThrow(() =>
            {
                PersonEntity person = new();
                TestContext.WriteLine($"{nameof(person).ToUpper()}: {person}");
            });

            TestsUtils.MethodComplete();
        }

        [Test]
        public void PersonEntity_GetEntities_DoesNotThrow()
        {
            TestsUtils.MethodStart();

            Assert.DoesNotThrow(() =>
            {
                if (TestsUtils.AppSettings.DataAccess != null)
                {
                    PersonEntity[]? persons = TestsUtils.AppSettings.DataAccess.Crud.GetEntities<PersonEntity>(null, null);
                    if (persons != null)
                    {
                        foreach (PersonEntity person in persons)
                        {
                            TestContext.WriteLine($"{person}");
                        }
                    }
                }
            });

            TestsUtils.MethodComplete();
        }
    }
}