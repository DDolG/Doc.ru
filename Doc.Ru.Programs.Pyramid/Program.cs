/*
 Дана бесконечная пирамида чисел:
             1
          3     5
       7     9    11
   13    15    17    19
21    23    25    27    29
...
Напишите функцию, которая вычисляет сумму строки 
этого треугольника из переданного в функцию индекса 
строки (начиная с индекса 1).
 */
namespace Doc.Ru.Programs.ChangeNumber;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please, please enter a positive integer number: ");
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
        var result = GetPyramidRowSumm(userNumber);
        Console.WriteLine($"Summ pyramid row element: {result}");
        Console.ReadKey();
    }

    public static ulong GetPyramidRowSumm(uint row)
    {
        ulong summ = 0;
        ulong elementValue = row * row - row + 1;
        var elementsInRow = row;
        while (elementsInRow-- > 0) {
            summ += elementValue;
            elementValue += 2;
        }
        return summ;
    } 
}