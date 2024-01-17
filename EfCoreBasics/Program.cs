using EfCoreBasics.Data;
using EfCoreBasics.Models;

namespace EfCoreBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            // insert manager into the db because we need the ID inside employee
            using(var context = new AppDbContext())
            {
                //var newManager = new Manager();
                //newManager.MngLastName = "Bob";
                //newManager.MngFirstName = "Willer";
                //newManager.MngSalary = 1000;

                //context.Managers.Add(newManager);
                //context.SaveChanges();
                Console.WriteLine("manager inserted");


                var nEmployee = new Employee();
                nEmployee.EmpFirstName = "Abisola";
                nEmployee.EmpLastName = "Adebambo";
                nEmployee.EmpSalary = 1000;
                nEmployee.ManagerId = 2;

                context.Employees.Add(nEmployee);
                context.SaveChanges();
                Console.WriteLine("employee inserted");
            }


            Console.ReadLine();
        }
    }
}