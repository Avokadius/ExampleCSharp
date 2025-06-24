using System.Security.Claims;
namespace HomeWork13;
public class NewsProvider
{
    private readonly Dictionary<string, List<Client>> _subscribers = new();
    public void Subscribe(Client client, string category)
    {
        if (!_subscribers.ContainsKey(category))
        {
            _subscribers[category] = new List<Client>();
        }

        _subscribers[category].Add(client);
        Console.WriteLine($"{client.Name} подписался на категорию: {category} ");
    }
    public void Unsubscribe(Client client, string category)
    {
        if( _subscribers.ContainsKey(category))
        {
            _subscribers[category].Remove(client);
            Console.WriteLine($"{client.Name} отписался от категории: {category}");
        }
    }
    public void Notify(string category, string message)
    {
        if( !_subscribers.ContainsKey(category))
        {
            foreach(var client in _subscribers[category])
            {
                client.ReceiveNews(category, message);
            }
        }
    }
}
