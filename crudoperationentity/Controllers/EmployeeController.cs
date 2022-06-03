using crudoperationentity.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudoperationentity.Controllers
{
    public class EmployeeController : Controller
    {
        private  ApplicationContext context;

        public EmployeeController(ApplicationContext dbcontext)
        {
            context = dbcontext;
        }

       

        public IActionResult Index()
        {
            var emp = context.Employees.ToList();
            ViewData["sms"] = "Your description page.";
            return View(emp);

        }
        public IActionResult Create()
        {
            ViewData["sms"] = "Your page.";
            return View();
        }


        [HttpPost]
        public IActionResult Create(Employee obj)
        {
            if (ModelState.IsValid) { 
            
                Employee emp = new Employee()
            {
                Name = obj.Name,
                Age = obj.Age,
                Salary = obj.Salary,
                Address = obj.Address,
                Gender = obj.Gender
            };
            context.Employees.Add(emp);
            context.SaveChanges();
            return RedirectToAction("Index");

            }
            else
            {
                return View();
            }
        }
        public IActionResult Delete(int id)
        {
            var emp = context.Employees.SingleOrDefault(e => e.Id == id);
            if (emp != null)
            {
                context.Employees.Remove(emp);
                context.SaveChanges();
                TempData ["error"] = "Employee deleted!";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["error"] = "Employee not found!";
                return RedirectToAction("Index");
            }
        }
        public IActionResult Update(int id)
        {
            var db = context.Employees.SingleOrDefault(e => e.Id == id);
            if (db != null) { 
            var model = new Employee()
            {
                Name = db.Name,
                Age = db.Age,
                Salary = db.Salary,
                Address = db.Address,
                Gender = db.Gender
            };
            return View(model);
            }
            else
            {
                TempData["error"] = "Employee not found";
                return RedirectToAction("Index");
            }
        }
        [HttpPost]
        public IActionResult Update(Employee model)
        {
            Employee Emp = new Employee()
            {
                Id = model.Id,
                Name = model.Name,
                Age = model.Age,
                Salary = model.Salary,
                Address = model.Address,
                Gender = model.Gender

            };
            context.Employees.Update(Emp);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

      
    }
}
    

