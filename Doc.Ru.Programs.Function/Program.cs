/*Как на счет функции, которая не принимает аргументов 
 * и всегда возвращает 5? Звучит просто, не правда ли? 
 * Просто имейте в виду, что вы не можете использовать 
 * ни один из следующих символов: 
    0 1 2 3 4 5 6 7 8 9 * +- /
 * Напишите несколько реализаций такой функции 
 * использующих разный подход к задаче.
*/
using System.Net.Security;

namespace Doc.Ru.Programs.Functions;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Get five by string lenght: " + GetFiveByString());
        Console.WriteLine("Get five by hex format: " + GetFiveByHex());
        Console.WriteLine("Get five by binary format: " + GetFiveByBinaryFormat());
    }

    public static int GetFiveByString()
    {
        var str = "Hello";
        return str.Length;
    }

    public static int GetFiveByHex()
    {
        var first = 0xF;
        var second = 0xA;
        return (first - second);
    }

    public static int GetFiveByBinaryFormat()
    {
        return Convert.ToInt32("101", 2); ;
    }
}
