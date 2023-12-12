using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    internal class Employee
    {
        [Key]
        public Guid Eid { get; set; } = new Guid();
        public string EmployeeName { get; set; }
        public string Role { get; set; }

    }
}
