using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello:");
            //Console.WriteLine("Michael Luongo");

            //Console.WriteLine("Hello: \nMichael Luongo");

            // Console.WriteLine(-1+4*6);
            // Console.WriteLine((35+5)% 7);
            //Console.WriteLine(14+-4*6/11);
            //Console.WriteLine(2+15/6*1-7%2);

            //int x = -1, y= 4, z=6;
            //  Console.WriteLine(x+y*z);

            // int k = 35, l = 5, m = 7;
            // Console.WriteLine((k+l)%m);

            //Write a C# application that accepts a number from the user and print on the screen if his number is Odd or Even

            int n;
            Console.Write("Please enter a number and I will tell you if it it odd or even. ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0)
                Console.WriteLine("That is an EVEN Number.");

            else
                Console.WriteLine("That is an ODD Number.");

            {


            }

        }
    }
}
