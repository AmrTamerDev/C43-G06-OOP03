using Company;
using LibraryManagementSystem;
namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[3];
            employees[0] = new Employee(123, "Amr Tamer", ensecuritylevel.Developer, 150000, 6,2, 2025, 'M');
            employees[1] = new Employee(456, "Ahmed Khaled", ensecuritylevel.DBA, 18000, 9, 2, 2019, 'M');
            employees[2] = new Employee(789, "Ali Mohamed", ensecuritylevel.secretary, 19000, 13, 1, 2020, 'M');
            
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
                Console.WriteLine("------------------");
            }

            EBook eBook = new EBook("Programming", "Developer", "123-639", 250);
            Console.WriteLine(eBook);
            PrintedBook printedBook = new PrintedBook("C++", "Dev", "123-874", 1000);
            Console.WriteLine(printedBook);
        }
    }
}
