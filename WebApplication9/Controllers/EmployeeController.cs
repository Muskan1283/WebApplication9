using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Model;

namespace WebApplication9.Controllers
{
    public class EmployeeController : Controller
    {
        ApplicationDbContext app = new ApplicationDbContext();
        // GET: Employee
        public ActionResult Index()
        {
            List<Employee> emp = app.Employees.ToList();

            return View(emp);
        }
    }
}