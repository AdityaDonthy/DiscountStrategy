namespace DiscountStrategy.Models
{
    public enum DiscountCoupons
        {
            XMAS = 100,
            BLACKFRI = 200,
            NEWYR = 300,
        };
    public class Order
    {
        public DiscountCoupons Coupon { get; set; }
        public int OrderId { get; set; }
        public double OrderTotal { get; set; }
    }
}