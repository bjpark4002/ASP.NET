using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyApp.Models;

namespace MyApp.ViewModels
{
    public class StudentTeacherViewModel
    {
        public StudentTeacherViewModel()
        {


        }
        public Student Student { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Teacher> Teacher { get; internal set; }
    }
}




