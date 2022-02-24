// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using PAOCoreTests;
using NUnit.Framework;
using PAOCore.DAL.TableModels;

namespace PAOCoreTests.DAL.TableModels
{
    [TestFixture]
    internal class PassportEntityTests
    {
        [Test]
        public void PassportEntity_Ctor_DoesNotThrow()
        {
            TestsUtils.MethodStart();

            Assert.DoesNotThrow(() =>
            {
                PassportEntity passport = new();
                TestContext.WriteLine($"{nameof(passport).ToUpper()}: {passport}");
            });

            TestsUtils.MethodComplete();
        }
    }
}