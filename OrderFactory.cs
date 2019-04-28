using DiscountStrategy.Models;

public static class OrderFactory
    {

        public static Order CreateOrder_XMAS()
        {
            return new Order()
            {
                Coupon = DiscountCoupons.XMAS,
                OrderId = 100,
                OrderTotal = 323
            };
        }

        public static Order CreateOrder_NEWYR()
        {
           return new Order()
            {
                Coupon = DiscountCoupons.NEWYR,
                OrderId = 200,
                OrderTotal = 492
            };
        }

        public static Order CreateOrder_BLACKFRI()
        {
            return new Order()
            {
                Coupon = DiscountCoupons.BLACKFRI,
                OrderId = 300,
                OrderTotal = 8722
            };
        }
    }
