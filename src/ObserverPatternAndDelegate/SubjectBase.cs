using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObserverPatternAndDelegate
{
    public abstract class TVShowBase
    {
        public List<AudienceBase> _subscriberList = new List<AudienceBase>();
        public void AddSubscriber(AudienceBase audience)
        {
            _subscriberList.Add(audience);
        }
        public abstract void Notify();
    }
}