using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Telerik.JustMock;

namespace JustMockUnitTestSample.RaisesTest
{
    public class RaisesTesmSample
    {
        [Test]
        public void ShouldRaiseCustomEventOnMethodCall()
        {
            string actual = string.Empty;
            bool isCalled = false;

            var foo = Mock.Create<IFoo>();

            foo.CustomEvent += (s, c) => { actual = s; isCalled = c; };
            Mock.Arrange(() => foo.RaiseMethod()).Raises(() => foo.CustomEvent += null, "ping", true);

            foo.RaiseMethod();//调用方法，触发事件

            Assert.AreEqual("ping", actual);
            Assert.IsTrue(isCalled);
        }

        [Test]
        public void FireCustomEventWhenExpectationIsMet()
        {
            bool isCalled = false;

            // Arrange 
            var foo = Mock.Create<IFoo>();

            Mock.Arrange(() => foo.Execute(Arg.Matches<string>((s) => string.IsNullOrEmpty(s))))
                .Raises(() => foo.ExecuteEvent += null);

            foo.ExecuteEvent += delegate { isCalled = true; };

            // Act 
            foo.Execute(string.Empty);

            // Assert 
            Assert.IsTrue(isCalled);
        }
    }
}
