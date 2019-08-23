using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Test
{
    public class FirstTestClass
    {
        [Test]
        public void FirstTestMethod()
        {
            bool result = true;
            Assert.IsTrue(result);
            Warn.If(2 + 2 != 5);

            //Assert.That("1", Is.Null.Or.Empty);
        }
    }
}
