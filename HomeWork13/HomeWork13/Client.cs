namespace HomeWork13;
public class Client
{
    private readonly string name;
    public Client(string name)
    {
        this.name = name;
    }
    public void ReceiveNews(string message)
    {
        Console.WriteLine($"{name} получил новость: {message}");
    }
}

