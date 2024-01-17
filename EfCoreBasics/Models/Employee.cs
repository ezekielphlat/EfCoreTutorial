using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreBasics.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; } //primaryKey
        public string  EmpFirstName { get; set; }
        public string  EmpLastName { get; set; }
        public long EmpSalary { get; set; }

        // one to one relationship with EmployeeDetails
        public EmployeeDetails EmployeeDetails { get; set; } // reference navigaion to dependent

        //One to Many relationship with Manager
        public int ManagerId { get; set; } // Foreign Key property
        public Manager Manager { get; set; }

        public ICollection<EmployeeProject> EmployeeProjects { get; set; }

    }
}
