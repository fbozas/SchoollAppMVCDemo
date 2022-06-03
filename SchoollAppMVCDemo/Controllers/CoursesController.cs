using SchoollAppMVCDemo.Services;
using System;
using System.Linq;
using System.Web.Mvc;

namespace SchoollAppMVCDemo.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Courses
        public ActionResult Index()
        {
            var courses = CourseService.Courses;
            return View(courses);
        }

        public ActionResult Details(int id)
        {
            try
            {
                var course = CourseService.Courses.First(c => c.ID == id);
                return View(course);
            }
            catch(Exception ex)
            {
                TempData["ErrorMessage"] = $"No course with ID {id.ToString()} found";
                return RedirectToAction("Index");
            }
        }
    }
}