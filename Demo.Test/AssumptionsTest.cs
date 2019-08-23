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
            Assert.That("string", Is.Empty);
            Assume.That(true, Is.True);
            Assume.That(false, Is.True);
        }
    }
}
