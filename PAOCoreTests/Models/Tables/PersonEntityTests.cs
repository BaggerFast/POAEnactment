// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using PAOCoreTests;
using NUnit.Framework;
using PAOCore.Models.Tables;

namespace PAOTests
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
    }
}