using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<int> collection = new Queue<int>();

            collection.Enqueue(1);
            collection.Enqueue(2);
            collection.Enqueue(3);

            Console.WriteLine(collection.Dequeue());
            Console.ReadLine();
        }
    }
}
