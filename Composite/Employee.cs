using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class Employee
    {
        public Employee(string name, float salary) { }
        public abstract string GetName();
        public abstract void SetSalary(float salary);
        public abstract float GetSalary();
    }
}
