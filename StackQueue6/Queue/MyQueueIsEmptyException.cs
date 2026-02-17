using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue6.Queue
{
    public class MyQueueIsEmptyException : Exception
    {
        public MyQueueIsEmptyException(string message) : base (message)
        {
            
        }
    }
}
