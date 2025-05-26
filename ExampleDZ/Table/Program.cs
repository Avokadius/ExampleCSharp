namespace Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое булево значение (true или false): ");
            bool valueOne = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Введите второе булево значение (true или false): ");
            bool valueTwo = Convert.ToBoolean(Console.ReadLine());

            bool andBitwise = valueOne & valueTwo;      
            bool orBitwise = valueOne | valueTwo;       
            bool xorBitwise = valueOne ^ valueTwo;      
            bool andLogical = valueOne && valueTwo;     
            bool orLogical = valueOne || valueTwo;      
            bool notValueOne = !valueOne;               
            bool notValueTwo = !valueTwo;               

            Console.WriteLine($"\nРезультаты логических операций:");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("&\t|\t^\t&&\t||\t!\t!");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine($"{andBitwise}\t{orBitwise}\t{xorBitwise}\t{andLogical}\t{orLogical}\t{notValueOne}\t{notValueTwo}");
            Console.WriteLine("--------------------------------------------------------");


        }
    }
}
