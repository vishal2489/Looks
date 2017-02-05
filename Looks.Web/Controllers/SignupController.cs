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
        public ActionResult TestView() {
            var model = new FittingType();
            return View(model);
        }
        [HttpPost]
        public ActionResult Trouser(FittingType model) {
            return RedirectToAction("Wildness");
        }

        public ActionResult Wildness() {
            return View(new StyleInformation());
        }

        [HttpPost]
        public ActionResult Wildness(StyleInformation info) {
            return RedirectToAction("Budget");
        }
        public ActionResult Budget() {
            return View();
        }
        [HttpPost]
        public ActionResult Budget(Budget model) {
            return RedirectToAction("Brands");
        }
        public ActionResult Brands() {
            var brands = new List<Brand>();
            //test data
            brands.Add(new Brand() { Name = "Lee-Cooper", LogoURL = "../Content/Images/Signup/Brands/LEE-COOPER.jpg" });
            brands.Add(new Brand() { Name = "Lee", LogoURL = "../Content/Images/Signup/Brands/LEE.png" });
            brands.Add(new Brand() { Name = "Levis", LogoURL = "../Content/Images/Signup/Brands/LEVIS.png" });
            brands.Add(new Brand() { Name = "Louis-Philipee", LogoURL = "../Content/Images/Signup/Brands/LOUIS-PHILIPPE.png" });
            brands.Add(new Brand() { Name = "Peter-England", LogoURL = "../Content/Images/Signup/Brands/PETER-ENGLAND.png" });
            brands.Add(new Brand() { Name = "Spykar", LogoURL = "../Content/Images/Signup/Brands/SPYKAR.png" });
            return View(brands);
        }
        [HttpPost]
        public ActionResult Brands(List<Brand> brands) {
            return RedirectToAction("Email");
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