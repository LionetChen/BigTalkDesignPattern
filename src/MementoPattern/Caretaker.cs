using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern;
public class Caretaker
{
    Stack<IMementoMeta> _roleStateMementos = new Stack<IMementoMeta>();

    public void Save(IMementoMeta memo)
    {
        _roleStateMementos.Push(memo);
    }
    
    public IMementoMeta RestoreLast()
    {
        return _roleStateMementos.Pop();
    }
}
