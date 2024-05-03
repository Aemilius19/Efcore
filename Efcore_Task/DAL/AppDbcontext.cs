using Efcore_Task.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efcore_Task.DAL
{
    internal class AppDbcontext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=CA-R215-PC06\\SQLEXPRESS;database=Efcore_Departament;trusted_connection=true;Encrypt=false;TrustServerCertificate=True");
        }

        public DbSet<Departament> Departaments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
