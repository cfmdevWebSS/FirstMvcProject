using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstMvcProject.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Please fill in Id field")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please fill in Name field")]
        public string Name { get; set; }
        [Range(100,5000,ErrorMessage = "Salary must be between 100 and 5000 dollars")]
        public int Salary { get; set; }
    }
}