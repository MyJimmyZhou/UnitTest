using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Common
{
    public interface IBankService
    {
        /// <summary>
        /// 实现一个简单地转账逻辑.
        /// </summary>
        /// <param name="accountA"></param>
        /// <param name="accountB"></param>
        /// <param name="money"></param>
        /// <returns></returns>
        double TransferAccounts(BankAccount accountA, BankAccount accountB, double money);
    }
}
