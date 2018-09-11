using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {

        static void Main(string[] args)
        {
            /*1) Write a C# program to compute the sum of the first 500 prime numbers.
                - Sample Output:
            Sum of the first 500 prime numbers:
            3682913
            2) What is the output of:
            a -
                int i = 1;
            int sum = i++ + ++i + i++;
            -------------------------------
                    b -
                int a = 1, b = 2;
            int sum = a++ + b++ + ++a + ++b;
            */
           
            Console.WriteLine("\nSum of the first 500 prime numbers: ");
            long sum = 0;
            int ctr = 0;
            int n = 2;
            while (ctr < 500)
            {
                 if (isPrime(n))
                    {
                        sum += n;
                        ctr++;
                 }
                    n++;
            }

                Console.WriteLine(sum.ToString());

        }

        public static bool isPrime(int n)
        {
            int x = (int) Math.Floor(Math.Sqrt(n));

            if (n == 1) return false;
            if (n == 2) return true;

            for (int i = 2; i <= x; ++i)
            {
                if (n % i == 0) return false;
            }


            return true;
        }
    }
}
