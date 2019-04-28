using DiscountStrategy.Models;

namespace DiscountStrategy
{
 public class DiscountCalculatorService
    {
        IDiscountStrategy _discountStrategy;

        public DiscountCalculatorService(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }
        public double CalculateDiscount(Order order)
        {
           return _discountStrategy.CalculateDiscount(order);
        }
    }
}