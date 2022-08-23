using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjeKampi.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        HeadingMeneger hm = new HeadingMeneger(new EfHeadingDal());
        ContentMeneger cm = new ContentMeneger(new EfContentDal());
        // GET: Default
        public ActionResult Headings() 
        {
            var headinglist=hm.GetList();
            return View(headinglist); 
        }

        public PartialViewResult Index(int id=0)
        {
            var contentlist =cm.GetListByHeadingId(id);
            return PartialView(contentlist);
        }
    }
}