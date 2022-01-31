// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using CoreTests;
using NUnit.Framework;
using PAOCore.Models.Tables;

namespace PAOTests
{
    [TestFixture]
    internal class AddressEntityTests
    {
        [Test]
        public void AddressEntity_Ctor_DoesNotThrow()
        {
            TestsUtils.MethodStart();

            Assert.DoesNotThrow(() =>
            {
                AddressEntity address = new();
                TestContext.WriteLine($"{nameof(address)}: {address}");
            });

            TestsUtils.MethodComplete();
        }
    }
}
