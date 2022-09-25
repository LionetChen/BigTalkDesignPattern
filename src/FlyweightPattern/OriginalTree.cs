using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern;
public class OriginalTree : ITree, IDrawableTree
{
    public OriginalTree(int size, int color)
    {
        Size = size;
        Sprite = new byte[Config.ImageSize];
        Color = color;
    }

    public byte[] Sprite { get; private set; }

    public int Size { get; private set; }

    public int Color { get; private set; }

    public string Draw()
    {
        return $"Tree the size of {Size}, color of {Color} image has {Sprite.Length} bytes";
    }
}
