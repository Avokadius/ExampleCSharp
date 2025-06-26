namespace HomeWork12;
public class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Email: {Email}";
    }
}
