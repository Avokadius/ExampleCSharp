namespace ExampleDZLesson6;

static class EmployeeRegistry
{
    private static List<EmployeeBase> employees = new List<EmployeeBase>();
    public static void AddEmployee(EmployeeBase employee)
    {
        employees.Add(employee);
    }
    public static void ListAllEmployees()
    {
       
        foreach (EmployeeBase temp in employees)
        {
            temp.GetDetails();
        }

    }
    public static EmployeeBase? FindEmployee(string name)
    {
        foreach(EmployeeBase temp in employees)
        {
            if(temp.Name.ToLower() == name.ToLower()) 
            return temp;
        }
        return null;
    }
}
