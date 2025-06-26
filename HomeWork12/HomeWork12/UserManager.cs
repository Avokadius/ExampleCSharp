using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace HomeWork12;
public class UserManager
{
    private const string FilePath = "users.json";
    public List<User> Users {  get; private set; }

    public UserManager()
    {
        Users = LoadUsers();
    }
    public void AddUser(User user)
    {
        Users.Add(user);
    }
    public void ShowUsers()
    {
        foreach (var user in Users)
        {
            Console.WriteLine(user);
        }
    }
    public void SaveUsers()
    {
        var json = JsonSerializer.Serialize(Users);
        File.WriteAllText(FilePath, json);
    }
    public List<User> LoadUsers()
    {
        if (File.Exists(FilePath))
        {
            var json = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
        }
        return new List<User>();
    }
}

