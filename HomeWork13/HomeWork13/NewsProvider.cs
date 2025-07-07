using System.Security.Claims;
namespace HomeWork13;
public class NewsProvider
{
    public event Action<string> NewsReceived;
    public event Action<string> WeatherReceived;
    public void NotifyNews(string message)
    {
        NewsReceived?.Invoke(message);
    }
    public void NotifyWeather(string message)
    {
        WeatherReceived?.Invoke(message);
    }
}
