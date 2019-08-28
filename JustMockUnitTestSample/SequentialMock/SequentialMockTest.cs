using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Telerik.JustMock;

namespace JustMockUnitTestSample.SequentialMock
{
    public class SequentialMockTest
    {
        [Test]
        public void ShouldArrangeAndAssertInASequence()
        {
            // Arrange 
            var foo = Mock.Create<IFoo>();

            Mock.Arrange(() => foo.GetIntValue()).Returns(0).InSequence();
            Mock.Arrange(() => foo.GetIntValue()).Returns(1).InSequence();
            Mock.Arrange(() => foo.GetIntValue()).Returns(2).InSequence();

            // Act 
            int actualFirstCall = foo.GetIntValue();
            int actualSecondCall = foo.GetIntValue();
            int actualThirdCall = foo.GetIntValue();
            int actualFourthCall = foo.GetIntValue();
            // Assert 
            Assert.AreEqual(0, actualFirstCall);
            Assert.AreEqual(1, actualSecondCall);
            Assert.AreEqual(2, actualThirdCall);
            Assert.AreEqual(2, actualFourthCall);
        }
    }
}
