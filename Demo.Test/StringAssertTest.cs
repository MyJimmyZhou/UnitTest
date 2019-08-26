using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Test
{
    public class StringAssertTest
    {
        [Test]
        public void Contains_Test()
        {
            string expected = "a";//期望值。被包含
            string actual = "acb";//真是值。包含
            StringAssert.Contains(expected, actual);
            expected = "d";
            StringAssert.DoesNotContain(expected, actual);
        }

        [Test]
        public void StartsWith_Test()
        {
            string actual = "dcc";
            string expected = "d";
            StringAssert.StartsWith(expected, actual);
            expected = "c";
            StringAssert.DoesNotStartWith(expected, actual);
        }

        [Test]
        public void EndsWith_Test()
        {
            string actual = "dcc";
            string expected = "c";
            StringAssert.EndsWith(expected, actual);
            expected = "d";
            StringAssert.DoesNotEndWith(expected, actual);
        }

        [Test]
        public void EqualIgnoringCase_Test()
        {
            string actual = "adc";
            string expected = "adc";
            StringAssert.AreEqualIgnoringCase(expected, actual);
            expected = "a";
            StringAssert.AreNotEqualIgnoringCase(expected, actual);
        }

        [Test]
        public void Match_Test()
        {
            string actual = "adc";
            string expected = "adc";
            StringAssert.IsMatch(expected, actual);
            expected = "g";
            StringAssert.DoesNotMatch(expected, actual);
        }
    }
}
