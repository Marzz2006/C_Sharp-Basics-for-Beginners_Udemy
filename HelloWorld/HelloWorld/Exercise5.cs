using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Fundamentals
{
    internal class Exercise5
    {
        public static int wc()
        {
            //1- Write a program that reads a text file and displays the number of words.
            var wordCount = 0;
            var path = @"D:\OneDrive\Files\C_Sharp\C_Sharp-Basics-for-Beginners_Udemy\sample.txt";
            if (File.Exists(path))
            {
                var content = File.ReadAllText(path);
                string[] separators = { " ", "\n", "\t" };
                var words = content.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                wordCount = words.Length;
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
                return wordCount;
        }
        
        public static string lw()
        {
            //2- Write a program that reads a text file and displays the longest word in the file.
            var longestWord = "";
            var path = @"D:\OneDrive\Files\C_Sharp\C_Sharp-Basics-for-Beginners_Udemy\sample.txt";
            if (File.Exists(path))
            {
                var content = File.ReadAllText(path);
                string[] separators = { " ", "\n", "\t" };
                var words = content.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                longestWord = words.OrderByDescending(w => w.Length).FirstOrDefault() ?? "";

            }
            else
            {
                Console.WriteLine("File does not exist");
            }
            return longestWord;
        }
    }
}
