using CS50.Harvard.Lessons.Lesson3.Models;

namespace CS50.Harvard.Lessons.Lesson3.BusinessLogic;

public class CoinCalculator
{
    public static Cents Count(string coins)
    {
        var cents = new Cents();
        cents.SetAmountOwned(coins);

        var totalCount = 0;
        var coinSizes = new[] { 25, 10, 5, 1 };

        foreach (var coinSize in coinSizes)
        {
            var centsLeft = cents.GetAmountOwned();
            var count = centsLeft / coinSize;
            totalCount += count;
            cents.UpdateAmountOwned(centsLeft - coinSize * count);
        }

        cents.SetTotalCoins(totalCount);

        return cents;
    }
}
