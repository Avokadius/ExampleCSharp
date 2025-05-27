namespace ExampleDZLesson6;
internal class Worker : EmployeeBase
{
    public string Speciality { get; set; }
    public override void GetDetails()
    {
        Console.WriteLine($"Имя {Name}, должность {Position}, Специальность {Speciality}");
    }
}

