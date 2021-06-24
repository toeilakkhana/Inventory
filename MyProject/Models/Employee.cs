using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyProject.Models
{
    public class Employee
    {
        public string Emp_ID { get; set; }
        public string Emp_Name { get; set; }
        public string Department { get; set; }
        public string Company { get; set; }
        
    }
}
