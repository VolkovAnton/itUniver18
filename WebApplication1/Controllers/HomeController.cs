using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        DocumentContext db = new DocumentContext();

        // метод ниже, должен был возвращать логин 
        //аутентифицированного пользователя, но возвращает только надпись-"Вы не авторизованы"
        // да и данные из бд не отображаются, SORЯN ¯\_(ツ)_/¯

        // public string Index()
        //{
        //    string result = "Вы не авторизованы";
        //    if (User.Identity.IsAuthenticated)
        //    {
        //        result = "Ваш логин: " + User.Identity.Name;
        //    }
        //    return result;
        //}

        public ActionResult Index()
        {
            return View(db.Documents);
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

    }
}