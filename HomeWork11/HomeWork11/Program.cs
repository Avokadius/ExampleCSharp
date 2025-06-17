namespace HomeWork11;
internal class Program
{
    static void Main(string[] args)
    {
        NumberValidator validatr = new NumberValidator();

        var inumber = Convert.ToInt32(Console.ReadLine());  
        try
        {
            validatr.ValidateNumber(inumber);
        }
        catch (OutOfRangeException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Общая ошибка: {ex.Message}");
        }
    }
}
