using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var methodId = 1;
            var method = (ConsoleColor.Red);

            var methodId = 2;
            var method = (ConsoleColor.Green);

            var methodId = 3;
            var method = (ConsoleColor.Blue);

        }

        static int SwitchOnEnum(ConsoleColor color)
        {
            int hexColor = 0;
            switch (color)
            {
                case ConsoleColor.Red:
                    hexColor = 0xff0000;
                    break;
                case ConsoleColor.Green:
                    hexColor = 0x00ff00;
                    break;
                case ConsoleColor.Blue:
                    hexColor = 0x0000ff;
                    break;
                default;
                    throw new ArgumentException("Only red, green, or blue is allowed.");



            }


        }
    }
}
