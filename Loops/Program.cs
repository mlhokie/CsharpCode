using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int y = 1; y <= 99; y++)
            {
                if (y % 2 != 0)
                {
                    Console.WriteLine(y + " is ODD");
                }
                else
                {
                    Console.WriteLine(y + " is EVEN");
                }





            }
        }
    }
}
