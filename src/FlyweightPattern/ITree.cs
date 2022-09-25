using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public interface ITree
    {
        public byte[] Sprite { get; }

        public int Size { get; }
    }
}
