using LabSQLEF.Logic;
using LabSQLEF.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabSQLEF.MVC.Controllers
{
    public class ApiPublicController : Controller
    {
        // GET: ApiPublic
        ApiPublicaLogic logic = new ApiPublicaLogic();

        public ActionResult Index()
        {
            try
            {

                ApiView view = new ApiView();
                view.content = logic.GetItem();

                return View(view);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }
        }
    }
}