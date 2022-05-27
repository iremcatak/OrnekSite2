using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrnekSite2.Entity;

namespace OrnekSite2.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext();
        public PartialViewResult _FeaturedProductList()
        {
            return PartialView(db.Products.Where(i => i.IsApproved && i.IsFeatured).Take(5).ToList()); 
        }
        public PartialViewResult Slider()
        {
            return PartialView(db.Products.Where(i => i.IsApproved && i.Slider).Take(5).ToList());
        }
        public ActionResult Index()
        {
            return View(db.Products.Where(i=>i.IsHome&&i.IsApproved).ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult ProductDetails(int id)
        {
            return View(db.Products.Where(i=>i.Id==id).FirstOrDefault());
        }
        public ActionResult Product()
        {
            return View(db.Products.ToList() );
        }
        public ActionResult ProductList(int id)
        {
            return View(db.Products.Where(i=>i.CategoryId==id).ToList());
        }
    }
}