using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2;
using WebApplication2.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string cpassword;
            string clogin;
            // if cookies absent
            //      redirect to login
            var cook = Request.Cookies["cr"];
            if (cook == null)
                return RedirectToAction("LogIn");

            clogin = cook["Login"];
            cpassword = cook["Password"];


            ViewBag.Login = cook["Login"];
            // if cookie is here, then validate cookie info, set name of user to ViewBag
            
            return View();
        }

        public ActionResult Exam()
        {
            ViewBag.Message = "Описание приложеньки.";

            return PartialView();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Описание приложеньки.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Да, это наша контактная страница.";

            return View();
        }


        public ActionResult Secret()
        {
            ViewBag.Message = "Секрет...";

            return View();
        }

        [HttpGet]
        public ActionResult SignIn()
        {
            ViewBag.Message = "Страница регистрации";

            return View(new UserViewModel());
        }

        [HttpPost]
        public ActionResult SignIn(UserViewModel user)
        {
            if (ModelState.IsValid)
            {
                // TODO: call db to add user.

                //HttpCookie cookie = new HttpCookie("cc");
                //cookie["Name"] = user.Name;
                //cookie["Password"] = user.Password;
                //cookie["Login"] = user.Login;
                //cookie["Age"] = Convert.ToString(user.Age);

                //cookie.Expires = DateTime.Now.AddMinutes(10);
                //Response.Cookies.Add(cookie);

                return RedirectToAction("RegistrationGood", new { name = user.Name });
            }
            return View(user);
        }
        public ActionResult RegistrationGood(string name)
        {
            if (name == null)
                return RedirectToAction("Registration");

            ViewBag.Login = name;
            return View();
        }
        [HttpGet]
        public ActionResult LogIn()
        {
            ViewBag.Message = "Страница Входа";

            return View(new LogInViewModel());
        }

        [HttpPost]
        public ActionResult LogIn(LogInViewModel user)
        {
            if (ModelState.IsValid)
            {
                    foreach (User dbuser in DBexample.Users)
                {
                    if (dbuser.login == user.Login & dbuser.password == user.Password)
                    {
                        HttpCookie cookie = new HttpCookie("cr");
                        cookie["Password"] = user.Password;
                        cookie["Login"] = user.Login;

                        cookie.Expires = DateTime.Now.AddMinutes(10);
                        Response.Cookies.Add(cookie);
                        return RedirectToAction("LoginSucceed");
                    }
                } 
            }
            return View(user);
        }

        public ActionResult LoginSucceed()
        {
            var cook = Request.Cookies["cr"];
            if (cook == null)
                return RedirectToAction("SignIn");

            ViewBag.Login = cook["Login"];
            return View();
        }
        public ActionResult Goodies()
        {
            List<Goodie> goodies = new List<Goodie>();
            return View(goodies);
        }
    }
}