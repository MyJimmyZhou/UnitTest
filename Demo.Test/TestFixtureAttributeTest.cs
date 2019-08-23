using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Demo.Test
{
    /// <summary>
    /// 使用TestFixture标记会生成三个测试，是每个测试方法执行三次
    /// </summary>
    [TestFixture("hello", "hello", "goodbye")]
    [TestFixture("zip", "zip")]
    [TestFixture(42, 42, 99)]
    public class TestFixtureAttributeTest
    {
        private string eq1;
        private string eq2;
        private string neq;

        public TestFixtureAttributeTest(string eq1, string eq2, string neq)
        {
            this.eq1 = eq1;
            this.eq2 = eq2;
            this.neq = neq;
        }

        public TestFixtureAttributeTest(string eq1, string eq2)
            : this(eq1, eq2, null) { }

        public TestFixtureAttributeTest(int eq1, int eq2, int neq)
        {
            this.eq1 = eq1.ToString();
            this.eq2 = eq2.ToString();
            this.neq = neq.ToString();
        }

        [Test]
        public void TestEquality()
        {
            Assert.AreEqual(eq1, eq2);
            if (eq1 != null && eq2 != null)
                Assert.AreEqual(eq1.GetHashCode(), eq2.GetHashCode());
        }

        [Test]
        public void TestInequality()
        {
            Assert.AreNotEqual(eq1, neq);
            if (eq1 != null && neq != null)
                Assert.AreNotEqual(eq1.GetHashCode(), neq.GetHashCode());
        }
    }

    /// <summary>
    /// 标记TList会以两种类型来执行。
    /// </summary>
    /// <typeparam name="TList"></typeparam>
    [TestFixture(typeof(ArrayList))]
    [TestFixture(typeof(List<int>))]
    public class IList_Tests<TList> where TList : IList, new()
    {
        private IList list;

        [SetUp]
        public void CreateList()
        {
            this.list = new TList();
        }

        [Test]
        public void CanAddToList()
        {
            list.Add(1); list.Add(2); list.Add(3);
            Assert.AreEqual(3, list.Count);
        }
    }
}
