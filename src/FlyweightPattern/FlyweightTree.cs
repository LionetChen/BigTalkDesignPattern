using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern;
/// <summary>
/// The flyweight object stores intrinsic value. i.e. the image of a certain sized tree.
/// Also stored is the size value of the tree. There are limited sizes
/// </summary>
public class FlyweightTree : ITree
{
    public FlyweightTree(int size)
    {
        Size = size;
        Sprite = new byte[Config.ImageSize];
    }

    public byte[] Sprite { get; private set; }

    public int Size { get; private set; }
}
