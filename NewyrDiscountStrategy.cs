using DiscountStrategy.Models;

class NewyrDiscountStrategy : IDiscountStrategy
{
    public double CalculateDiscount(Order order)
    {
        return 15;
    }
}