using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication8.Models;
namespace WebApplication8.Controllers 
{
    public class StudentController : Controller
    {
        StudentDataContext dataContext = new StudentDataContext();
        public IActionResult Index()
        {

            var students = dataContext.Students.ToList();
            return View(students);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            return View();
        }



    }
}
