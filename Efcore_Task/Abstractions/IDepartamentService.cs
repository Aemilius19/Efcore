using Efcore_Task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efcore_Task.Abstractions
{
    internal interface IDepartamentService
    {
        public void AddEmployee(Employee student);
        public void AddDepartament(Departament departament);
        public void RemoveEmployee(int id);
        public void RemoveDepartament(int id);
        public void UpdateEmp(int id, string name);
        public void UpdateDep(int id, string name);

        public Employee GetEmployee(int id);
        public Departament GetDepartament(int id);

        //Dep-1 Emp-0
    }
}
