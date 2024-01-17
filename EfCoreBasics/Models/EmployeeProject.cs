using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreBasics.Models
{
    // Junction table entity for many to many relationship between employee and project
    public class EmployeeProject
    {
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } // reference navigation

        public int ProjectId { get; set; }
        public Project Project { get; set; } // reference navigation
    }
}
