using DiscountStrategy.Models;

namespace DiscountStrategy
{
 public class DiscountCalculatorService
    {
        public double CalculateDiscount(Order order)
        {
            switch (order.Coupons)
            {
                case Order.DiscountCoupons.XMAS:
                    return CalculateForXMAS(order);

                case Order.DiscountCoupons.NEWYR:
                    return CalculateForNEWYR(order);

                case Order.DiscountCoupons.BLACKFRI:
                    return CalculateForBLACKFRI(order);
                
                default: return 0;
            }

        }

        double CalculateForXMAS(Order order)
        {
            return 25;
        }

        double CalculateForNEWYR(Order order)
        {
            return 15;
        }

        double CalculateForBLACKFRI(Order order)
        {
            return 35.00d;
        }
    }
}