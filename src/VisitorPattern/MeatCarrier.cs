using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern;
public class MeatCarrier : FoodCarrier
{
    public override string VisitElephantHouse(ElephantHouse elephantHouse)
    {
        string action =  $"Elephants don't eat meat. Cleaned {elephantHouse.ElephantPoops} poops";
        elephantHouse.ElephantPoops = 0;
        return action;
    }

    public override string VisitLionHouse(LionHouse lionHouse)
    {
        string action = $"Fed meat to lions: {string.Join(", ", lionHouse.Lions)}";
        return action;
    }

    public override string VisitMonkeyHouse(MonekyHouse monekyHouse)
    {
        string action = $"Monkeys don't eat meat";
        return action;
    }
}
