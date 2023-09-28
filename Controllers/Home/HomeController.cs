using Lab3NET.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab3NET.Controllers.Home
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SongForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Sing()
        {
            ViewBag.numMonkey = Request.Form["numMonkey"];

            return View();
        }
        public IActionResult CreateStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DisplayStudent(Student student)
        {
            if (student.FirstName.Equals("") 
                || student.LastName.Equals("") 
                || student.StudentId == 0 
                || student.EmailAddress.Equals("") 
                || student.Description.Equals(""))
            {
                throw new Exception();
            }
            return View(student);
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
