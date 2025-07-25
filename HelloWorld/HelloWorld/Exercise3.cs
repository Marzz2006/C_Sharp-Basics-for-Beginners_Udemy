using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Fundamentals
{
    internal class Exercise3
    {
        public static void FB_Likes()
        {
            string input = "blank";
            var names = new List<string>();
            var friends = "";

            while (true)
            {
                Console.Write("Enter Username to generate likes (press Enter when finished): ");
                input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                names.Add(input);
            }

            if (names.Count > 1)
            {
                friends = string.Join(", ", names);
                friends = friends.TrimEnd(new char[] { ',' });
                friends = friends.Substring(0, friends.LastIndexOf(", ")) + ", and " + names[names.Count - 1];
            }
            else if (names.Count == 1)
            {
                friends = names[0];
            }

            if (!string.IsNullOrEmpty(friends))
            {
                Console.WriteLine(friends + " like your post.");
            }

        }

        public static void ReverseName()
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            var reversename = "";


            char[] letters = name.ToCharArray();
            letters.Reverse();
            Array.Reverse(letters);

            foreach (char letter in letters)
            {
                reversename = reversename + letter;
            }

            Console.WriteLine(reversename);
        }

        public static void FiveUniqueNumbers()
        {
            var entered_numbers = new List<int>();
            bool duplicatentered = false;

            while (entered_numbers.Count < 5)
            {
                if (!duplicatentered)
                {
                    Console.Write("Enter a number: ");
                    var input = Console.ReadLine();
                    int result = 0;
                    if (int.TryParse(input, out result))
                    {
                        if (entered_numbers.Contains(result))
                        {
                            duplicatentered = true;
                        }
                        else
                        {
                            entered_numbers.Add(result);
                            duplicatentered = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("You must enter a number");
                        duplicatentered = false;
                    }
                }
                else
                {
                    Console.Write("Duplicate number entered. Please enter another number: ");
                    var input = Console.ReadLine();
                    int result = 0;
                    if (int.TryParse(input, out result))
                    {
                        if (entered_numbers.Contains(result))
                        {
                            duplicatentered = true;
                        }
                        else
                        {
                            entered_numbers.Add(result);
                            duplicatentered = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("You must enter a number");
                        duplicatentered = false;
                    }
                }
            }
            entered_numbers.Sort();

            var sort_numbers = string.Join(", ", entered_numbers);
            Console.WriteLine("The numebrs you enters are: " + sort_numbers);
        }

        public static void NumberList()
        {
            var entered_numbers = new List<int>();
            var listed_numbers = new List<int>();

            while (true)
            {
                Console.Write("Please enter a number. Every time you press enter it will be recorded. Type 'quit' to end: ");
                var input = Console.ReadLine();

                if (input == "quit")
                {
                    break;
                }
                else
                {
                    int result = 0;
                    if (int.TryParse(input, out result))
                    {
                        entered_numbers.Add(result);
                    }
                    else
                    {
                        Console.WriteLine("Enter numbers only!");
                    }
                }
            }

            foreach (var result in entered_numbers)
            {
                if (!listed_numbers.Contains(result))
                {
                    listed_numbers.Add(result);
                }
            }
            listed_numbers.Sort();
            var print_numbers = string.Join(", ", listed_numbers);
            Console.WriteLine("The numbers you entered are: " + print_numbers);
        }

        public static void CommaSeparatedNumbers()
        {
            while (true)
            {

                Console.Write("Please enter 5 or more comma seperated numbers: ");
                var input = Console.ReadLine();

                List<int> numbers = new List<int>(); ;
                int result = 0;
                List<string> numberlist = input.Split(',').Select(s => s.Trim()).ToList();

                foreach (var item in numberlist)
                {
                    if (int.TryParse(item, out result))
                    {
                        numbers.Add(result);
                    }
                    else
                    {
                        Console.WriteLine("Not a number! Try Again.");
                        continue;
                    }
                }

                if (numbers.Count >= 5)
                {
                    numbers.Sort();
                    string smallest_three;
                    List<int> trimmedNumbers = numbers.Take(3).ToList();
                    smallest_three = string.Join(", ", trimmedNumbers);
                    Console.WriteLine("The smallest three numebrs were: " + smallest_three);

                    break;
                }
                else
                {
                    Console.WriteLine("In valid List. Please Try Again");
                }
            }

        }
    }
}
