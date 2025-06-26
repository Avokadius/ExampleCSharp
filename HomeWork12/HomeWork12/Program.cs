namespace HomeWork12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager();
            userManager.AddUser(new User { Name = "Denis", Age = 41, Email = "denis@example.com" });
            userManager.AddUser(new User { Name = "Alex", Age = 33, Email = "alex@example.com" });
            userManager.AddUser(new User { Name = "Maria", Age = 29, Email = "maria@example.com" });

            userManager.SaveUsers();

            Console.WriteLine("Список пользователей:");
            userManager.ShowUsers();

            // Завершение программы
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
