namespace HomeWork7_2;
internal class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int[,] arr = new int[3,3];

        for(var i = 0; i < arr.GetLength(0); i++)
        {   
            var maxValue = arr[i, 0];
            for (var j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = rnd.Next(1, 100);

                Console.Write($"{arr[i, j],4}");

                if (arr[i, j] >  maxValue)
                {
                    maxValue = arr[i, j];   
                }
            }
            Console.WriteLine($" Максимальное значение в строке {i + 1}: {maxValue}");
        }
    }
}
