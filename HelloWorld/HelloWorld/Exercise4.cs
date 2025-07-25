﻿using System;
using System.Collections.Generic;
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



        }


        /*
            Write a program and ask the user to enter a few words separated by a space. Use the words to create 
            a variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents". 
            Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", 
            the program should still display "NumberOfStudents".
        */

        /*
            Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word. 
            So, if the user enters "inadequate", the program should display 6 on the console.
        */
    }
}
