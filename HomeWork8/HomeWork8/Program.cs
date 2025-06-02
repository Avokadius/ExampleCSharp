namespace HomeWork8;
internal class Program
{
    static void Main(string[] args)
    {
        Students studentsJack = new Students
        {
            Name = "Jack",
            Age = 16,
            AverageScore = 7.0
        };

        Students studentsAnna = new Students
        {
            Name = "Anna",
            Age = 17,
            AverageScore = 9.1
        };

        Students studentsAlexandr = new Students
        {
            Name = "Alexandr",
            Age = 17,
            AverageScore = 6.5
        };

        Students studentAlice = new Students
        {
            Name = "Alice",
            Age = 18,
            AverageScore = 9.1
        };

        Students studentDaniel = new Students
        {
            Name = "Deniel",
            Age = 16,
            AverageScore = 8.1
        };

        Students studentOli = new Students
        {
            Name = "Oli",
            Age = 16,
            AverageScore = 6.1
        };


        ListStudents.AddStudents(studentsJack);
        ListStudents.AddStudents(studentsAnna);
        ListStudents.AddStudents(studentsAlexandr);
        ListStudents.AddStudents(studentAlice);
        ListStudents.AddStudents(studentDaniel);
        ListStudents.AddStudents(studentOli);

        
        ListStudents.ListAll();

        Console.WriteLine();

        var yangestStudent = ListStudents.FinedYoungestStudent();
        if(yangestStudent != null)
        {
            Console.WriteLine("Самый младший студент: ");
            yangestStudent.Print();
        }
        else
        {
            Console.WriteLine("Список пуст.");
        }
    }
}
