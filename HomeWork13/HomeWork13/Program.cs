using System.Reflection.Metadata;
namespace HomeWork13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var newsProvider = new NewsProvider();

            // Создаем клиентов
            var client1 = new Client("Клиент 1");
            var client2 = new Client("Клиент 2");

            // Подписываем клиентов на разные категории
            newsProvider.Subscribe("новости", client1.ReceiveNews);
            newsProvider.Subscribe("погода", client2.ReceiveNews);

            // Рассылаем новости
            newsProvider.Notify("новости", "Сегодня новое событие в мире!");
            newsProvider.Notify("погода", "Сегодня солнечно и тепло.");

            // Отписываем клиента 1 от новостей
            newsProvider.Unsubscribe("новости", client1.ReceiveNews);

            // Рассылаем еще одну новость
            newsProvider.Notify("новости", "Новое событие в спорте!");
        }
    }
}
