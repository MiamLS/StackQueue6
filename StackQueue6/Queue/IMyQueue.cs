using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue6.Queue
{
    public interface IMyQueue<T>
    {
        void Enqueue(T item);
        T Dequeue();
    }
}
