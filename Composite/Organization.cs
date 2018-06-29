using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Organization
    {
        private ICollection<Employee> employees = new List<Employee>();
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public float GetNetSalary()
        {
            float netSalary = 0;
            foreach (var emp in employees)
            {
                netSalary += emp.GetSalary();
            }
            return netSalary;
        }
    }
}
