using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json.Serialization;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;



namespace C_Sharp_Fundamentals
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The Marzz06 Coding system.");
            Console.WriteLine("This is built for the Udemy course 'C# Basics for Beginners: Learn C# Fundamentals by Coding'.");
            Console.WriteLine("Using this system you can use variouse blocks of code written for this course.");
            
            while (true)
            {
                Console.WriteLine();                
                Console.WriteLine("Type 'help' for a list of commands.");
                Console.Write("Please enter a command: ");
                var inputCMD = Console.ReadLine();
                if (System.String.IsNullOrWhiteSpace(inputCMD))
                {
                    continue;
                }
                else
                {
                    string methodName = inputCMD.ToLower() + "CMD";
                    //Console.WriteLine(methodName);

                    // Retrieve the method using reflection
                    MethodInfo method = typeof(ConsoleCommands).GetMethod(methodName, new Type[0]);

                    if (method != null)
                    {
                        // Invoke the method if it's not null

                        method.Invoke(null, null);
                    }
                    else
                    {
                        Console.WriteLine("Method not found.");
                    }
                }
            }
        }           
    }
}
