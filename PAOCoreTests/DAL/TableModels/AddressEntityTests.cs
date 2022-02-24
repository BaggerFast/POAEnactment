// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using PAOCore.DAL.Models;
using PAOCore.DAL.TableModels;
using PAOCore.Models;
using PAOCoreTests;
using System.Collections.Generic;
using System.Linq;

namespace PAOCoreTests.DAL.TableModels
{
    [TestFixture]
    internal class AddressEntityTests
    {
        #region Public and private fields and properties


        #endregion

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
    }
}
