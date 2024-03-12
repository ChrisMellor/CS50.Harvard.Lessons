using CS50.Harvard.Lessons.Lesson4.Enums;
using System;

namespace CS50.Harvard.Lessons.Lesson4.Models;
public class Card
{
    internal string Number { get; set; }
    internal bool IsValid { get; set; }
    internal CardType Type { get; set; }

    public string GetNumber()
    {
        return Number;
    }

    public void SetNumber(string number)
    {
        if (string.IsNullOrEmpty(number))
        {
            throw new ArgumentNullException(nameof(number));
        }

        Number = number;
    }

    public bool GetIsValid()
    {
        return IsValid;
    }

    public void SetIsValid(bool isValid)
    {
        IsValid = isValid;
    }

    public new CardType GetType()
    {
        return Type;
    }

    public void SetType(CardType type)
    {
        Type = type;
    }
}
