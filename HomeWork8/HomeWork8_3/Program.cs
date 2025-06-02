namespace HomeWork8_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текс: ");
            
            var input = Console.ReadLine();

            var words = input.ToLower()
                .Split(new char[] { ' ', '.', ',', ';', '!', '?' },
                StringSplitOptions.RemoveEmptyEntries);

            //Создаем словарь для подсчета частоты слов
            Dictionary<string,int> wordsCount = new Dictionary<string,int>();

            foreach (var item in words)
            {
                if (wordsCount.ContainsKey(item))
                {
                    wordsCount[item]++;
                }
                else
                {
                    wordsCount[item] = 1;
                }
            }

            Console.WriteLine("Вывод уникальных слов: ");
            foreach(var temp in wordsCount)
            {
                Console.WriteLine($"{temp.Key}: {temp.Value}");
            }
        }
    }
}
