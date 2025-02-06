using Company;
namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(123, "Amr Tamer", ensecuritylevel.Developer, 150000, new DateTime(2025,2,6), 'M');
            Console.WriteLine(employee1);
            HiringDate date = new HiringDate(2025, 2, 6);
            Console.WriteLine(date);
        }
    }
}
