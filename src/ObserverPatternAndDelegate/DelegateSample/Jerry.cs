using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObserverPatternAndDelegate.DelegateSample
{
    public class Jerry : ObserverBase
    {
        public void RunsFromTom()
        {
            State = $"{nameof(Jerry)} runs from Tom";
        }
    }
}