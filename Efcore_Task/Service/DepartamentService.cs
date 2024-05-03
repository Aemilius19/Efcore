using Efcore_Task.Abstractions;
using Efcore_Task.DAL;
using Efcore_Task.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efcore_Task.Service
{
    internal class DepartamentService : IDepartamentService
    {
        AppDbcontext appcontext;
        public DepartamentService()
         {
            appcontext = new AppDbcontext();
        }
        public void AddEmployee(Employee employee)
        {
            appcontext.Employees.Add(employee);
            appcontext.SaveChanges();
        }

        public void AddDepartament(Departament departament)
        {
            appcontext.Departaments.Add(departament);
            appcontext.SaveChanges();
        }

        public void RemoveEmployee(int id)
        {
            appcontext.Remove(appcontext.Employees.Single(x=>x.Id==id));
            appcontext.SaveChanges();
        }

        public void RemoveDepartament(int id )
        {
            appcontext.Remove(appcontext.Employees.Single(x => x.Id == id));
            appcontext.SaveChanges();
        }

        public void UpdateEmp(int id,string name)
        {
                var employee = appcontext.Employees.First(x => x.Id == id);
                employee.Name = name;
                appcontext.SaveChanges();
        }

        public void UpdateDep(int id, string name)
        {
                var departament = appcontext.Departaments.First(x => x.Id == id);
                departament.Name = name;
                appcontext.SaveChanges();
        }

        public Employee GetEmployee(int id)
        {
            Employee employ=new Employee();
            foreach (var employee in appcontext.Employees.Include(x => x.Departament))
            {
                if (employee.Id == id) 
                { 
                    employ = employee;
                }
            }
            return employ;
        }

        public Departament GetDepartament(int id)
        {
            throw new NotImplementedException();
        }

        //public Departament GetDepartament(int id)
        //{

        //}
    }
}
