using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            //Подготовка сотрудников
            Employee empJohn = new Designer("John", 12000);
            Employee empJue = new Developer("Jue", 1500);
            // Добавляем их в организацию
            Organization organization = new Organization();
            organization.AddEmployee(empJohn);
            organization.AddEmployee(empJue);

            Console.WriteLine($"Оклад - {organization.GetNetSalary()}");

            Console.ReadKey();

        }
    }
}
