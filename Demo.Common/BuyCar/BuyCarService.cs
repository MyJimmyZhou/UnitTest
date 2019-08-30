using Demo.Common.BuyCar.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Common.BuyCar
{
    public class BuyCarService
    {
        private readonly UserService userService = new UserService();
        public bool BuyCar(long userId, long carId)
        {
            //方便操作，直接构造car的模型
            Car car = new Car
            {
                CarId = carId,
                Price = 220000.00
            };
            //执行购买，用户支付
            bool result = userService.PayMoney(userId, car.Price);
            //略去汽车减库存等系列操作
            return result;
        }
    }
}
