using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern;
public class ServeWaterCommand : ICommand
{
    public string Execute()
    {
        return "Water";
    }
}
