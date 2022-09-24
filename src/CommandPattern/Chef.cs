using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern;

/// <summary>
/// Receiver of the command
/// </summary>
public class Chef
{
    public Chef(string name)
    {
        Name = name;
    }

    public string Name { get; private set; }
}
