using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios13.Entities
{
    internal abstract class Taxpayer
    {
        public string Name { get; set; }
        public double Income { get; set; }

        public Taxpayer(string name, double income)
        {
            Name = name;
            Income = income;
        }

        public abstract double Taxes();
    }
}
