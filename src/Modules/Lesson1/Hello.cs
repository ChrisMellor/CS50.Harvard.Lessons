using CS50.Harvard.Lessons.Lesson1.BusinessLogic;
using CS50.Harvard.Lessons.Lesson1.Models;
using System;

namespace CS50.Harvard.Lessons.Lesson1;

public class Hello
{
    public static void EntryPoint(string[] args)
    {
        Console.WriteLine("Welcome to Hello World! Please enter your name!");
        var name = Console.ReadLine();

        var person = new Person();
        person.SetName(name);

        var message = MessageBuilder.GetMessage(person);

        Console.WriteLine((string)message);
    }
}
