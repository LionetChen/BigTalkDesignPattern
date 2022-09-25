using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern;
public class FlyweightTreeFactory
{
    public static Dictionary<int, FlyweightTree> _sizeTreeDictionary = new Dictionary<int, FlyweightTree>();

    public static FlyweightTree GetTreeOfSize(int size)
    {
        if(_sizeTreeDictionary.TryGetValue(size, out FlyweightTree? tree))
        {
            return tree;
        }
        else
        {
            return _sizeTreeDictionary[size] = new FlyweightTree(size);
        }
    }
}
