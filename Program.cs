using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Array1 a = new Array1(20);

            for (int i = 0; i < 10; i++)
            {
                a.AddLast(i);
            }

            Console.WriteLine(a.ToString());
            
            a.Add(2, 55);
            Console.WriteLine(a.ToString());

            Console.WriteLine(a.Get(4));

            a.Set(4, 55);
            Console.WriteLine(a.ToString());
        }
    }
}
