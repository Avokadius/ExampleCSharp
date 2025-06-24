using System.Reflection.Metadata;
namespace HomeWork13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NewsProvider newsProvider = new NewsProvider();

            Client lyci = new Client("Люси");
            Client alla = new Client("Алла");
            Client bogdan = new Client("Богдан");

            newsProvider.Subscribe(lyci, "Новости");
            newsProvider.Subscribe(alla, "Спорт");
            newsProvider.Subscribe(bogdan, "Погода");
            newsProvider.Subscribe(bogdan, "Новости");
            newsProvider.Subscribe(lyci, "Спорт");

            newsProvider.Notify("Новости", "Сегодня важные события в мире.");
            newsProvider.Notify("Спорт", "Команда выиграла матч!");
            newsProvider.Notify("Погода", "Завтра ожидается дождь.");

            newsProvider.Unsubscribe(alla, "Спорт");
            newsProvider.Notify("Спорт", "Новые результаты чемпионата.");
        }
    }
}
