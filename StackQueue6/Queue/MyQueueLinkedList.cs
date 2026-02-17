using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue6.Queue
{
    public class MyQueueLinkedList<T> : IMyQueue<T>
    {
        LinkedList<T> elements = new LinkedList<T>();

        public T Dequeue()
        {
            //T firstInLine = elements.First();
            if (elements.First != null)
            {
                T firstInLine = elements.First();
                elements.RemoveFirst();
                return firstInLine;
            }
            else
            {
                throw new MyQueueIsEmptyException("List is empty!");
            }
            //return firstInLine;
        }

        public void Enqueue(T item)
        {
            elements.AddLast(item);
        }
    }
}
