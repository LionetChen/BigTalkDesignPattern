using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObserverPatternAndDelegate.DelegateSample
{
    public class Tyke : ObserverBase
    {
        public void BeatsTom()
        {
            State = $"{nameof(Tyke)} beats Tom";
        }
    }
}