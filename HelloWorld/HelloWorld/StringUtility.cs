using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Fundamentals
{
    public class StringUtility
    {
        public static string SummerizeText(String text, int maxLength = 20)
        {
            if (text.Length < maxLength)
                return text;

            var words = text.Split(" ");
            var totalChars = 0;
            var summeryWords = new List<string>();

            foreach ( var word in words ) 
            {
                summeryWords.Add(word);

                totalChars += word.Length + 1;
                if( totalChars > maxLength)
                    break;
            }
            return string.Join(" ", summeryWords) + "...";
        }

        public static void stringMethods(string fullName)
        {
           Console.WriteLine(fullName);
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);

            Console.WriteLine(fullName.Replace("John", "Jack"));

            if (System.String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C"));

            float price2 = 29.95f;
            Console.WriteLine(price2.ToString("C0"));
        }
    }
}
