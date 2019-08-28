using System;

namespace Demo.Common
{
    public class BankAccount
    {
        public string AccountId;
        private double _balance;

        public BankAccount(double money)
        {
            _balance = money;
            AccountId = new Guid().ToString();
        }

        public double GetBalance()
        {
            return _balance;
        }
        public double SaveMoney(double money)
        {
            if (money < 0)
                throw new Exception("存入金额错误!");
            _balance += money;
            return _balance;
        }
        public double DrawMoney(double money)
        {
            if (money > _balance)
                throw new Exception("余额不足!");
            _balance -= money;
            return _balance;
        }
    }
}
