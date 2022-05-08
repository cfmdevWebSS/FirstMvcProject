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
            return View(employeelist);
        }

        public ActionResult AddEmployee()
        {
            Employee employee = new Employee();
            return View(employee);
        }
        [HttpPost]
        public ActionResult AddEmployee(Employee employee)
        {
            return View();
        }

        public ActionResult UpdateEmployee()
        {
            return View();
        }
    }
}