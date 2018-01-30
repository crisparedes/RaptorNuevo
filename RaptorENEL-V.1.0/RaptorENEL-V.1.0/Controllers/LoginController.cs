using RaptorENEL_V._1._0.DAL;
using RaptorENEL_V._1._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RaptorENEL_V._1._0.Controllers
{
    public class LoginController : Controller
    {
        private RaptorContext db = new RaptorContext();

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        /*// GET: Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }*/

        // POST: Login/Validate
        [HttpPost]
        public ActionResult index([Bind(Include = "username,password")] Login user)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    bool userExist = db.User.Any(x => x.username == user.username);
                    if (!userExist)
                    {
                        TempData["MsgErr"] = "El nombre de usuario o contraseña no son válidos";
                    }
                    else
                    {
                        User usr = db.User.Where(c => c.username == user.username).SingleOrDefault();
                        if (usr == null)
                        {
                            TempData["MsgErr"] = "El nombre de usuario o contraseña no son válidos";
                        }
                        else if (usr.password != user.password)
                        {
                            TempData["MsgErr"] = "El nombre de usuario o contraseña no son válidos";
                        }
                        else
                        {
                            return RedirectToAction("../User");
                        }
                    }
                    
                }
                user.password = "";
                return View(user);
            }
            catch
            {
                return View();
            }
        }

        /*// GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }*/

        // GET: Restore
        public ActionResult Restore()
        {
            return View();
        }

    }
}
