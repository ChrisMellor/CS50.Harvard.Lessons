using CS50.Harvard.Lessons.Lesson3.BusinessLogic;
using System;

namespace CS50.Harvard.Lessons.Lesson3;

public class Cash
{
    public static void EntryPoint(string[] args)
    {
        Console.WriteLine("Welcome to Cash! Please enter the amount of change!");
        var change = Console.ReadLine();
        var coins = CoinCalculator.Count(change);

        Console.WriteLine(coins.GetTotalCoins());
    }
}