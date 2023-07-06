using Product.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Product.Controllers
{
    public class HomeController : Controller
    {
        

        // GET: Home
        public ActionResult Index()
        {
            ProductSerivice db = new ProductSerivice();
            //List<DeltawareProduct> obj = db.GetProduct();
            var row = db.GetProduct();
            
            return View(row);
        }
    }
}