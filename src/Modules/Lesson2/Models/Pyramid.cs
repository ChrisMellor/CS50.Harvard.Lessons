using System;

namespace CS50.Harvard.Lessons.Lesson2.Models;

public class Pyramid
{
    internal int Height { get; set; }

    public int GetHeight()
    {
        return Height;
    }

    public void SetHeight(string input)
    {
        var success = int.TryParse(input, out var height);

        if (!success)
        {
            throw new ArgumentException("Height must be a number");
        }

        if (height <= 1)
        {
            throw new ArgumentOutOfRangeException(nameof(height), "Height must be above 1");
        }

        Height = height;
    }
}