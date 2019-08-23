using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Common
{
    public class BankService : IBankService
    {
        public double TransferAccounts(BankAccount accountA, BankAccount accountB, double money)
        {
            try
            {
                var balanceA = accountA.DrawMoney(money);
                accountB.SaveMoney(money);
                return balanceA;
            }
            catch (Exception ex)
            {
                throw new Exception($"转账失败，{ex.Message}");
            }
        }
    }
}
