using System.Security.Claims;
namespace HomeWork13;
public class NewsProvider
{
    private readonly Dictionary<string,List<Action<string>>> subscribers = new();

    public void Subscribe(string category, Action<string> subcriber)
    {
        if (!subscribers.ContainsKey(category))
        {
            subscribers[category] = new List<Action<string>>();
        }
        subscribers[category].Add(subcriber);
    }

    public void Unsubscribe(string category, Action<string> subcriber)
    {
        if (subscribers.ContainsKey(category))
        {
            subscribers[category].Remove(subcriber);
        }
    }

    public void Notify(string category, string message)
    {
        if (subscribers.ContainsKey(category))
        {
            foreach (var subscriber in subscribers[category])
            {
                subscriber(message);
            }
        }
    }
}
