using RegistrationAndLogin.Models;
using RegistrationAndLogin.Models.Extended;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace RegistrationAndLogin.Controllers
{
  
    public class KategoriController : Controller
    {
        MyDatabaseEntities mvg = new MyDatabaseEntities();


        // GET: Kategori // bütün üyeler
        [HttpGet]
        public ActionResult Kategori()
        {
            List<User> kayitlars = mvg.Users.ToList();
            return View(kayitlars);
        }


        [HttpGet]
        public ActionResult KategoriOlustur()
        {

            return View();
        }

        [HttpPost]
        public JsonResult KategoriOlustur(string productname)
        {
                Kategori dbmodel = new Kategori();
                dbmodel.KategoriAdı = productname;
                mvg.Kategoris.Add(dbmodel);            
            
            
                 return Json(dbmodel);

            //return Json()
        }
    }
}