using System;

namespace CS50.Harvard.Lessons.Lesson1.Models;

public class Person
{
    internal string Name { get; set; }

    public string GetName()
    {
        return Name;
    }

    public void SetName(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentNullException(nameof(name), "Name cannot be null or empty");
        }

        Name = name;
    }
}