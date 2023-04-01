using System.Globalization;
namespace exercicios9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("\nEmployee #{0}", i);
                Console.Write("\nid: ");
                int idfor = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                list.Add(new Employee(idfor,name,salary));
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int id = int.Parse(Console.ReadLine());
            Employee r = list.Find(x => x.Id == id);

            if(r != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                r.IncreasySalaryByPercentage(percentage);
            }
            else Console.WriteLine("This id does not exist.");
            
            foreach(Employee i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}