using System.ComponentModel.Design;

namespace Example3DZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте,Введите Ваш возраст: ");

            var age = int.Parse(Console.ReadLine());
            Console.WriteLine(age);

            if (age < 0)
            {
                Console.WriteLine("Вы ввели что-то не то!");
            }
            else
            {
                if (age <= 2)
                {
                    Console.WriteLine("Младенец!");
                    
                }
                else if (age > 3 && age <= 12)
                {
                    Console.WriteLine("Ребенок!");
                }
                else if (age > 13 &&  age <= 17)
                {
                    Console.WriteLine("Подросток!");
                }
                else if (age >= 18 && age <= 59)
                {
                    Console.WriteLine("Взрослый!");
                }
                else
                {
                    Console.WriteLine("Пожилой!");
                }

                if (age % 2 == 0)
                {
                    Console.WriteLine($"Ваш возраст является четным: {age}");
                }
                else
                {
                    Console.WriteLine($"Ваш возраст является нечетным: {age}");
                }
            }
        }
    }
}
