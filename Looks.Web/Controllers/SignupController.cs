using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Looks.Web.Controllers {
    public class SignupController: Controller {
        // GET: Signup
        public ActionResult Introduction() {
            return View();
        }

        public ActionResult Trouser() {
            return View();
        }

        public ActionResult Wildness() {
            return View();
        }
    }
}