using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Test
{
    public class SetUpAndTearDownTest
    {
        [SetUp]
        public void SetUp()
        {
            Console.WriteLine("我在测试前执行");
        }
        [Test]
        public void Test()
        {
            Console.WriteLine("我在测试时执行");
            Assert.Pass();
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("我在测试后执行");
        }
    }
}
