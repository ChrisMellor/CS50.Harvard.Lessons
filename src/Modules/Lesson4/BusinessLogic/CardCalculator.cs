using CS50.Harvard.Lessons.Lesson4.Enums;
using CS50.Harvard.Lessons.Lesson4.Models;
using System.Collections.Generic;

namespace CS50.Harvard.Lessons.Lesson4.BusinessLogic;
public class CardCalculator
{
    public static CardType CalculateCardType(Card card)
    {
        var cardPrefixes = new Dictionary<string, CardType>
        {
            {"4", CardType.Visa},
            {"51", CardType.MasterCard},
            {"52", CardType.MasterCard},
            {"53", CardType.MasterCard},
            {"54", CardType.MasterCard},
            {"55", CardType.MasterCard},
            {"34", CardType.AmericanExpress},
            {"37", CardType.AmericanExpress}
        };

        var cardNumber = card.GetNumber();

        foreach (var prefix in cardPrefixes.Keys)
        {
            if (cardNumber.StartsWith(prefix))
            {
                return cardPrefixes[prefix];

            }
        }

        return CardType.Unknown;
    }

    public static bool CalculateLuhnAlgorithm(Card card)
    {
        var cardNumber = card.GetNumber();
        var sum = 0;
        var isEvenDigit = false;
        for (var i = cardNumber.Length - 1; i >= 0; i--)
        {
            var digit = cardNumber[i] - '0';
            if (isEvenDigit)
            {
                digit *= 2;
                if (digit > 9)
                {
                    digit -= 9;
                }
            }
            sum += digit;
            isEvenDigit = !isEvenDigit;
        }

        return sum % 10 == 0;
    }

    public static bool IsCardNumberLengthValid(Card card)
    {
        var cardNumber = card.GetNumber();
        var cardType = card.GetType();

        switch (cardType)
        {
            case CardType.Visa:
                return cardNumber.Length is 13 or 16;
            case CardType.MasterCard:
                return cardNumber.Length == 16;
            case CardType.AmericanExpress:
                return cardNumber.Length == 15;
            default:
                return false;
        }
    }
}