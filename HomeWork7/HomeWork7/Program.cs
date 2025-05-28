namespace HomeWork7;
internal class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[6];

        for (var i = 0; i < 6; i++)
        {
            Console.WriteLine($"Вводим элемент {i + 1}");
            arr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr);
        Array.Reverse(arr);

        foreach (var temp in arr)
        {
            Console.Write(temp);
        }
    }
}
