namespace HomeWork8_2;

internal class Program
{
    static void Main(string[] args)
    {
        var products = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase)
        {
            {"Milk", 2.35 },
            {"Bread", 1.21 },
            {"Chokolate", 5.65 },
            {"Potatos", 3.35 },
            {"Tomat", 7.35 },
            {"Strawberry", 100.0},
            {"Donuts", 10.35 },
            {"Chees", 4.45 }
        };

        Console.WriteLine("Список продуктов: ");

        foreach(var temp in products)
        {
            Console.WriteLine(temp);
        }
        Console.WriteLine("\nВведите название продукта: ");

        var find = Console.ReadLine()?.ToLower();

        if (products.TryGetValue(find, out double info))
        {
            Console.WriteLine($"Продукт по запросу: {find} - Цена {info}");
        }
        else
        {
            Console.WriteLine("Продукт отсуствует!");
        }

        Console.WriteLine("Цена увеличена на 10%: ");
        foreach (var temp in products)
        {
           
            var interest = Math.Round(temp.Value * 1.1,2);
            
            Console.WriteLine($"{temp.Key}: {interest:F2}"); 
        }
    }
}
