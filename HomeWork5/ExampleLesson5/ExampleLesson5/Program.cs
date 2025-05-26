namespace ExampleLesson5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Таинственный остров", "Жюль Верн", 1000);

            book.GetDescription();
        }
    }
}
