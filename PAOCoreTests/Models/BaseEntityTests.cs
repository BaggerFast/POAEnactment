// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using CoreTests;
using NUnit.Framework;
using PAOÑore;

namespace PAOTests
{
    [TestFixture]
    internal class BaseEntityTests
    {
        [Test]
        public void BaseEntity_Ctor_DoesNotThrow()
        {
            TestsUtils.MethodStart();

            Assert.DoesNotThrow(() =>
            {
                BaseEntity @base = new();
                TestContext.WriteLine($"{nameof(@base)}: {@base}");
            });

            TestsUtils.MethodComplete();
        }
    }
}
