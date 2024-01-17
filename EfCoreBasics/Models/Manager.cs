using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreBasics.Models
{
    public class Manager
    {
        public int ManagerId { get; set; } // primary key
        public string MngFirstName { get; set; }
        public string MngLastName { get; set; }
        public long MngSalary { get; set; }

        public ICollection<Employee> Employees { get; set; } // Collection navigation
        //property to represent the employees managed by manager
    }
}
