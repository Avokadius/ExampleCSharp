using ObjectEx.Models;

namespace ObjectEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person { Name = "Denis", Age = 41 };
            var p2 = new Person { Name = "Alex", Age = 33 };
            var p3 = new Person { Name = "Denis", Age = 41 };

            Console.WriteLine(p1);

            // GetHashCode() - для видимости 
            Console.WriteLine($"Hash Code of p1: {p1.GetHashCode()}");
            Console.WriteLine($"Hash Code of p2: {p2.GetHashCode()}");
            Console.WriteLine($"Hash Code of p3: {p3.GetHashCode()}");

            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(p3.Equals(p1));
            Console.WriteLine(p3 == p1);

            // Использование перегруженных операторов
            Console.WriteLine($"{p1.Name} старше, чем {p2.Name}: {p1 > p2}");
            Console.WriteLine($"{p1.Name} младше, чем {p2.Name}: {p1 < p2}");
        }
    }
}