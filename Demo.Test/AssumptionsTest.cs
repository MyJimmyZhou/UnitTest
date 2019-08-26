using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Test
{
    public class AssumptionsTest
    {
        [Test]
        public void Test()
        {
            Assert.That("string", Is.Not.Empty);
            Assume.That(true, Is.True);
        }
    }
}
