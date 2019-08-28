using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Telerik.JustMock;

namespace JustMockUnitTestSample.ThrowsTest
{
    public class ThrowsTestSample
    {
        [Test]
        public void ShouldThrowExceptionOnMethodCall()
        {
            // Arrange 
            var foo = Mock.Create<IFoo>();

            Mock.Arrange(() => foo.Execute(string.Empty)).Throws<ArgumentException>();

            Assert.Throws<ArgumentException>(() => foo.Execute(string.Empty));
        }
    }
}
