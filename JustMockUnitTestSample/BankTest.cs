using Demo.Common;
using Demo.Common.Dao;
using NUnit.Framework;
using Telerik.JustMock;

namespace Tests
{
    public class BankTest
    {
        private BankAccount bankAccountA;
        private BankAccount bankAccountB;

        [SetUp]
        public void Setup()
        {
            bankAccountA = new BankAccount(1000);
            bankAccountB = new BankAccount(1000);
        }

        [Test]
        public void Transfer_Test()
        {
            var bankLimit = Mock.Create<IBankLimitDao>();//ģ�����
            Mock.Arrange(() => bankLimit.TodalDrawTotal(Arg.IsAny<string>())).Returns(500);//�趨һ������ֵ
            IBankService bankService = new BankService(bankLimit);
            bankService.TransferAccounts(bankAccountA, bankAccountB, 500);
            Mock.Assert(bankLimit);
            Assert.AreEqual(500, bankAccountA.GetBalance());
            Assert.AreEqual(1500, bankAccountB.GetBalance());
        }
    }
}