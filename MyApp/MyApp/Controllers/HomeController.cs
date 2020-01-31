using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyApp.Models;
using MyApp.ViewModels;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Teacher> teachers = new List<Teacher>()
            {
                new Teacher() { Name = "King1", Class = "One" },
                new Teacher() { Name = "King2", Class = "Two" },
                new Teacher() { Name = "King3", Class = "Three" },
                new Teacher() { Name = "King4", Class = "Four" }
            };
            var viewModel = new StudentTeacherViewModel()
            {
                Student = new Student(),
                Teacher = teachers
            };
            return View(viewModel);
        }


        public IActionResult Student()
        {
            List<Teacher> teachers = new List<Teacher>()
            {
                new Teacher() { Name = "King1", Class = "One" },
                new Teacher() { Name = "King2", Class = "Two" },
                new Teacher() { Name = "King3", Class = "Three" },
                new Teacher() { Name = "King4", Class = "Four" }
            };
            var viewModel = new StudentTeacherViewModel()
            {
                Student = new Student(),
                Teacher = teachers
            };
            return View(viewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Student(StudentTeacherViewModel model)
        {
            if (ModelState.IsValid)
            {
                //passed. proceed to next step
            }
            else
            {
                //show error
            }
            return View();
        }
      


    }
}
