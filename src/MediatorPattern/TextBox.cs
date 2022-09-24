using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern;
public class TextBox : Component
{
    public TextBox(Mediator dialog, string text, string name) : base(dialog, text, name)
    {
    }
}
