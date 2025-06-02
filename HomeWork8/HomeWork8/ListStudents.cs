using System.Diagnostics;

namespace HomeWork8;

public class ListStudents
{
    public static List<Students> studentList = new List<Students>();
    public static void AddStudents(Students student)
    {
        studentList.Add(student);
    }
    public static void ListAll()
    {
        //Сортировка списка по среднему баллу от большего к меньшему 
        var sortedList = studentList.OrderByDescending(s => s.AverageScore).ToList();

        foreach (var temp in sortedList)
        {
            temp.Print();
        }
    }
    public static Students FinedYoungestStudent()
    {
        return studentList.OrderBy(s => s.Age).FirstOrDefault();
    }


}
