using DiscountStrategy.Models;

public static class OrderFactory
    {

        public static Order CreateOrder_XMAS()
        {
            return new Order()
            {
                Coupons = Order.DiscountCoupons.XMAS
            };
        }

        public static Order CreateOrder_NEWYR()
        {
           return new Order()
            {
                Coupons = Order.DiscountCoupons.NEWYR
            };
        }

        public static Order CreateOrder_BLACKFRI()
        {
            return new Order()
            {
                Coupons = Order.DiscountCoupons.BLACKFRI
            };
        }
    }
