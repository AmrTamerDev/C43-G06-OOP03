using Company;
namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employee = new Employee[3];
            employee[0] = new Employee(123, "Amr Tamer", ensecuritylevel.Developer, 150000, 6,2, 2025, 'M');
            employee[1] = new Employee(456, "Ahmed Khaled", ensecuritylevel.DBA, 18000, 9, 2, 2019, 'M');
            employee[2] = new Employee(789, "Ali Mohamed", ensecuritylevel.secretary, 19000, 13, 1, 2020, 'M');

            foreach (Employee newemployee in employee)
            {
                Console.WriteLine(newemployee);
                Console.WriteLine("------------------");
            }
        }
    }
}
