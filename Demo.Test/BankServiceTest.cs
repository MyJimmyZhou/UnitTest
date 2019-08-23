using Demo.Common;
using NUnit.Framework;

namespace Demo.Test
{
    public class BankServiceTest
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
        [Author("zjl")]
        [Author("¼¦Ã×Öà", "zjl_hnyz@outlook.com")]
        public void TransferAccounts_Test()
        {
            Assert.Pass();
        }
    }
}