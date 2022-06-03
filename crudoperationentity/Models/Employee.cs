using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace crudoperationentity.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage="please enter your name !!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "please enter your age !!")]
        public int Age { get; set; }
        [Required(ErrorMessage = "please enter your salary !!")]
        public int Salary { get; set; }
        public string Gender { get; set; }
        [Required(ErrorMessage = "please enter your address !!")]
        public string Address { get; set; }

    }
}
