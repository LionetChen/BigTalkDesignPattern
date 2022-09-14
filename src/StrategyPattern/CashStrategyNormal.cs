namespace StrategyPattern;

public class CashStrategyNormal : CashStrategySuper
{
    public override decimal AcceptCash(decimal originalPrice)
    {
        return originalPrice;
    }
}
