using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string Salah = "Hi my name is Salah!";
            Console.WriteLine("Please select a character from the sentance: Hi my name is Salah! ");

            var box = Convert.ToChar(Console.Read());


            var count = Countchar(Salah, box);
            Console.WriteLine(count);
        }


        static int Countchar(string a, char b)
        {
            var count = 0;
            foreach (var i in a)

            {
                if (i == b)
                    count++;

            }

            return count;



        //    Console.Write("Enter a string please: ");
        //    string sentence = Console.ReadLine();

        //    Console.WriteLine("Enter a word from your inputted string please: ");
        //    string word = Console.ReadLine();
        //    Console.WriteLine();
        //    //var index1 = sentence.IndexOf(word);
        //    //var count = Countchar(sentance, word);
        //    var occurences = sentence.Split(new[] {word}, StringSplitOptions.None).Count() - 1;

        //    Console.WriteLine($"Your word appears {occurences} times in {sentence}.");
        //    Console.WriteLine();


        //    //Console.WriteLine($"The first index of {word} is: {index1}.");

        //    foreach (int e in StringCountIndex(sentence, word))
                
        //    {
        //        if (e != -1)
        //            Console.WriteLine($"The word you chose, {word} is indexed at: {e}");
        //        else
        //            break;
        //    }




        //}

        //static int[] StringCountIndex(string main, string sub)
        //{
        //    string[] mainSplit = main.Split(' ');
        //    //int compare;
        //    int[] results = new int[mainSplit.Length];
        //    for (int i = 0; i < results.Length; i++)
        //    {
        //        results[i] = -1;
        //    }
        //    int startIndex = 0, resultsIndex = 0, count = 0;
            
        //    foreach (string str in mainSplit)
        //        if (String.Equals(str, sub, StringComparison.OrdinalIgnoreCase))
        //        {
        //            results[resultsIndex] = main.IndexOf(sub, startIndex);
        //            count++;
        //            startIndex = results[resultsIndex] + sub.Length;
        //            resultsIndex++;
        //        }

            //results[0] = count;
            //return results;

            //static int Countchar(string a, string b)
            //{
            //    int count = 0;

            //    for (string a = 0; < a.Length(0); a++)
            //    {
            //        for (int col = 0; col < a.GetLength(1); col++)
            //        {
            //            if (a[row, col] == b)
            //            {
            //                count++;
            //            }
            //        }


            //    }

            //    return count;








        }
    }
}
