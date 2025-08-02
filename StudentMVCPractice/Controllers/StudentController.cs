using Microsoft.AspNetCore.Mvc;

namespace StudentMVCPractice.Controllers;
public class StudentController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Create()
    {
        return View();
    }
}