using LabSQLEF.Entities;
using LabSQLEF.Logic;
using LabSQLEF.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabSQLEF.MVC.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        EmployeeLogic logic = new EmployeeLogic();
        public ActionResult Index()
        {
            List<LabSQLEF.Entities.Employees> employees = logic.GetAll();
            List<EmployeesView> empView = employees.Select(e => new EmployeesView
            {
                ID = e.EmployeeID,
                Name = e.FirstName,
                LastName = e.LastName,
                City = e.City,
                Country = e.Country

            }).ToList();
            return View(empView);
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(EmployeesView view)
        {
            try
            {
                Employees emp = new Employees { FirstName = view.Name, LastName= view.LastName, City = view.City, Country= view.Country};
                logic.Add(emp);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult Delete(int id)
        {
            try
            {
                logic.Delete(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult UpdateOrInsert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateOrInsert(EmployeesView view)
        {
            if(view.ID != 0)
            {

                try
                {
                    if (logic.Find(view.ID) == null)
                    {
                        throw new InvalidOperationException();
                    }
                    Employees emp = new Employees { EmployeeID = view.ID, FirstName = view.Name, LastName = view.LastName, Country = view.Country, City = view.City };
                    logic.Update(emp);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    return RedirectToAction("Index", "Error");
                }
            }
            else
            {
                try
                {
                    Employees emp = new Employees { FirstName = view.Name, LastName = view.LastName, City = view.City, Country = view.Country };
                    logic.Add(emp);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {

                    return RedirectToAction("Index", "Error");
                }
            }
        }
    }
}