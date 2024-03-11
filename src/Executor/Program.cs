using CS50.Harvard.Lessons.Lesson1;
using CS50.Harvard.Lessons.Lesson2;
using CS50.Harvard.Lessons.Lesson3;
using CS50.Harvard.Lessons.Lesson4;
using System;

namespace CS50.Harvard.Lessons.Executor;

internal class Program
{
    public static bool Running = true;

    public static void Main(string[] args)
    {
        while (Running)
        {
            Console.WriteLine("Please choose an option from below");

            Console.WriteLine("1. Hello World");
            Console.WriteLine("2. Mario");
            Console.WriteLine("3. Cash");
            Console.WriteLine("4. Credit");
            Console.WriteLine("0. Exit Application");

            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Hello.EntryPoint(args);
                    break;
                case "2":
                    Mario.EntryPoint(args);
                    break;
                case "3":
                    Cash.EntryPoint(args);
                    break;
                case "4":
                    Credit.EntryPoint(args);
                    break;
                case "0":
                    Running = false;
                    Console.WriteLine("Exiting application");
                    break;
                default:
                    Console.WriteLine("Invalid option, please only type from the numbers from the menu");
                    break;
            }
        }
    }
}