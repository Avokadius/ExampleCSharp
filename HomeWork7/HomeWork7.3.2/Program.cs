using System.Text;

namespace HomeWork7._3._2;
internal class Program
{
    static string RemoveSpace(string str)
    {
        StringBuilder sb = new StringBuilder();

        foreach (char temp in str)
        {
            if (temp != ' ')
            {
                sb.Append(temp);
            }
        }
        return sb.ToString();
    }
    static void Main(string[] args)
    {

        Console.WriteLine("Введите строку: ");
        var input = Console.ReadLine();

        var result = RemoveSpace(input);
        Console.WriteLine($"строка без пробела: {result}");

    }
}
