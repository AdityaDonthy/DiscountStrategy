using DiscountStrategy.Models;

class BlackfriDiscountStrategy : IDiscountStrategy
{
    public double CalculateDiscount(Order order)
    {
        return 35;
    }
}