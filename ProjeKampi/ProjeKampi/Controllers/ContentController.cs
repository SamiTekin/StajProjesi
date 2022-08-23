using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjeKampi.Controllers
{
    
    public class ContentController : Controller
    {
        // GET: Content
        ContentMeneger cm = new ContentMeneger(new EfContentDal());

        public ActionResult Index()
        {
            return View();
        }
       

        public ActionResult GetAllContent(string p)
        {
           
            var values = cm.GetList(p);
       
          //  var values = c.Contacts.ToList();
            return View(values.ToList());
        }
        
        public ActionResult ContentByHeading(int id)
        {
            var contentvalues = cm.GetListByHeadingId(id);
            return View(contentvalues);
        }
    }
}