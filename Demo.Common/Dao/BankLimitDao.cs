using System;
using System.Collections.Generic;
using System.Text;
using Demo.Common.Enties;

namespace Demo.Common.Dao
{
    public class BankLimitDao : IBankLimitDao
    {
        public BankLimit GetBankLimit(string accountId)
        {
            return new BankLimit
            {
                AccountId = accountId,
                TotalDrawTotal = 10000,
                TotalTransferTotal = 50000
            };
        }

        public double TodalDrawTotal(string accountId)
        {
            return 10000;
        }

        public double TotalTransferTotal(string accountId)
        {
            return 50000;
        }
    }
}
