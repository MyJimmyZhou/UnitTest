using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Telerik.JustMock;

namespace JustMockUnitTestSample.RaiseTest
{
    public class TestSample
    {
        [Test]
        public void ShouldInvokeMethodForACustomEventWhenRaised()
        {
            string expected = "ping";
            string actual = string.Empty;

            var foo = Mock.Create<IFoo>();

            foo.CustomEvent += delegate (string s)
            {
                actual = s;
            };

            //引发事件，并传递参数
            Mock.Raise(() => foo.CustomEvent += null, expected);

            Assert.AreEqual(expected, actual);
        }
    }
}
