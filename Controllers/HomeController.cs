using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult BannerTypeList()
        {
            var bannerType = BannerType.GetBannerType();

            if (HttpContext.Request.IsAjaxRequest())
            {
                return Json(new SelectList(bannerType.ToArray(), "BannerCode", "BannerName"), JsonRequestBehavior.AllowGet);
            }

            return RedirectToAction("Index");
        }
        public ActionResult CategoryList(string ID)
        {
            var categories = from c in Category.GetCategories()
                             where c.BannerCode == ID
                             select c;
            if (HttpContext.Request.IsAjaxRequest())
            {
                return Json(new SelectList(categories.ToArray(), "CategoryID", "CategoryName"),
                    JsonRequestBehavior.AllowGet);
            }

            return RedirectToAction("Index");
        }

        public PartialViewResult GetBanner(string category)
        {
            var banners = (from l in Banner.GetBanner()
                           where l.Category == category
                           select l).AsEnumerable();
            return PartialView(banners);
        }
    }
}