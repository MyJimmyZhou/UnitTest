using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Test
{
    public class CollectionAssertTest
    {
        [Test]
        public void Equal_Test()
        {
            List<int> expected = new List<int> { 1, 2, 3 };
            List<int> actual = new List<int> { 2, 3, 1 };
            CollectionAssert.AreNotEqual(expected, actual);//集合元素位置不同，不相等
            actual = new List<int> { 1, 2, 3 };
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void ItemsOfType_Test()
        {
            List<object> cols = new List<object> { "1", "2", "b" };
            CollectionAssert.AllItemsAreInstancesOfType(cols, typeof(string));
        }
    }
}
