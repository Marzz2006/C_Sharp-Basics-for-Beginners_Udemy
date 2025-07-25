using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Fundamentals
{
    internal class Exercise2
    {
        public static void NDB3()
        {
            Console.WriteLine("Numbers divisible by 3: " + DivBy3(1, 100));
        }

        static int DivBy3(int min, int max)
        {
            int count = 0;
            for (int i = min; i <= max; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            return count;
        }

        public static void CS()
        {
            Console.WriteLine("Sum of entered numbers: " + CalcSum()); Console.WriteLine("Sum of entered numbers: " + CalcSum());
        }
            
        static int CalcSum()
        {
            int sum = 0;
            while (true)
            {
                Console.Write("Please enter a number (or 'exit' to get total of numbers entered):");
                string input = Console.ReadLine();
                if (input == "exit")
                {
                    break;
                }
                if (int.TryParse(input, out int number))
                {
                    sum += number;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number or 'exit'.");
                }
            }
            return sum;
        }

        public static void Fact()
        {
            Console.Write("Please enter a number: ");
            var input = Console.ReadLine().ToLower();
            if (int.TryParse(input, out int input_int2))
            {
                Console.WriteLine(input + "! = " + Factorial(input_int2));
            }
            else
            {
                Console.WriteLine("You did not enter a number!");
            }
        }

        static int Factorial(int input)
        {
            int output = 1;

            while (input != 1)
            {
                output = output * input;
                input = input - 1;
            }
            return output;
        }

        public static void GG()
        {
            var input = "0";
            int tryAmount = 4;
            Random random = new Random();
            int randomNumber = random.Next(1, 11);

            while (tryAmount > 0)
            {
                Console.Write("Please enter a number between 1 and 10: ");
                input = Console.ReadLine().ToLower();

                if (int.TryParse(input, out int inputInt))
                {
                    if (inputInt != randomNumber)
                    {
                        Console.WriteLine("Incorrect guess, please try again");
                    }
                    else
                    {
                        Console.WriteLine("You guessed the correct number");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number between 1 and 10.");
                }

                tryAmount--;
            }
        }

        public static void FLN()
        {
            Console.Write("Please enter a group of numbers separated by commas:");
            var input = Console.ReadLine();

            int[] numbers = input.Split(',').Select(int.Parse).ToArray();
            int largestNumber = FindLargestNumber(numbers);

            Console.WriteLine("The largest number is: " + largestNumber);
        }

        static int FindLargestNumber(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                throw new ArgumentException("Array is empty.");
            }

            int largestNumber = numbers[0];
            foreach (int number in numbers)
            {
                if (number > largestNumber)
                {
                    largestNumber = number;
                }
            }
            return largestNumber;
        }
    }
}
