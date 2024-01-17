using EfCoreBasics.Data;
using EfCoreBasics.Models;

namespace EfCoreBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            using(var context = new AppDbContext())
            {
                var newManager = new Manager();
                newManager.MngLastName = "Bob";
                newManager.MngFirstName = "Willer";
                newManager.MngSalary = 1000;

                context.Managers.Add(newManager);
                context.SaveChanges();
            }

            Console.ReadLine();
        }
    }
}