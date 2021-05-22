using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index(int departmentId)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List<Employee> employees = employeeContext.Employees.Where(
                emp => emp.DepartmentId == departmentId
                ).ToList();
            return View(employees);
        }
        public ActionResult Details(int id)
        {
            /************
             Employee employee = new Employee()
            {
                EmployeeId = 101,
                Name = "John",
                Gender = "Male",
                City = "Tokyo"
            };
            ***********/

            EmployeeContext employeeContext = new EmployeeContext();

            /**************
             foreach(var x in employeeContext.Employees)
            {
                Console.WriteLine(x);
            }
            *************/
            Employee employee = employeeContext.Employees.Single(emp => emp.EmployeeId == id);
            return View(employee);
        }
    }
}