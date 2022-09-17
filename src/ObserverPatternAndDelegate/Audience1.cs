using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObserverPatternAndDelegate
{
    public class Audience1 : AudienceBase
    {
        public override void Watches(string showName)
        {
            State = $"{nameof(Audience1)} watches {showName}";
        }
    }
}