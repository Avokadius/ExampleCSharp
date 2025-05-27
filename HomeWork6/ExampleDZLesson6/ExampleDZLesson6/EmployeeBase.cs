namespace ExampleDZLesson6;
public abstract class EmployeeBase
{
    public string Name { get; set; }
    public string Position { get; set; }

    //Метод абстрактный
    public abstract void GetDetails();
}