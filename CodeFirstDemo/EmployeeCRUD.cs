using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    internal class EmployeeCRUD : IEmployee
    {
        public void deleteEmployee()
        {

            using (var db = new EmployeeContext())
            {

                Employee emp = new Employee();
                Console.WriteLine("Enter the employee id :");
                string empid= Console.ReadLine();
                if(Guid.TryParse(empid,out Guid empide))
                {
                    emp.Eid = empide;
                    db.Remove(emp);
                    db.SaveChanges();
                }
               
            }
        }

        public void insertEmployee()
        {
            using(var db=new EmployeeContext())
            {
                Employee emp = new Employee();
                emp.Eid = Guid.NewGuid();
                Console.WriteLine("Enter the employee name :");
                emp.EmployeeName = Console.ReadLine();
                Console.WriteLine("Enter the Role :");
                emp.Role = Console.ReadLine();
                db.Add(emp);
                db.SaveChanges();

            }


        }

        public void selectEmployee()
        {
            using (var db = new EmployeeContext())
            {

                Employee emp = new Employee();
                foreach (var i in db.IgtEmployees)
                {
                    Console.WriteLine("Employee Id : " + i.Eid);
                    Console.WriteLine("Employee Name : " + i.EmployeeName);
                    Console.WriteLine("Role : " + i.Role);
                }
            }
            
        }
    }
}
