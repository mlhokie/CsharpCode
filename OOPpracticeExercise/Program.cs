using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPpracticeExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Home myHome = new Home();
            myHome.OpentheGarage();
            Console.WriteLine(myHome.GarageOpen);
            myHome.ClosetheGarage();
            Console.WriteLine(myHome.GarageOpen);




        }
    }
}
