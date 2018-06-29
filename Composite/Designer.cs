using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Designer : Employee
    {
        string name;
        float salary;
        public Designer(string name, float salary) : base(name, salary)
        {
            this.name = name;
            this.salary = salary;
        }
        public override string GetName()
        {
            return this.name;
        }

        public override float GetSalary()
        {
            return this.salary;
        }

        public override void SetSalary(float salary)
        {
            this.salary = salary;
        }
    }
}
