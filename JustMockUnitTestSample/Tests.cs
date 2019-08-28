using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Telerik.JustMock;

namespace JustMockUnitTestSample
{
    public class FooBase
    {
        public string GetString(string str)
        {
            return str;
        }
    }
    public interface IFoo
    {
        void Submit();
        void Echo();
    }
    public class Tests
    {
        [Test]
        public void Test()
        {
            DebugView.IsTraceEnabled = true;
            // Arrange 
            var rlFoo = Mock.Create<FooBase>(Behavior.RecursiveLoose);
            var lFoo = Mock.Create<FooBase>(Behavior.Loose);
            var coFoo = Mock.Create<FooBase>(Behavior.CallOriginal);
            var sFoo = Mock.Create<FooBase>(Behavior.Strict);

            Mock.Arrange(() => rlFoo.GetString("y")).Returns("z");
            Mock.Arrange(() => lFoo.GetString("y")).Returns("z");
            Mock.Arrange(() => coFoo.GetString("y")).Returns("z");
            Mock.Arrange(() => sFoo.GetString("y")).Returns("z");

            // Act 
            var rlactualX = rlFoo.GetString("x"); // 结果：""
            var rlactualY = rlFoo.GetString("y"); // 结果："z"

            var lactualX = lFoo.GetString("x"); // 结果：null
            var lactualY = lFoo.GetString("y"); // 结果："z"

            var coactualX = coFoo.GetString("x"); // 结果："x"
            var coactualY = coFoo.GetString("y"); // 结果："z"
            var coactualA = coFoo.GetString("a"); // 结果："a"

            //var sactualX = sFoo.GetString("x"); // 结果：出现异常
            var sactualY = sFoo.GetString("y"); // 结果："z"  

            var expectedX = "x";
            var expectedY = "z";

            // Assert 
            //Assert.AreEqual(expectedX, rlactualX);
            Assert.AreEqual(expectedY, rlactualY);
        }

        [Test]
        public void ShouldVerifyCallsOrder()
        {
            // Arrange 
            var foo = Mock.Create<IFoo>();

            Mock.Arrange(() => foo.Submit()).InOrder();
            Mock.Arrange(() => foo.Echo()).InOrder();

            // Act 
            foo.Submit();
            foo.Echo();

            // Assert 
            Mock.Assert(foo);
        }

        [Test]
        public void CallOrigin_Test()
        {
            var foo = Mock.Create<FooBase>();

            Mock.Arrange(() => foo.GetString(Arg.AnyString)).CallOriginal();

            var result = foo.GetString("z");

            Mock.Assert(foo);
        }

        [Test]
        public void DoNothing_Test()
        {
            var foo = Mock.Create<FooBase>();

            Mock.Arrange(() => foo.GetString(Arg.AnyString)).DoNothing().MustBeCalled();

            var result = foo.GetString("a");

            Mock.Assert(foo);
        }
    }
}
