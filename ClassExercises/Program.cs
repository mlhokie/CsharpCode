using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[,]
            {
                {0, 1, 2, 3, 4, 3, 4, 5, 9},
                {6, 7, 8, 9, 10, 11, 12, 13, 14}
            };

            int count = Countnum(arr, 5);
            Console.WriteLine(count);
            Console.ReadKey();
        }
        static int Countnum(int[,] a, int b)
        {
            int count = 0;

            for (int row = 0; row < a.GetLength(0); row++)
            {
                for (int col = 0; col < a.GetLength(1); col++)
                {
                    if (a[row, col] == b)
                    {
                        count++;
                    }
                }


            }
           
            return count;
        }

        





    }
    
}
