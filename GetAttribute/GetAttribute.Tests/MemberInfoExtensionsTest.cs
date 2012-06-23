using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GetAttribute.Tests
{
    [TestClass]
    public class MemberInfoExtensionsTest : TestClassBase
    {
        [TestMethod]
        public void GetAttribute_returns_instance()
        {
            var configAttr = typeof(Customer).GetAttribute<ConfigurationAttribute>();
            Assert.IsNotNull(configAttr);
        }

        [TestMethod]
        public void GetAttribute_returns_null_if_not_found()
        {
            var configAttr = typeof(ClassWithoutAttribute).GetAttribute<ConfigurationAttribute>();
            Assert.IsNull(configAttr);
        }

        [TestMethod]
        public void GetAttribute_throws_if_not_found_and_throwIfNotFound_is_true()
        {
            AssertExpectedException<ApplicationException>(
                () => typeof(ClassWithoutAttribute).GetAttribute<ConfigurationAttribute>(throwIfMissing: true));
        }
    }

    internal class ClassWithoutAttribute
    {

    }
}
