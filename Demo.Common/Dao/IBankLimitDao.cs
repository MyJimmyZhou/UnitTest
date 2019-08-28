using Demo.Common.Enties;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Common.Dao
{
    public interface IBankLimitDao
    {
        double TotalTransferTotal(string accountId);
        double TodalDrawTotal(string accountId);
        BankLimit GetBankLimit(string accountId);
    }
}
