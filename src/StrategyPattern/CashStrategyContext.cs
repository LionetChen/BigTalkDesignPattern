namespace StrategyPattern;

public class CashStrategyContext
{
    private CashStrategySuper _strategy { get; set; }

    public CashStrategyContext(CashStrategies cashStrategy)
    {
        switch (cashStrategy)
        {
            case CashStrategies.Normal:
                _strategy = new CashStrategyNormal();
                break;
            case CashStrategies.Discount20Percent:
            case CashStrategies.Return100Every300:
            default:
                throw new NotImplementedException($"Strategy {cashStrategy} not implemented yet!");
        }
    }

    public decimal GetResult(decimal money)
    {
        return _strategy.AcceptCash(money);
    }
}
