using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Fundamentals
{
    internal class LecturePrograms
    {
        public static void DateTimeExample()
        {
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Specified Date and Time: " + dateTime);
            Console.WriteLine("Current Date and Time: " + now);
            Console.WriteLine("Current Date Only: " + today);
        }

        public static void TimeSpanExp()
        {
            //Creating
            var timeSpan1 = new TimeSpan(1, 2, 3);
            var timeSpan2 = new TimeSpan(1, 0, 0);
            var timeSpan3 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;

            Console.WriteLine("Duration: " + duration);

            //Propertis
            Console.WriteLine("Minutes: " + timeSpan1.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan1.TotalMinutes);

            //Add
            Console.WriteLine("Add Example: " + timeSpan1.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract Example: " + timeSpan1.Subtract(TimeSpan.FromMinutes(2)));

            //ToString
            Console.WriteLine("ToString: " + timeSpan1.ToString()); //ToString is autmatically called in Console Write Line so it's only needed outside of the CW command.

            //Parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
        }

        public static void stringMethods()
        {
            var fullName = "John Doe ";
            StringUtility.stringMethods(fullName);
        }

        public static void summarisingText()
        {
            var sentance = "This is going to be a really really really really really really long text.";
            var summary = StringUtility.SummerizeText(sentance);
            Console.WriteLine(summary);

        }

        public static void stringBuilder()
        {
            var builder = new StringBuilder("Hello World");
            builder.AppendLine();
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);

            builder.Replace('-', '+');
            builder.Remove(0, 10);

            builder.Insert(0, new string('-', 10));
            Console.WriteLine(builder);
        }

        public static string pp(string input)
        {
            var array = new char[input.Length];
            for (var i = input.Length; i > 0; i--)
                array[input.Length - i] = input[i - 1];

            return new string(array);
        }


    }
}
