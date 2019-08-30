using Demo.Common.BuyCar.Dao;
using Demo.Common.BuyCar.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Common.BuyCar
{
    public class UserService
    {
        private readonly UserDao userDao;
        public User GetUser(long userId)
        {
            return userDao.GetUser(userId);
        }

        public bool PayMoney(long userId, double money)
        {
            User user = GetUser(userId);
            user.Money += money;
            if (user.Money < 0)
                return false;
            else
            {
                return userDao.UpdateMoney(userId, money);
            }
        }
    }
}
