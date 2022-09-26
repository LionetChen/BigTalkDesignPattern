using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern;
public class PeanutCarrier : FoodCarrier
{
    public override string VisitElephantHouse(ElephantHouse elephantHouse)
    {
        string action = $"Elephants don't eat peanuts. Cleaned {elephantHouse.ElephantPoops} poops";
        elephantHouse.ElephantPoops = 0;
        return action;
    }

    public override string VisitLionHouse(LionHouse lionHouse)
    {
        string action = $"Lions don't eat peanuts";
        return action;
    }

    public override string VisitMonkeyHouse(MonekyHouse monekyHouse)
    {
        string action = "Refilled peanuts to snack tray";
        monekyHouse.SnackTray = "Peanuts";
        return action;
    }
}
