using System.Reflection.Metadata;
namespace HomeWork13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var newsProvider = new NewsProvider();

            var client1 = new Client("Клиент 1");
            var client2 = new Client("Клиент 2");

            newsProvider.NewsReceived += client1.ReceiveNews;
            newsProvider.WeatherReceived += client2.ReceiveNews;

            newsProvider.NotifyNews("Сегодня новое событие в мире!");
            newsProvider.NotifyWeather("Сегодня солнечно и тепло.");

            newsProvider.NewsReceived -= client1.ReceiveNews;

            newsProvider.NotifyNews("Новое событие в спорте!");
        }
    }
}
