
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Fundamentals
{
    internal class ConsoleCommands
    {

        public static void programsCMD()
        {
            Console.WriteLine();

            Console.WriteLine("Here are all the programs I wrote in this course.");
            Console.WriteLine("Type the program name to run the program.");
            Console.WriteLine();
            Console.WriteLine("NumberGuessingGame");
            Console.WriteLine("WhichIsLarger");
            Console.WriteLine("PictureOrientation");
            Console.WriteLine("SpeedLimit");
            Console.WriteLine("NumbersDivisibleBy3");
            Console.WriteLine("CalculateSum");
            Console.WriteLine("Factorial");
            Console.WriteLine("GuessingGame");
            Console.WriteLine("FindLargestNumber");
            Console.WriteLine("FaceBookLikes");
            Console.WriteLine("ReverseName");
            Console.WriteLine("FiveUniqueNumbers");
            Console.WriteLine("NumberList");
            Console.WriteLine("CommaSeparatedNumbers");
            Console.WriteLine("DateTimeExample");
            Console.WriteLine("TimeSpanExample");
            Console.WriteLine("StringMethods");
            Console.WriteLine("SummarisingText");
            Console.WriteLine("StringBuilder");
            Console.WriteLine("HyphenatedNumbers");
            Console.WriteLine("DuplicateNumbers");
            Console.WriteLine("VerifyTime");
            Console.WriteLine("PascalCase");
            Console.WriteLine("CountVowels");
            Console.WriteLine("ProceduralProgramming");
            Console.WriteLine("WordCount");
            Console.WriteLine("LongestWord");
            Console.WriteLine( "DeBugEx1");

            Console.WriteLine();
        }

        public static void helpCMD()
        {
            Console.WriteLine();
            Console.WriteLine("You can use the following commands:");
            Console.WriteLine("clear    : Clear Console");
            Console.WriteLine("exit     : Close Console");
            Console.WriteLine("programs : List All Available Programs");

            Console.WriteLine();
        }   

        public static void exitCMD()
        {
            Environment.Exit(0);
        }

        public static void clearCMD()
        {
            Console.Clear();
        }

        public static void numberguessinggameCMD()
        {
            Console.Clear();
            Exercise1.NGG();
        }

        public static void whichislargerCMD()
        {
            Console.Clear();
            Exercise1.WIL();
        }

        public static void pictureorientationCMD()
        {
            Console.Clear();
            Exercise1.PO();
        }

        public static void speedlimitCMD()
        {
            Console.Clear();
            Exercise1.SL();
        }

        public static void numbersdivisibleby3CMD()
        {
            Console.Clear();
            Exercise2.NDB3();
        }

        public static void calculatesumCMD()
        {
            Console.Clear();
            Exercise2.CS();
        }

        public static void factorialCMD()
        {
            Console.Clear();
            Exercise2.Fact();
        }

        public static void guessinggameCMD()
        {
            Console.Clear();
            Exercise2.GG();
        }

        public static void findlargestnumberCMD()
        {
            Console.Clear();
            Exercise2.FLN();
        }
        
        public static void facebooklikesCMD()
        {
            Console.Clear();
            Exercise3.FB_Likes();
        }

        public static void reversenameCMD()
        {
            Console.Clear();
            Exercise3.ReverseName();
        }

        public static void fiveuniquenumbersCMD()
        {
            Console.Clear();
            Exercise3.FiveUniqueNumbers();
        }

        public static void numberlistCMD()
        {
            Console.Clear();
            Exercise3.NumberList();
        }

        public static void commaseparatednumbersCMD()
        {
            Console.Clear();
            Exercise3.CommaSeparatedNumbers();
        }

        public static void datetimeexampleCMD()
        {
            Console.Clear();
            LecturePrograms.DateTimeExample();
        }

        public static void timespanexampleCMD()
        {
            Console.Clear();
            LecturePrograms.TimeSpanExp();
        }

        public static void stringmethodsCMD()
        {
            Console.Clear();
            LecturePrograms.stringMethods();
        }

        public static void summarisingtextCMD()
        {
            Console.Clear();
            LecturePrograms.summarisingText();
        }

        public static void stringbuilderCMD()
        {
            Console.Clear();
            LecturePrograms.stringBuilder();
        }

        public static void hyphenatednumbersCMD()
        {
            Console.Clear();
            Exercise4.hn();
        }

        public static void duplicatenumbersCMD()
        {
            Console.Clear();
            Exercise4.dup();
        }

        public static void verifytimeCMD()
        {
            Console.Clear();
            Exercise4.vt();
        }

        public static void pascalcaseCMD()
        {
            Console.Clear();
            Exercise4.pc();
        }

        public static void countvowelsCMD()
        {
            Console.Clear();
            Exercise4.cv();
        }

        public static void proceduralprogrammingCMD()
        {
            Console.Clear();
            Console.Write("What is your pet's name: ");
            var name = Console.ReadLine();
            //var reversed = LecturePrograms.pp(name);

            Console.WriteLine("Reversed name: " + LecturePrograms.pp(name));
        }

        public static void wordcountCMD()
        {
            Console.Clear();
            Console.WriteLine("Document Word Count: " + Exercise5.wc());
        }

        public static void longestwordCMD()
        {
            Console.Clear();
            Console.WriteLine("Document Word Count: " + Exercise5.lw());
        }

        public static void debugex1CMD()
        {
            Console.Clear();
            DebuggingExamples.dbex1();
        }

    }
}
