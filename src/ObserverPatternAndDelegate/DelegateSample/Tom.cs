using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObserverPatternAndDelegate.DelegateSample
{
    public class Tom
    {
        public delegate void EventHandler();

        public event EventHandler TomShowedUp = null!;

        public void ShowsUp()
        {
            TomShowedUp();
        }
    }
}