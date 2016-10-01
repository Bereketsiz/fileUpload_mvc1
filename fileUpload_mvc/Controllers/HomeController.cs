using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Objects.DataClasses;
using System.IO;

namespace fileUpload_mvc.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ResimEkle()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ResimEkle(HttpPostedFileBase resimDosyasi)
        {
         
                if (resimDosyasi.ContentLength > 0)
                {
                    var resimAdi = Path.GetFileName(resimDosyasi.FileName);
                    var resimYolu = Path.Combine(Server.MapPath("~/Content/Resimler"), resimAdi);
                    resimDosyasi.SaveAs(resimYolu);
                }
            


            return View();
        }

    }
}
