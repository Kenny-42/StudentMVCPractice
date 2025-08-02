using Microsoft.AspNetCore.Mvc;
using StudentMVCPractice.Models;

namespace StudentMVCPractice.Controllers;
public class StudentController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Student s)
    {
        if (ModelState.IsValid)
        {
            // Add student to the database

            // Redirect to student list page
            return RedirectToAction("Index");
        }

        // Show web page with error messages
        return View(s);
    }
}