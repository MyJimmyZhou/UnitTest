using Demo.Common.BuyCar.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Common.BuyCar.Dao
{
    public class UserDao
    {
        public User GetUser(long userId)
        {
            return new User
            {
                UserId = userId,
                Money = 10000.00
            };
        }

        public bool UpdateMoney(long userId, double money)
        {
            //执行更新操作，返回true
            return true;
        }
    }
}
