using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabSQLEF.MVC.Models
{
    public class EmployeesView
    {
        [Required] public int ID { get; set; }
        [Required] public String Name { get; set; }
        [Required] public String LastName { get; set; }
        [Required] public String City { get; set; }
        [Required] public String Country { get; set; }
    }
}