using FirstMvcProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMvcProject.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            List<Employee> employeelist = new List<Employee>();
            var employee = new Employee();
            employee.Id = 1;
            employee.Name = "John Smith";
            employee.Salary = 131000;
            employeelist.Add(employee);
            var emp2 = new Employee();
            emp2.Id = 2;
            emp2.Name = "Joe Gotcha";
            emp2.Salary = 99000;
            employeelist.Add(emp2);
            ViewData["Age"] = 20;
            ViewBag.Job = "Engineer";
            string company2 = "N.F.String";
            TempData["company"] = company2;
            return View(employeelist);
        }

        public JsonResult GetDateWithJson()
        {
            string JsonDate = DateTime.Today.ToShortDateString();
            return Json(JsonDate);
        }

        public ActionResult AddEmployee()
        {
            Employee employee = new Employee();
            return View(employee);
        }
        [HttpPost]
        public ActionResult AddEmployee(Employee employee)
        {
            string textvalue = "";
            if (ModelState.IsValid)
            {
                textvalue = "Model State is valid";
            }
            else 
            {
                textvalue = "Model State is NOT valid";
            }
            return View(employee);
        }

        public ActionResult UpdateEmployee()
        {
            var employee = new Employee();
            employee.Id = 1;
            string company = (string)TempData["company"];
            employee.Name = company;
            employee.Salary = 50000;
            return View(employee);
        }

        [HttpPost]
        public ActionResult UpdateEmployee(Employee employee)
        {
            return View(employee);
        }
    }
}