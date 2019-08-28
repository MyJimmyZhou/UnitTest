using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Telerik.JustMock;

namespace JustMockUnitTestSample.WhenTest
{
    public class WhenTestSample
    {
        [Test]
        public void IsCalled_ShouldReturnTrue_WithMockedDependencies()
        {
            var foo = Mock.Create<IFoo>();

            Mock.Arrange(() => foo.Prop).Returns("test");//设置Prop返回"Test"
            Mock.Arrange(() => foo.IsCalled()).When(() => foo.Prop == "test").Returns(true);

            Assert.IsTrue(foo.IsCalled());
        }
    }
}
