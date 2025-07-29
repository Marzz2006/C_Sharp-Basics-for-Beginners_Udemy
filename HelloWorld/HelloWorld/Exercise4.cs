using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Fundamentals
{
    internal class Exercise4
    {
        

        public static void hn()
        {
            /*Hyphenated Numebers
                Write a program and ask the user to enter a few numbers separated by a hyphen.
                Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
                display a message: "Consecutive"; otherwise, display "Not Consecutive".
            */

            Console.Write("Enter a group of numbers seperated by hyphen's: ");
            var numbers_list = Console.ReadLine();
            Console.WriteLine(numbers_list);

            var numbers = Array.ConvertAll(numbers_list.Split('-'), int.Parse);

            if (numbers.SequenceEqual(numbers.OrderBy(n => n)))
            {
                Console.WriteLine("Numbers are in order");        
            }
            else
            {
                Console.WriteLine("Numbers are not in order");
            }
        }

        public static void dup()
        {
            /*Duplicate Numbers
                Write a program and ask the user to enter a few numbers separated by a hyphen. 
                If the user simply presses Enter, without supplying an input, exit immediately; 
                otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.
            */

            Console.Write("Please enter a group of numbers seperated by hyphen's: ");
            var input = Console.ReadLine();
            var duplicate_count = 0;
            if (string.IsNullOrWhiteSpace(input))
            {
                return;
            }

            var numbers = Array.ConvertAll(input.Split('-'), int.Parse);
            Dictionary<int, int> countMap = new Dictionary<int, int>();
            foreach(var number in numbers)
            {
                if (countMap.ContainsKey(number))
                    countMap[number]++;
                else
                    countMap.Add(number, 1);
            }
            foreach (var entry in countMap)
            {
                if (entry.Value > 1)
                    duplicate_count = +1;
            }

            if (duplicate_count > 0)
                Console.WriteLine("Duplicates Found");
            else
                Console.WriteLine("No Duplicates Found");
        }

        public static void vt()
        {
            /*Valid Time
                Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
                A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, 
                display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.
            */

            Console.Write("Enter a time in 24 hour format: ");
            var input = Console.ReadLine();
            input = input.Trim();
            bool verifytime = false;

            if (!string.IsNullOrWhiteSpace(input))
            {
                var numbers = input.Split(':');
                if (numbers.Length == 2 &&
                    int.TryParse(numbers[0], out int hours) && int.TryParse(numbers[1], out int minutes) &&
                    hours >= 0 && hours <= 23 && minutes >= 0 && minutes <= 59)
                {
                    verifytime = true;
                }
                else
                {
                    verifytime = false;
                }
            }
            else
            {
                verifytime = false;
            }

            if (verifytime == true)
            {
                Console.WriteLine("Time is Valid");
            }
            else
            {
                Console.WriteLine("Time is Invalid");
            }
        }

        public static void pc()
        {
            /*
                Write a program and ask the user to enter a few words separated by a space. Use the words to create 
                a variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents". 
                Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", 
                the program should still display "NumberOfStudents".
            */

            Console.Write("Enter a few words: ");
            var input = Console.ReadLine();

            string[] words = input.Split(' ');
            List<string> pascalWords = words
                .Select(word => char.ToUpper(word[0]) + word.Substring(1).ToLower())
                .ToList();

            var output = "";
            foreach(string word in pascalWords)
                { 
                output = output + word;
                }
            Console.WriteLine(output);
        }

        public static void cv()
        {
            /*
                Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word. 
                So, if the user enters "inadequate", the program should display 6 on the console.
            */

            Console.Write("Enter a word: ");
            var input = Console.ReadLine();
            var vowelcount = 0;
            var vowels = "aeiou";

            if (input != null)
            {
                var inputlower = input.ToLower();
                foreach (char letter in inputlower)
                {
                    
                    if (vowels.Contains(letter))
                    {
                        vowelcount = vowelcount + 1;
                    }
                }
            }
            Console.WriteLine(vowelcount);
        }

    }
}
