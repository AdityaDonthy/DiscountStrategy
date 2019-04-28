using DiscountStrategy.Models;

class XmasDiscountSrtategy : IDiscountStrategy
{
    public double CalculateDiscount(Order order)
    {
        return 25;
    }
}