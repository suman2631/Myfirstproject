using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Myfirstproject.Controllers
{
    public class productController : Controller
    {
        // GET: product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult addproduct(productdetail pdetail)
        {
            var pname = pdetail.productname;
            return View("index");
        }

    }
    public class productdetail
    {
        public HttpPostedFileBase pimage { get; set; }
        public string productname { get; set; }
        public string price { get; set; }
        public string description { get; set; }
        
        
    }
}