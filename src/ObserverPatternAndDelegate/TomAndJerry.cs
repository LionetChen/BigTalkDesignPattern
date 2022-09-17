using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObserverPatternAndDelegate
{
    public class TomAndJerry : TVShowBase
    {
        public void ShowOn()
        {
            Notify();
        }

        public override void Notify()
        {
            foreach (var audience in _subscriberList)
            {
                audience.Watches(nameof(TomAndJerry));
            }
        }
    }
}