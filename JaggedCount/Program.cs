using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedCount
{
    class Program
    {
        static void Main(string[] args)
        {

            int[][] myJagged = new int[2][];

            myJagged[0] = new int[] {0, 1, 2, 3, 8, 3, 4, 5, 8};
            myJagged[1] = new int[] {6, 7, 8, 9, 8, 11, 12, 13, 14};

            Console.WriteLine(Count(myJagged, 8));

        }

        static int Count(int[][] a, int b)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    if (a[i][j] == b)
                        count++;
                }
                //Console.Write(myJagged[i][j] + " ");
                //Console.WriteLine();

            }

            return count;
        }
    }
}
