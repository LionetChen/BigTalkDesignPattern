using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern;
public class MonekyHouse : IVisitable
{
    public string SnackTray { get; set; } = string.Empty;

    public string Accept(FoodCarrier carrier)
    {
        return carrier.VisitMonkeyHouse(this);
    }
}
