/*Напишите функцию, которая может принимать любое неотрицательное
 * целое число в качестве аргумента и возвращать его вместе с цифрами 
 * в порядке убывания. Переставьте цифры так, 
 * чтобы на выходе создать максимально возможное число.
 */

using System.Linq;
using System.Text;

namespace Doc.Ru.Programs.ChangeNumber;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please, please enter a positive integer: ");
        var userInput = Console.ReadLine();
        uint userNumber = 0;
        try
        {
            userNumber = Convert.ToUInt32(userInput);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Can not convert user input to number");
        }
        var result = ConvertNumber(userNumber);
        Console.WriteLine($"Result conver: {result}");
    }   
    
    public static uint ConvertNumber(uint userInputNumber)
    {
        var numbers = userInputNumber.ToString().OrderByDescending(x => x).ToList();
        var tmp = new StringBuilder();
        numbers.ForEach(x => tmp.Append(x));
        uint result = 0;
        try
        {
            result = Convert.ToUInt32(tmp.ToString());
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error when convert to result");
        }

        return result;
    }
}
