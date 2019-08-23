using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Test
{
    public class TestCaseTest
    {
        [TestCase(12, 3, 4)]
        [TestCase(12, 2, 6)]
        [TestCase(12, 4, 3)]
        public void DivideTest(int n, int d, int q)
        {
            Assert.AreEqual(q, n / d);
        }

        /// <summary>
        /// TestCase 可以包含条件属性：Author、Category、Description、ExcludePlatform、ExpectedResult、Explicit、Ignore、IgnoreReason、IncludePlatform、Reason、TestName、TestOf 
        /// </summary>
        /// <param name="n"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        [TestCase(12, 3, ExpectedResult = 4)]
        [TestCase(12, 2, ExpectedResult = 6)]
        [TestCase(12, 4, ExpectedResult = 3)]
        public int DivideTest(int n, int d)
        {
            return n / d;
        }
    }
}
