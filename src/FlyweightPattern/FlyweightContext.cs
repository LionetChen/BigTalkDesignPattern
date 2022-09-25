using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern;
public class FlyweightContext : IDrawableTree
{
    public int Color { get; set; }
    public FlyweightTree _flyweightTree { get; set; }

    public FlyweightContext(int size, int color)
    {
        Color = color;
        _flyweightTree = FlyweightTreeFactory.GetTreeOfSize(size);
    }

    public string Draw()
    {
        return $"Tree the size of {_flyweightTree.Size}, color of {Color} image has {_flyweightTree.Sprite.Length} bytes";
    }
}
