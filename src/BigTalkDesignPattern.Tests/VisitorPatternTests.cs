using VisitorPattern;

namespace BigTalkDesignPattern.Tests;
[TestClass]
public class VisitorPatternTests
{
    readonly ElephantHouse _elephantHouse = new();
    readonly MonekyHouse _monekyHouse = new();
    readonly LionHouse _lionHouse = new();

    readonly List<FoodCarrier> FoodCarriers;
    readonly List<IVisitable> AnimalHhouses;

    public VisitorPatternTests()
    {
        FoodCarriers = new List<FoodCarrier>()
        {
            new MeatCarrier(),
            new BananaCarrier(),
            new PeanutCarrier()
        };

        AnimalHhouses = new List<IVisitable>()
        {
            _elephantHouse,
            _monekyHouse,
            _lionHouse,
        };
    }

    [TestMethod]
    public void VisitorPatternTest()
    {
        int resultIndex = 0;
        List<string> expectedResult = new()
        {
            // MeatCarrier
            "Elephants don't eat meat. Cleaned 10 poops",
            "Monkeys don't eat meat",
            "Fed meat to lions: Simba, Nala",
            // BananaCarrier
            "Fed bananas to elephants with skins. Cleaned 0 poops",
            "Fed bananas to monkeys without skins",
            "Lions don't eat bananas",
            // PeanutCarrier
            "Elephants don't eat peanuts. Cleaned 0 poops",
            "Refilled peanuts to snack tray",
            "Lions don't eat peanuts",
        };

        foreach (FoodCarrier carrier in FoodCarriers)
        {
            foreach (IVisitable house in AnimalHhouses)
            {
                Assert.AreEqual(expectedResult[resultIndex], house.Accept(carrier));
                resultIndex++;
            }
        }

        Assert.AreEqual(0, _elephantHouse.ElephantPoops);
        Assert.AreEqual("Peanuts", _monekyHouse.SnackTray);
    }
}