namespace ExampleDZLesson6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager
            {
                Name = "Алексей ",
                Position = "Мененджер",
                WorkExperience = 365,
                CurrentProject = new Manager.Project
                {
                    ProjectName =  "Разработка приложений",
                    DeadLine = new DateTime(2025,12,31)
                } 
            };

            Manager TwoManager = new Manager
            {
                Name = "Володя ",
                Position = "Мененджер",
                WorkExperience = 257
            };

            Worker worker = new Worker
            {
                Name = "Виктория",
                Position = "Дизайнер",
                Speciality = "Графика",

            };

            Worker TwoWorker = new Worker()
            {
                Name = "Алексей",
                Position = "Программист",
                Speciality = "Python",
            };

            EmployeeRegistry.AddEmployee(worker);

            EmployeeRegistry.AddEmployee(manager);

            EmployeeRegistry.AddEmployee(TwoManager);

            EmployeeRegistry.AddEmployee(TwoWorker);

            EmployeeRegistry.ListAllEmployees();

            var findEmploy = EmployeeRegistry.FindEmployee("Виктория");

            if (findEmploy != null)
            {
                findEmploy.GetDetails();
            }
            else
            {
                Console.WriteLine("Не найдено!");
            }

        }
    }
}
