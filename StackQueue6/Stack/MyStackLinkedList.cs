using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue6.Stack
{
    public class MyStackLinkedList<T> : IMyStack<T>
    {
        private LinkedList<T> elements = new LinkedList<T>();

        private int _size;

        public MyStackLinkedList(int size)
        {
            _size = size;
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
            if (elements.Count >= _size)
            {
                throw new MyStackIsFullException("Listen er fuld");
            }
            elements.AddLast(element);

        }
    }
}
