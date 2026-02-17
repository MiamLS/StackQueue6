using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue6.Stack
{
    public interface IMyStack<T>
    {
        void Push(T element);
        T Pop();
        T Peek();
    }
}
