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
               // Console.WriteLine("manager inserted");


                var nEmployee = new Employee();
                nEmployee.EmpFirstName = "Kofo";
                nEmployee.EmpLastName = "Adebisi";
                nEmployee.EmpSalary = 300;
                nEmployee.ManagerId = 2;

                //context.Employees.Add(nEmployee);
                //context.SaveChanges();

                //Console.WriteLine("employee inserted");

                //var nEmployeeDetails = new EmployeeDetails();
                //nEmployeeDetails.Address = "4 simbi street mafoluku";
                //nEmployeeDetails.Email = "e@e.com";
                //nEmployeeDetails.EmployeeId = 1;
                //nEmployeeDetails.PhoneNumber = "1234567890";
                //var mEmployeeDetails = new EmployeeDetails();
                //mEmployeeDetails.Address = "5 simbi street shogunle";
                //mEmployeeDetails.Email = "e@e.com";
                //mEmployeeDetails.EmployeeId = 2;
                //mEmployeeDetails.PhoneNumber = "07030050019";

                //context.EmployeeDetails.AddRange(nEmployeeDetails, mEmployeeDetails);
                //context.SaveChanges();
                //Console.WriteLine("details inserted");

                var nProject = new Project();
                nProject.Name = "iTeco Meal Service";
                //context.Projects.Add(nProject);
                //context.SaveChanges();
                Console.WriteLine("Projects inserted");

                var nEmployeeProjects = new EmployeeProject();
                nEmployeeProjects.EmployeeId = 1;
                nEmployeeProjects.ProjectId = 1;
                context.EmployeeProject.Add(nEmployeeProjects);
                context.SaveChanges();
                Console.WriteLine("Employee projects saved");




            }


            Console.ReadLine();
        }
    }
}