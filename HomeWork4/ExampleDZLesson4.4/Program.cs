namespace ExampleDZLesson4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Enter a character (W, A, S, D), (E - To exit): ");
                var inputSymbol = char.Parse(Console.ReadLine().ToUpper());
                
                switch(inputSymbol)
                {
                    case  'W':
                        Console.WriteLine("The figure has been moved to the top.");
                        break;
                    case 'S':
                        Console.WriteLine("The figure has been moved to the bottom.");
                        break;
                    case 'A':
                        Console.WriteLine("The figure has been moved to the left.");
                        break;
                    case 'D':
                        Console.WriteLine("The figure has been moved to the right.");
                        break;
                    case 'E':
                        Console.WriteLine("EXIST");
                        return;
                    default:
                        Console.WriteLine("There is no need to move.");
                        break;          
                }
                Console.WriteLine();
            }

        }
    }
}
