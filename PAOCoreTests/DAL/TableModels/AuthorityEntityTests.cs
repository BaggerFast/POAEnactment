// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using PAOCoreTests;
using NUnit.Framework;
using PAOCore.DAL.TableModels;

namespace PAOCoreTests.DAL.TableModels
{
    [TestFixture]
    internal class AuthorityEntityTests
    {
        [Test]
        public void AuthorityEntity_Ctor_DoesNotThrow()
        {
            TestsUtils.MethodStart();

            Assert.DoesNotThrow(() =>
            {
                AuthorityEntity authority = new();
                TestContext.WriteLine($"{nameof(authority).ToUpper()}: {authority}");
            });

            TestsUtils.MethodComplete();
        }

        [Test]
        public void AuthorityEntity_GetEntities_DoesNotThrow()
        {
            TestsUtils.MethodStart();

            Assert.DoesNotThrow(() =>
            {
                if (TestsUtils.AppSettings.DataAccess != null)
                {
                    AuthorityEntity[]? authorities = TestsUtils.AppSettings.DataAccess.Crud.GetEntities<AuthorityEntity>(null, null);
                    if (authorities != null)
                    {
                        foreach (AuthorityEntity authority in authorities)
                        {
                            TestContext.WriteLine($"{authority}");
                        }
                    }
                }
            });

            TestsUtils.MethodComplete();
        }
    }
}