using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern;
public class LionHouse : IVisitable
{
    /// <summary>
    /// Yeah lions are cats too aren't they?
    /// </summary>
    public List<string> Lions = new () { "Simba", "Nala" };

    public string Accept(FoodCarrier carrier)
    {
        return carrier.VisitLionHouse(this);
    }
}
