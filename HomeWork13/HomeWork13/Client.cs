namespace HomeWork13;
public class Client
{
    public string Name { get;}
    public Client(string name)
    {
        Name = name;
    }
    public void ReceiveNews(string category, string message)
    {
        Console.WriteLine($"[{category}] {Name} получил новость: {message}");
    }
}
