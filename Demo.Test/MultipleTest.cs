using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Test
{
    public class MultipleTest
    {
        [Test]
        public void AssertTest()
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(5.2, 5.2, "Real part");
                Assert.AreEqual(3.9, 3.9, "Imaginary part");
            });
        }

        //[Test]
        //public void AssumeTest()
        //{
        //    Assert.Multiple(() =>
        //    {
        //        Assume.That("1", Is.Null);
        //        Assume.That("1", Is.Not.Empty);
        //    });

        //}
    }
}
