namespace ExampleDZLesson6;
public class Manager : EmployeeBase
{
    // Уникальное свойство
    public int WorkExperience { get; set; }

    public Project CurrentProject { get; set; }
    public override void GetDetails()
    {
        Console.WriteLine($"Имя {Name}, должность {Position}, Опыт работы {WorkExperience}");

        if (CurrentProject != null )
        {
            CurrentProject.DisplayProjectInfo();
        }
    }
    public class Project
    {
        public string ProjectName { get; set; }
        public DateTime DeadLine { get; set; }

        public void DisplayProjectInfo()
        {
            Console.WriteLine($"Название проекта: {ProjectName}, Конечный срок {DeadLine}");
        }
    }
}
