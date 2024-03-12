using CS50.Harvard.Lessons.Lesson4.BusinessLogic;
using CS50.Harvard.Lessons.Lesson4.Enums;
using CS50.Harvard.Lessons.Lesson4.Models;
using System;

namespace CS50.Harvard.Lessons.Lesson4;

public class Credit
{
    public static void EntryPoint(string[] args)
    {
        Console.WriteLine("Please enter the card number");
        var cardNumber = Console.ReadLine();

        var card = new Card();
        card.SetNumber(cardNumber);

        var cardType = CardCalculator.CalculateCardType(card);
        card.SetType(cardType);

        var isValidLength = CardCalculator.IsCardNumberLengthValid(card);
        if (isValidLength)
        {
            var isValidNumber = CardCalculator.CalculateLuhnAlgorithm(card);
            card.SetIsValid(isValidNumber);
        }
        else
        {
            card.SetIsValid(false);
            card.SetType(CardType.Unknown);
        }

        Console.WriteLine($"Card type: {card.GetType()}");
    }
}