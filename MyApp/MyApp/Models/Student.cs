using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace MyApp.Models
{
    public class Student
    {
        public Student()
        {
        }
        public int Id { get; set; }
        //write prop and tap twice. ( short key for creating getset)
        //[BindNever]
        [Required]
        [MaxLength(5)]
        public string Name { get; set; }
        [Range(10,40)]
        public int Age { get; set; }
        [Required,MinLength(4)]
        public string Country { get; set; }


    }
}
