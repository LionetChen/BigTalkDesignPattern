using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern;
public class Button : Component
{
    public Button(Mediator dialog, string text, string name) : base(dialog, text, name)
    {
    }
}
