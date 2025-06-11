namespace HomeWork7._3._3;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку: ");
        var input = Console.ReadLine();

        var lowercaseInput = input.ToLower();
        Console.WriteLine($"Все строчные: {lowercaseInput}");

        var uppercaseInput = input.ToUpper();
        Console.WriteLine($"Все строчные : {uppercaseInput}");

        string[] words = input.Split(' ');
        for(var i  = 0; i < words.Length; i++)
        {
            if (words[i].Length > 0)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
            }
        }
        string capitalized = string.Join(" ", words);
        Console.WriteLine($"Первая буква каждого слова в заглавной: {capitalized}");
    }
}
