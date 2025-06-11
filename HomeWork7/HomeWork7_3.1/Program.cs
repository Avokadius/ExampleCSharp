namespace HomeWork7_3._1;
internal class Program
{
    static bool Palindrom(string str)
    {
        var deleteStr = str.Replace(" ", "").ToLower();

        // Сравниваем строку с её обратной версией
        char[] charArray = deleteStr.ToCharArray();
        Array.Reverse(charArray);

        var reversedStr = new string(charArray);

        return deleteStr == reversedStr;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку для проверки является ли она палиндромом: ");
        var input = Console.ReadLine();

        if (Palindrom(input))
        {
            Console.WriteLine($"Слово {input} является палиндромом.");
        }
        else
        {
            Console.WriteLine($"Слово {input} не является палиндромом.");
        }

    }
}
