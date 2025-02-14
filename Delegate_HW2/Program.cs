namespace Delegate_HW2
{
    internal class Program
    {
        delegate int ComparisonDelegate<T>(T x, T y);

        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Name = "John", Age = 30, Salary = 60000 },
                new Employee { Name = "Jane", Age = 25, Salary = 65000 },
                new Employee { Name = "Doe", Age = 35, Salary = 55000 }
            };

            Sort(employees, CompareByName);
            Console.WriteLine("Sorted by Name:");
            employees.ForEach(e => Console.WriteLine(e));

            Sort(employees, CompareByAge);
            Console.WriteLine("\nSorted by Age:");
            employees.ForEach(e => Console.WriteLine(e));

            Sort(employees, CompareBySalary);
            Console.WriteLine("\nSorted by Salary:");
            employees.ForEach(e => Console.WriteLine(e));
        }

        static void Sort<T>(List<T> list, ComparisonDelegate<T> comparison)
        {
            list.Sort((x, y) => comparison(x, y));
        }

        static int CompareByName(Employee x, Employee y)
        {
            return string.Compare(x.Name, y.Name);
        }

        static int CompareByAge(Employee x, Employee y)
        {
            return x.Age.CompareTo(y.Age);
        }

        static int CompareBySalary(Employee x, Employee y)
        {
            return x.Salary.CompareTo(y.Salary);
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Salary: {Salary}";
        }
    }
}
