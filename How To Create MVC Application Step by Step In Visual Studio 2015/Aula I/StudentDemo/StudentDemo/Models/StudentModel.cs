using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace StudentDemo.Models
{
    public class StudentModel
    {
        [Required(ErrorMessage = "Student Name is Required")]
        [MaxLength(150, ErrorMessage = "Student Name Can't be more then 150 caracters length")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Class name is required")]
        public string Class { get; set; }
    }
}