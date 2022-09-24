using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern;
public class CheckBox : Component
{
    public delegate void CheckChangedEventHandler(CheckBox sender, bool isChecked);

    public event CheckChangedEventHandler? CheckChanged;

    public bool IsChecked { get; private set; } = false;

    public CheckBox(Mediator dialog, string text, string name) : base(dialog, text, name)
    {

    }

    public void SetStatus(bool isChecked)
    {
        CheckChanged?.Invoke(this, isChecked);
    }
}
