namespace HomeWork8;
public class Students
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double AverageScore { get; set; }
    public  void Print()
    {
        Console.WriteLine($"Имя: {Name}\n Возраст: {Age}\n Средний балл: {AverageScore}");
    }
}


