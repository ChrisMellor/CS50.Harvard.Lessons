using System;

namespace CS50.Harvard.Lessons.Lesson3.Models;

public class Cents
{
    internal int AmountOwned { get; set; }
    internal int TotalCoins { get; set; }

    public int GetAmountOwned()
    {
        return AmountOwned;
    }

    public void SetAmountOwned(string input)
    {
        var success = int.TryParse(input, out var cents);

        if (!success)
        {
            throw new ArgumentException("Cents must be a number");
        }

        if (cents <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(input), "Cents must be above 0");
        }

        AmountOwned = cents;
    }

    public void UpdateAmountOwned(int coinsLeft)
    {
        AmountOwned = coinsLeft;
    }

    public int GetTotalCoins()
    {
        return TotalCoins;
    }

    public void SetTotalCoins(int coins)
    {
        if (coins <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(coins), "Coins must be above 0");
        }

        TotalCoins = coins;
    }
}