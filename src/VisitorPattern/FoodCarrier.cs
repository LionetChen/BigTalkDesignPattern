namespace VisitorPattern;

public abstract class FoodCarrier
{
    public abstract string VisitElephantHouse(ElephantHouse elephantHouse);
    public abstract string VisitMonkeyHouse(MonekyHouse monekyHouse);
    public abstract string VisitLionHouse(LionHouse lionHouse);
}