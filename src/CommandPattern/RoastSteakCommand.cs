using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern;
public class RoastSteakCommand : ICommand
{
    private Chef _chef;
    private string _doneness;
    private string _sauce;

    public RoastSteakCommand(Chef chef, string doneness, string sauce)
    {
        _chef = chef;
        _doneness = doneness;
        _sauce = sauce;
    }

    public string Execute()
    {
        return $"Roast steak {_doneness} with {_sauce} sauce by Chef {_chef.Name}";
    }
}
