using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GetAttribute.Tests
{
    public class TestClassBase
    {
        public void AssertExpectedException<TException>(Action theAction) where TException : Exception
        {
            try
            {
                theAction();
                Assert.Fail(string.Format("An exception of type {0} was expected", typeof(TException).FullName));
            }
            catch (TException expected)
            {
                if (expected.GetType().FullName != typeof(TException).FullName)
                {
                    Assert.Fail(string.Format("An exception of type {0} was expected but got {1}", typeof(TException).FullName, expected.GetType().FullName));
                }
            }
            catch (Exception e)
            {
                Assert.Fail(string.Format("An exception of type {0} was expected but got {1}", typeof(TException).FullName, e.GetType().FullName));
            }
        }
    }
}
