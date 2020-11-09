using GoF.Strategy;

namespace GoF
{
    public class PercentageDiscountStrategy : ISalePricingStrategy
    {
        private readonly decimal _percentageDiscount;

        public PercentageDiscountStrategy(decimal percentageDiscount)
        {
            _percentageDiscount = percentageDiscount;
        }

        public decimal GetTotal(Sale sale)
        {
            return sale.Amount - (sale.Amount / 100m * _percentageDiscount);
        }
    }
}
