﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreBasics.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }

        public ICollection<EmployeeProject> EmployeesProjects { get; set; }

    }
}
