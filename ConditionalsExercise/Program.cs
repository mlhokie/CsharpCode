using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsExercise
{
    class Program
    {
        static void Main(string[] args)
        {   //Conditionals #1
            // <summary>
            // Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters 
            // a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in 
            // applications where values entered into input boxes need to be validated.)
            // </summary>

            Console.WriteLine("Please enter a number between 1 and 10");
            var userInput = Console.ReadLine();
            var number = Convert.ToInt32(userInput);

            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            //Conditionals # 2
            // <summary>
            // Write a program which takes two numbers from the console and displays the maximum of the two.
            // </summary>

            //Console.Write("Please enter a number: ");
            //var number1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Please enther another number: ");
            //var number2 = Convert.ToInt32(Console.ReadLine());

            //var largestNum = (number1 > number2) ? number1 : number2;
            //Console.WriteLine($"{largestNum} is the larger number!");


            //Conditionals # 3
            // <summary>
            // Write a program and ask the user to enter the width and height of an image. Then tell if the image 
            // is landscape or portrait.
            // </summary>

            //Console.WriteLine("Please enter width of image: ");
            //double width = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Please enter height of image: ");
            //double height = Convert.ToDouble(Console.ReadLine());

            //if (width < height)
            //{
            //    Console.WriteLine("Image is portrait style.");
            //}
            //else
            //{
            //    Console.WriteLine("Image is landscape style.");
            //}

            //Conditionals # 4
            // <summary>
            // Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, 
            // etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, 
            // the program asks for the speed of a car. If the user enters a value less than the speed limit, program should 
            // display Ok on the console. If the value is above the speed limit, the program should calculate the number of 
            // demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on 
            // the console. If the number of demerit points is above 12, the program should display License Suspended.
            // </summary>

            //Console.Write("What is the speed limit in MPH? ");
            //var speedLimit = Convert.ToInt32(Console.ReadLine());

            //Console.Write("What is the speed of this car in MPH? ");
            //var carSpeed = Convert.ToInt32(Console.ReadLine());

            //if (carSpeed < speedLimit)
            //    Console.WriteLine("Ok");
            //else
            //{
            //    const int mphDemeritPoint = 5;
            //    var demeritPoints = (carSpeed - speedLimit) / mphDemeritPoint;
            //    if (demeritPoints > 12)
            //        Console.WriteLine("License Suspended");
            //    else
            //        Console.WriteLine("You were speeding and got " + demeritPoints + " demerit points.");
            //}


        }
    }
}

