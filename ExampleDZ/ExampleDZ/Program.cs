namespace ExampleDZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Ваше имя: ");
            Console.WriteLine("Введите Ваш возраст: ");
            Console.WriteLine("введите Ваш рост: ");


            var name = Console.ReadLine();
            
            var age = Convert.ToInt32(Console.ReadLine());

            var height = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine($"Привет {name}!\n\t Ваш возраст: {age} лет.\n\t\t Ваш рост: {height} м.");
        }
    }
}
