using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    internal class EmployeeContext : DbContext
    {
        string MyConString = "Data Source=REV-PG02C4Y5;Initial Catalog=igt;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=False;Trust Server Certificate=False;Command Timeout=0";
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(MyConString);
        }

        public DbSet<Employee> IgtEmployees { get; set; }
    }
}
