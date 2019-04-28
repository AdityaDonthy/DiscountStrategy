namespace DiscountStrategy.Models
{
    public class Order
    {
        public enum DiscountCoupons
        {
            XMAS = 100,
            BLACKFRI = 200,
            NEWYR = 300,
        };

        public DiscountCoupons Coupons { get; set; }
        public int OrderId { get; set; }
        public double OrderTotal { get; set; }
    }
}