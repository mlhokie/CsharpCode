using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Arrays
{
    class Program
    {
        private static int i;
        private static int j;
        private static object number;

        public static class Enumerable
        {
        }

        static void Main(string[] args)
        {
            //int[] arr = new int[10];
            //string cat;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine("Enter element# {0} for the array of length {1}", i, arr.Length);
            //    cat = Console.ReadLine();
            //    arr[i] = Convert.ToInt32(cat);
            //}

            ////foreach (var item in arr)
            //{
            //    //Console.WriteLine(item);
            //    Console.WriteLine("The full array is: [{0}]", string.Join(", ", arr));




            //    Console.WriteLine("The max value is...{0}", arr.Max());


            // int[] arr1 = new int[] {1, 2, 3};
            // int[] arr2 = new int[] {1, 2, 3};

            //bool eq1 = arr1.SequenceEqual(arr2);

            // Console.WriteLine(eq1);

            // string[] names = {"Adam,", "Barry,", "Charlie,", "Rachel"};
            // foreach (string name in names)
            // {
            //    Console.WriteLine($"{name} has {name.Length} characters.");
            // }
            /*
             int[][] iarrs2 = new int[][]
             {
                 new int[] {1, 2, 3,4},
                 new int[] {5,6,7,8,9},
                 new int[] {10,11,12,13,14,15}
             };

             int grandTotal = 0;
             for (int i = 0; i < iarrs2.Length; ++i)
             {
                 for (int j = 0; j < iarrs2[i].Length; ++j)
                 {
                     grandTotal += iarrs2[i][j];
                 }
             }

             foreach (int[] arr in iarrs2)
             {
                 foreach (int i in arr)
                     //grandTotal += i;
                     Console.Write("[{0}]", string.Join(",", i));


                 Console.WriteLine("\n");
             }
             */



            // Write a C# program to count a specified number in a given array of integers?
            //Do this with 1D-Array, 2D-Array, and Jagged Array.



            //    int[] num = { 5, 4, 7, 5, 5, 9, 5, 2, 2 };
            //    int count = Countnum(num, 5);
            //    Console.WriteLine(count);
            //}

            //static int Countnum(int[] a, int b)
            //{
            //    int count = 0;
            //    for (int i = 0; i < a.Length; i++)
            //    {
            //        if (a[i] == b)
            //            count++;

            //    }

            //    return count;
            //}



            //var groups = num.GroupBy(v => v);
            //foreach (var group in groups)
            //{
            //    Console.WriteLine(" Element {0} appears in the array {1} times", group.Key, group.Count());
            //}





            //string[,] names = new string[,]
            //{
            //    {"Arian", "Geeva"},
            //    {"Mike", "Scooby"},
            //};
            //foreach (string name in names)

            //    Console.WriteLine($"{name} has {name.Length} letters in their name");


            double v = Math.Pow(Math.E, -5);
            Console.WriteLine($"e to the -5th power is {v:e4}.");
            Console.WriteLine("e to the -5th power is {0:e4}.", v);
            Console.WriteLine();
            v = Math.Sqrt(10);
            Console.WriteLine($"The square root of 10 is {v:F3}.");
            Console.WriteLine("The square root of 10 is {0:F3}.", v);
            Console.WriteLine();
            long l = (long) (1e9 * v);
            Console.WriteLine($"Multiply this by a billion and you get {l:N0}.");
            Console.WriteLine("Multiply this by a billion and you get {0:N0}.", l);






            //}

            //int[,] numbers = new int[,]
            //    {
            //    {2, 3, 6, 7, 8, 3},
            //    {3, 7, 7, 2, 3, 4},
            //    {5, 4, 3, 3, 1, 4}
            //    };
            //static int Countnum(int[] a, int b)
            //{
            //        int count = 0;
            //        for (int i = 0; i < a.Length; i++)
            //        {
            //            if (a[i] == b)
            //                count++;

            //        }

            //        return count;
            //}






            //for (int i = 0; i < numbers.GetLength(0); i++)
            //{
            //    for (int j = 0; j < numbers.GetLength(1); j++)
            //        Console.Write(numbers[i, j] + " ");
            //    Console.WriteLine();


            //Console.WriteLine(" Element {0} appears in the array {1} times");
            //Console.WriteLine("[{0}]", string.Join(",", i));



            ////int grandTotal = 0;
            //for (int i = 0; i < numbers.GetLength(i); i++)
            //{
            //    for (int j = 0; j < numbers.GetLength(j); j++)
            //    {

            //    }
            //    {
            //        //Console.Write("[{0}]", string.Join(",", i));
            //        Console.Write($"{number} occurs [{0}] times\n", numbers);
            //    }

            //    //Console.WriteLine($"{number} appears times in the arrays!");
            //    //}




            //var numberslist = new List<int> { 8, 23, 99, 11, 2, 2, 23, 44, 7, 23, 11, 8, 99, 11, 11};

            //var j = numberslist.GroupBy(i => i);

            //foreach (var grp in j)
            //{
            //    Console.WriteLine("Element {0} appears {1} times in the list.", grp.Key, grp.Count());
            //}



        }
    }
}
