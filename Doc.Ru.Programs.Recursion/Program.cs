/*Напишите функцию, которая в качестве аргумента принимает 
 * натуральное число n и возвращает сумму цифр этого числа. 
 * Если это значение имеет более одной цифры, 
 * продолжайте уменьшать его таким образом, 
 * пока не будет получено одноразрядное число. 
 * Это применимо только к натуральным числам. 
    Пример: 	my_function(16)    1 + 6 = 7
           my_function(942)    9 + 4 + 2 = 15    1 + 5 = 6
*/

namespace Doc.Ru.Programs.Recursion;

public class Program { 

    public static void Main(string[] args)
    {

        Console.WriteLine("Please, enter positive integer number: ");
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
        var result = GetRecursionNumb(userNumber);
        Console.WriteLine($"Summ of orders: {result}");
    }

    private static uint GetRecursionNumb(uint number) {
        
        uint result = number;
        var numberInString = number.ToString();
        if (numberInString.Count() > 1)
        {
            var orderNumbers = numberInString.Select(x => x.ToString()).ToList();
            result = 0;
            orderNumbers.ForEach(x => result += Convert.ToUInt32(x));
            if (result.ToString().Length > 1)
            {
                result = GetRecursionNumb(result);
            }
        }    
        return result;
    }
}
