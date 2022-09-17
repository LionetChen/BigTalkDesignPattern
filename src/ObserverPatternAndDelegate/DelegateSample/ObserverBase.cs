using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObserverPatternAndDelegate.DelegateSample
{
    public abstract class ObserverBase
    {
        public string State { get; protected set; } = string.Empty;
    }
}