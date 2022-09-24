using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern;
public class Component
{
    public Component(Mediator dialog, string text, string name)
    {
        Dialog = dialog;
        Text = text;
        Name = name;
    }

    public delegate void ClickedEventHandler(Component sender);

    public event ClickedEventHandler? Clicked;

    public Mediator Dialog { get; private set; }

    public string Text { get; set; } = string.Empty;

    public string Name { get; private set; } = string.Empty;

    public void Click()
    {
        Clicked?.Invoke(this);
    }
}
