using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue6
{
    public class MyStackLinkedList<T> : IMyStack<T>
    {
        LinkedList<T> elements = new LinkedList<T>();

        public MyStackLinkedList()
        {
            //if (elements.Count > 3)
            //    throw new MyStackIsFullException("Listen er fuld");
        }

        public T Peek()
        {
            return elements.Last();
        }

        public T Pop()
        {
            T el = Peek();
            elements.RemoveLast();

            return el;
        }

        public void Push(T element)
        {
            elements.AddLast(element);

            if (elements.Count > 3)
            {
                throw new MyStackIsFullException("Listen er fuld");
            }
        }
    }
}
