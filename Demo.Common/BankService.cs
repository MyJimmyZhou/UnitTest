using Demo.Common.Dao;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Common
{
    public class BankService : IBankService
    {
        private readonly IBankLimitDao _bankLimitDao;

        public BankService(IBankLimitDao bankLimitDao)
        {
            _bankLimitDao = bankLimitDao;
        }

        /// <summary>
        /// 转账
        /// </summary>
        /// <param name="accountA"></param>
        /// <param name="accountB"></param>
        /// <param name="money"></param>
        /// <returns></returns>
        public double TransferAccounts(BankAccount accountA, BankAccount accountB, double money)
        {
            double transferLimit = 50000.0;//转账最高限制
            try
            {
                //判断A是否能转账
                var total = _bankLimitDao.TotalTransferTotal(accountA.AccountId);
                if (total >= transferLimit)
                {
                    throw new Exception($"超过当日转账限额{transferLimit}");
                }
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
