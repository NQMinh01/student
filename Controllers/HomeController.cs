using Microsoft.AspNetCore.Mvc;
using StudentDemo.Data;
using StudentDemo.Models;
using StudentDemo.Repository;
using System.Collections.Generic;
using System.Diagnostics;

namespace StudentDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;
        private readonly IStudentInterface _student;
        private readonly ILogger<HomeController> _logger;

        public HomeController(DataContext context,IStudentInterface student)
        {
            _context = context;
            _student = student;
        }

        [HttpGet]
        public async Task<ActionResult> GetListStudent()
        {
            var list = await _student.getListStudent();
            return Json( new {code=200, data = list , msg = "Get data success"});
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AddStudent(string name, DateTime birthday, int classId)
        {
            await _student.addStudent(name, birthday, classId);
            return Json(new { code = 200, msg = "Add success" });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
