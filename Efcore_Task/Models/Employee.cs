using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efcore_Task.Models
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        public int DepartamentId { get; set; }
        public Departament Departament { get; set; }

        public override string ToString()
        {
            return $"{Name} , {Surname} , {Age} , {Position} , {Departament.Name} ";
        }
    }
}
