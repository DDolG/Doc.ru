/*Напишите функцию, которая принимает количество американской валюты 
 * центы (cents) и возвращает словарь / хэш, который показывает 
 * наименьшее количество монет, используемых для создания этой суммы.
 * Рассматриваются только номиналы монет: Pennies (1¢), Nickels (5¢), 
 * Dimes (10¢) and Quarters (25¢). Поэтому возвращаемый словарь 
 * должен содержать ровно 4 пары ключ / значение.
Примечания:
•	Если в функцию передается либо 0, либо отрицательное число, 
    то она должна возвращать словарь со всеми значениями, равными 0.
•	Если в функцию передается значение float, то его значение должно 
    быть округлено вниз, и результирующий словарь никогда не должен 
    содержать дробей монеты. 
*/
namespace Doc.Ru.Programs.Cents;

public class Program
{
    private static IDistributor _distributorCoin;

    public static void Main(string[] args)
    {
        Console.WriteLine("Please, enter cents: ");
        var userInput = Console.ReadLine();
        var coins = ConvertCentsToDifferentCoins(userInput);
        Console.WriteLine($"Result coins: ");
        coins.ToList().ForEach(x => Console.WriteLine($"{x.Key} : {x.Value}"));
        Console.ReadLine();
    }

    public static Dictionary<string, uint> ConvertCentsToDifferentCoins(string userInput)
    {
        var userNumber = ConvertUserInputToCents(userInput);
        _distributorCoin = new AlgorithmDistributionCoinMin();
        var vallet = _distributorCoin.DistributeMoneyToCoins(userNumber);
        var results = Converters.ValletToDictionary(vallet);
        return results;
    }

    private static uint ConvertUserInputToCents(string userInput)
    {
        uint userNumber = 0;
        var countAttemptToConvertNumber = 0;

        try
        {
            var tmp = Convert.ToInt32(userInput);
            userNumber = tmp > 0 ? (uint)tmp : 0;
            return userNumber;
        }
        catch (FormatException ex)
        { }

        try
        {
            var tmp = Convert.ToDouble(userInput);
            userNumber = tmp > 0 ? (uint)tmp : 0;
            return userNumber;
        }
        catch (FormatException ex)
        {}

        try
        {
            userNumber = Convert.ToUInt32(userInput);
            return userNumber;
        }
        catch (FormatException ex)
        { }

        throw new ArgumentException("You enter string that can not convert to number");
        
    }

}