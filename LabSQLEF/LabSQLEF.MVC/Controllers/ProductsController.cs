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
    public class ProductsController : Controller
    {
        ProductLogic logic = new ProductLogic();
        // GET: Products
        public ActionResult Index()
        {
            List<LabSQLEF.Entities.Products> products = logic.GetAll();
            List<ProductsView> productsView = products.Select(p => new ProductsView
            {
                ID = p.ProductID,
                Name = p.ProductName,
                Price = p.UnitPrice,

            }).ToList();
            return View(productsView);
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(ProductsView view)
        {
            try
            {
                Products prod = new Products { ProductName = view.Name, UnitPrice = view.Price };
                logic.Add(prod);
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
            catch(Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult UpdateOrInsert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateOrInsert(ProductsView view)
        {
            if (view.ID != 0)
            {
                try
                {
                    if(logic.Find(view.ID) == null)
                    {
                        throw new InvalidOperationException();
                    }
                    Products prod = new Products { ProductID = view.ID, UnitPrice = view.Price };
                    logic.Update(prod);
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
                    Products prod = new Products { ProductName = view.Name, UnitPrice = view.Price };
                    logic.Add(prod);
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