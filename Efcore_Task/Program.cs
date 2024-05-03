using Efcore_Task.Models;
using Efcore_Task.Service;

namespace Efcore_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Departament departament = new Departament() 
            { 
                Name="Ab105"
            };
            Employee employee = new Employee()
            {
                Name = "Emil",
                Surname="abdurahimov",
                Age = 20,
                Position = "Ceo",
                Salary=1500,
                DepartamentId=1

            };
            

            DepartamentService service = new DepartamentService();

            service.AddDepartament(departament);

            service.AddEmployee(employee);

            service.RemoveEmployee(18);
           var data = service.GetEmployee(9);
            Console.WriteLine(data);


        }
    }
}
