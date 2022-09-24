using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern;
public class OriginalTree : ITree, IDrawTree
{
    public OriginalTree(int size)
    {
        Size = size;
        Sprite = new byte[1024 * 10];
    }

    public byte[] Sprite { get; private set; }

    public int Size { get; private set; }

    public string Draw()
    {
        return $"Tree the size of {Size}, image has {Sprite.Length} bytes";
    }
}
