using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Looks.Models;

namespace Looks.Web.Controllers {
    public class SignupController: Controller {
        // GET: Signup
        public ActionResult Introduction() {
            return View();
        }

        public ActionResult Trouser() {
            var model = new FittingType();
            return View(model);
        }
        [HttpPost]
        public ActionResult Trouser(FittingType model) {
            return RedirectToAction("Wildness");
        }

        public ActionResult Wildness() {
            return View();
        }

        public ActionResult Budget() {
            return View();
        }
        public ActionResult Brands() {
            return View();
        }
        public ActionResult Email() {
            return View();
        }
        public ActionResult SelfPortrait() {
            return View();
        }
        public ActionResult Weekend() {
            return View();
        }
        public ActionResult Work() {
            return View();
        }
        public ActionResult Date() {
            return View();
        }
        public ActionResult Sizes() {
            return View();
        }
        public ActionResult Wanted() {
            return View();
        }
        public ActionResult Owned() {
            return View();
        }
        public ActionResult Appearance() {
            return View();
        }

    }
}