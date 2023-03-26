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
        _distributorCoin = new AlgorithmDistributionCoinMin();
        /*Console.WriteLine("Please, enter cents: ");
        var userInput = Console.ReadLine();
        uint userNumber = 0;
        try
        {
            userNumber = Convert.ToUInt32(userInput);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Can not convert cents to number");
        }*/
        var result = _distributorCoin.DistributeMoneyToCoins((uint)17);
        
        //Console.WriteLine($"Summ of orders: {result}");
    }



}