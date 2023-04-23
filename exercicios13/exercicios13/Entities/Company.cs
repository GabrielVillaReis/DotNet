using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios13.Entities
{
    internal class Company : Taxpayer
    {
        public int EmployeeNumb { get; set; }

        public Company(string name, double income, int employeeNumb) : base(name, income)
        {
            EmployeeNumb = employeeNumb;
        }

        public override double Taxes()
        {

            if (EmployeeNumb < 11)
            {
                return Income * 0.16;
            }
            else
            {
                return Income * 0.14;
            }
        }
    }
}
