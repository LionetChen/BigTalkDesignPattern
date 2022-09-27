using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern;
public class BananaCarrier : FoodCarrier
{
    public override string VisitElephantHouse(ElephantHouse elephantHouse)
    {
        string action = $"Fed bananas to elephants with skins. Cleaned {elephantHouse.ElephantPoops} poops";
        elephantHouse.ElephantPoops = 0;
        return action;
    }

    public override string VisitLionHouse(LionHouse lionHouse)
    {
        return "Lions don't eat bananas";
    }

    public override string VisitMonkeyHouse(MonekyHouse monekyHouse)
    {
        return "Fed bananas to monkeys without skins";
    }
}
