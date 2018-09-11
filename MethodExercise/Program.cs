using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int mynum = 42;
            int anothernum = 65;
            Console.WriteLine(Add(mynum , anothernum));
            Mult(5,7);
            Console.WriteLine(MethodExc.Add(4, 5));
            
        }

        static int Add(int a, int b)
        {
            return a + b;

        }

        static void Mult(int a, int b)
        {
            Console.WriteLine(a*b);
        }

    }
}
