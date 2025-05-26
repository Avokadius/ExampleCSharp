namespace ExampleDZLesson4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Все числа кратные 5: ");
            for (var i = -95; i <= 95; i += 5)
            {
                if(i <= -10 || i >= 10)
                {
                    Console.Write(i + "   ");
                }
                
            }
            Console.WriteLine();

        }
    }
}
