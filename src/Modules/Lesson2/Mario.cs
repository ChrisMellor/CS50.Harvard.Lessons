using CS50.Harvard.Lessons.Lesson2.BusinessLogic;
using CS50.Harvard.Lessons.Lesson2.Models;
using System;

namespace CS50.Harvard.Lessons.Lesson2;

public class Mario
{
    public static void EntryPoint(string[] args)
    {
        Console.WriteLine("Welcome to Mario! Please enter the height of the pyramid");
        var height = Console.ReadLine();

        var pyramid = new Pyramid();
        pyramid.SetHeight(height);

        var message = MessageBuilder.GetMessage(pyramid);

        Console.WriteLine((string)message);
    }
}