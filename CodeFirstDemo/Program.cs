using CodeFirstDemo;

class Program
{
    public static void Main(string[] args)
    {
        EmployeeCRUD emp1 = new EmployeeCRUD();
        //emp1.insertEmployee();
        emp1.selectEmployee();
        emp1.deleteEmployee();
    }
}