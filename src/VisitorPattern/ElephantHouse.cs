using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern;
public class ElephantHouse : IVisitable
{
    public int ElephantPoops = 10;

    public string Accept(FoodCarrier carrier)
    {
        return carrier.VisitElephantHouse(this);
    }
}
