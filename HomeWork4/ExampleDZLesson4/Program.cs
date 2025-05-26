namespace ExampleDZLesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            var arr = new int[] {123,465,789,000,111,01,11,00,10 };

            Console.WriteLine($"Looping through an array using for:");
            for (var i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");

            var index = 0;

            Console.WriteLine($"Looping through an array using while:");
            while (index < arr.Length)
            {
                Console.Write(arr[index] + " ");
                index++;
            }
            Console.WriteLine("\n");

            Console.WriteLine($"Looping through an array using foreach: ");

            foreach(var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");

            var indexDo = 0;

            Console.WriteLine($"Looping through an array using do while: ");
            do
            {
                Console.Write(arr[indexDo] + " ");
                indexDo++;
            }
            while (indexDo < arr.Length); //Условие будет продолжаться!

            Console.WriteLine();



        }
    }
}
