namespace HomeWork11;
public class OutOfRangeException : Exception
{
    public OutOfRangeException() : base ("число выходит за предел диапазона!")
    {
    }
    public OutOfRangeException(string message) : base(message)
    {
    }
    public OutOfRangeException(string message, Exception inner) : base(message, inner)
    {
    }
}

