using DiscountStrategy;
using NUnit.Framework;
public class DiscountCalculatorServiceTest
    {
        [Test]
        public void When_coupon_is_XMAS_discount_is_25()
        {
            IDiscountStrategy xmasDiscount = new XmasDiscountSrtategy();
            var discountCalculatorService = new DiscountCalculatorService(xmasDiscount);
            var order = OrderFactory.CreateOrder_XMAS();
            var discount = discountCalculatorService.CalculateDiscount(order);
            Assert.AreEqual(25, discount);
        }

        [Test]
        public void  When_coupon_is_NEWYR_discount_is_15()
        {
            IDiscountStrategy NewyrDiscount = new NewyrDiscountStrategy();
            var discountCalculatorService = new DiscountCalculatorService(NewyrDiscount);
            var order = OrderFactory.CreateOrder_NEWYR();
            var discount = discountCalculatorService.CalculateDiscount(order);
            Assert.AreEqual(15, discount);
        }

        [Test]
        public void  When_coupon_is_BLACKFRI_discount_is_35()
        {
            IDiscountStrategy blackFriDiscount = new BlackfriDiscountStrategy();
            var discountCalculatorService = new DiscountCalculatorService(blackFriDiscount);
            var order = OrderFactory.CreateOrder_BLACKFRI();
            var discount = discountCalculatorService.CalculateDiscount(order);
            Assert.AreEqual(35d, discount);
        }
    }