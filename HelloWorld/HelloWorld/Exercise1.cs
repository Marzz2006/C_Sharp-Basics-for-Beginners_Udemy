using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Fundamentals
{
    internal class Exercise1
    { 
        public static void NGG() //NumberGuessingGame
        {
            Console.WriteLine("Pleaser enter a number between 1 and 10");
            var number = Console.ReadLine();

            if (number == "1")
                Console.WriteLine("Number entered is correct");
            else
                Console.WriteLine("Number entered is incorrect");
        }

        public static void WIL() //WhichIsLarger
        {
            Console.WriteLine("Please enter a number");
            var number1 = Console.ReadLine();
            Console.WriteLine("Please enter another number");
            var number2 = Console.ReadLine();

            if (int.Parse(number1) > int.Parse(number2))
                Console.WriteLine(number1.ToString() + " is larger");
            else if (int.Parse(number1) < int.Parse(number2))
                Console.WriteLine(number2.ToString() + " is larger");
            else Console.WriteLine("Error");
        }

        public static void PO() //PictureOrientation
        {            
            Console.WriteLine("Please enter pixel height of image");
            var number3 = Console.ReadLine();
            Console.WriteLine("Please enter pixel width of image");
            var number4 = Console.ReadLine();

            if (int.Parse(number3) > int.Parse(number4))
                Console.WriteLine("This image is in Portrait Mode");
            else if (int.Parse(number3) < int.Parse(number4))
                Console.WriteLine("This image is in Landscape Mode");
            else Console.WriteLine("Error");
        }

        public static void SL() //SpeedLimit
        {            
            int speed_limitParsed;
            int vehicle_speedParsed;
            int demerit = 0;

            Console.WriteLine("Please enter road speed limit in MPH");
            var speed_limit = Console.ReadLine();
            Console.WriteLine("Please enter vehicle speed.");
            var vehicle_speed = Console.ReadLine();

            if (!int.TryParse(speed_limit, out speed_limitParsed) || !int.TryParse(vehicle_speed, out vehicle_speedParsed))
            {
                Console.WriteLine("Error wrong number entered");
            }
            else if (speed_limitParsed >= vehicle_speedParsed)
            {
                Console.WriteLine("Driver not speeding");
            }
            else if (speed_limitParsed < vehicle_speedParsed)
            {
                demerit = (vehicle_speedParsed - speed_limitParsed) / 5;
                if (demerit < 12)
                {

                    Console.WriteLine("Driver recives " + demerit.ToString() + " demertis.");
                }
                else
                {
                    Console.WriteLine("Drivers License Suspended");
                }

            }
        }
    }
}
