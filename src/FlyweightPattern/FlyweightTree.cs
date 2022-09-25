using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern;
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
