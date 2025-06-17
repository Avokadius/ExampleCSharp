namespace HomeWork11;
public class NumberValidator
{
    private const int MinValue = 1;
    private const int MaxValue = 100;
    public void ValidateNumber(int number)
    {
        if(number < MinValue || number > MaxValue)
        {
            throw new OutOfRangeException();
        }
        Console.WriteLine($"Число {number} в пределах допустимого значения.");
    }
}
