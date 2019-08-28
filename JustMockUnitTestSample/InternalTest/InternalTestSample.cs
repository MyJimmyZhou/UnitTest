using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Telerik.JustMock;

namespace JustMockUnitTestSample.InternalTest
{
    public class InternalTestSample
    {
        [Test]
        public void ShouldMockInternalTypeViaProxy()
        {
            var foo = Mock.Create<FooInternal>(Behavior.CallOriginal);

            Assert.IsNotNull(foo.Builder);
        }

        [Test]
        public void ShouldMockAnInterfaceMemberPrivatelyImplementedInBaseClass()
        {
            // Arrange 
            var bar = Mock.Create<Bar>();

            string expected = "dummy";

            Mock.Arrange(() => ((IManager)bar).Provider).Returns("dummy");

            // Act 
            var actual = ((IManager)bar).Provider;

            // Assert 
            Assert.AreEqual(expected, actual);
        }
    }
}
