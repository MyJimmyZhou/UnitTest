using Demo.Common;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Test
{
    public class AssertTest
    {
        public void AreEqual_Test()
        {
            Assert.AreEqual(5, 5.0, 5.00);//Successed.double 和 int 会内部转化比较。
            //Assert.AreEqual(5.0, "5.0");//Failed.double和string类型不能相互比较。
            List<Dictionary<int, string>> dic1 = new List<Dictionary<int, string>>
            {
                new Dictionary<int, string>(){ { 1,"one"},{2,"two" } }
            };
            List<Dictionary<int, string>> dic2 = new List<Dictionary<int, string>>
            {
                new Dictionary<int, string>(){{1,"one"}, { 2, "two" } }
            };
            Assert.AreEqual(dic1, dic2);//Successed.泛型也可以比价，会比较内部的值，且只能一一对应。
            List<int> list = new List<int> { 1, 3, 2 };
            List<double> list2 = new List<double> { 1.0, 2.0, 3.0 };
            //Assert.AreEqual(list, list2);//Failed.
        }

        [Test]
        public void AreSame_Test()
        {
            BankAccount A = new BankAccount(1000);
            BankAccount B = A;
            Assert.AreSame(A, B);// Successed 引用类型对象
            double a = 5;
            double b = 5;
            //Assert.AreSame(a, b);//Failed 值类型两个值相同对象不相同。
        }
    }
}
