using ProjeKampi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjeKampi.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult CategoryChart()
        {
            return Json(BlogList(),JsonRequestBehavior.AllowGet);
        }

        public List<CategoryClass> BlogList()
        {
            List<CategoryClass> ct = new List<CategoryClass>();
            ct.Add(new CategoryClass()
            {
                CategoryName = "Yazılım",
                CategoryCount = 15
            });
            ct.Add(new CategoryClass()
            {
                CategoryName="Kodlama",
                CategoryCount=8
            });
            ct.Add(new CategoryClass()
            {
                CategoryName = "Yemek",
                CategoryCount = 5
            });
            return ct;
        }
    }
}