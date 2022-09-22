using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern;
public class Waiter
{
    private Queue<ICommand> _queue = new Queue<ICommand>();

    public void Add(ICommand command)
    {
        _queue.Enqueue(command);
    }

    public IEnumerable<string> Execute()
    {
        while(_queue.Count > 0)
        {
             yield return _queue.Dequeue().Execute();
        }
    }
}
