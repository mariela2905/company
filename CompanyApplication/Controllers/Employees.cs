using System.Linq;
using CompanyApplication.Models;
using Microsoft.AspNetCore.Mvc;
namespace CompanyApplication
{
    public class EmployeesController : Controller
    {
        MyDbContext db = new MyDbContext();
        public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateEmployee(Employees employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
            return RedirectToAction("Index", "Employees");
        }
        [HttpPost]
        public bool Delete(int id)
        {
            try
            {
                db.Employees.Remove(employee);
                Employees employee= db.Employees.Where(s => s.Id == id).First();
                db.Employees.Remove(employee);
                db.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }

        }
        public ActionResult Update(int id)
        {
            return View(db.Employees.Where(s => s.Id == id).First());
        }
        [HttpPost]
        public ActionResult UpdateEmployees(Employees employee)
        {
            Employees e = db.Employees.Where(s => s.Id == employee.Id).First();
            e.Name = employee.Name;
            e.Password = employee.Password;
            e.Phone = employee.Phone;
            e.Position = employee.Position;
            e.Email = employee.Email;

            db.SaveChanges();
            return RedirectToAction("Index", "Employees");
        }
    }
}