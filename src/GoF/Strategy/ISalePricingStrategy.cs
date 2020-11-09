namespace GoF.Strategy
{
    public interface ISalePricingStrategy
    {
        decimal GetTotal(Sale sale);
    }
}
