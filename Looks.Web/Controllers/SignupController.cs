using System.Collections.Generic;
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
            return RedirectToAction("Weekend");
        }

        public ActionResult Email() {
            return View();
        }
        public ActionResult SelfPortrait() {
            return View();
        }
        public ActionResult Weekend() {
            var weekendStyle = new List<Style>();
            for (int i = 1; i < 45; i++) {
                weekendStyle.Add(new Style() {
                    Description = i.ToString(),
                    ImageUrl = $"../Content/Images/Signup/Stlyes/{i.ToString()}.jpeg"
                });
            }
            return View(weekendStyle);
        }
        [HttpPost]
        public ActionResult Weekend(List<Style> styles) {
           return RedirectToAction("Work");
        }
        public ActionResult Work() {
            var workStyle = new List<Style>();
            for (int i = 101; i <= 145; i++) {
                workStyle.Add(new Style() {
                    Description = i.ToString(),
                    ImageUrl = $"../Content/Images/Signup/Stlyes/{i.ToString()}.jpeg"
                });
            }
            return View(workStyle);
        }
        [HttpPost]
        public ActionResult Work(List<Style> styles) {
            return RedirectToAction("Date");
        }
        public ActionResult Date() {
            var dateStyle = new List<Style>();
            for (int i = 201; i <= 245; i++) {
                dateStyle.Add(new Style() {
                    Description = i.ToString(),
                    ImageUrl = $"../Content/Images/Signup/Stlyes/{i.ToString()}.jpeg"
                });
            }
            return View(dateStyle);
        }
        [HttpPost]
        public ActionResult Date(List<Style> styles) {
            return RedirectToAction("Sizes");
        }
        public ActionResult Sizes() {
            
            ViewBag.WaistSizes = GetWaistSizes();
            ViewBag.ShoesSizes = GetShoesSizes();
            ViewBag.JacketSizes = GetJacketSizes();
            return View(new FittingInformation());
        }
      
        [HttpPost]
        public ActionResult Sizes(FittingInformation fittingInfo) {
            return RedirectToAction("Appearance");
        }
        //public ActionResult Wanted() {
        //    return View();
        //}
        //public ActionResult Owned() {
        //    return View();
        //}
        //public ActionResult Appearance() {
        //    return View();
        //}
        private IEnumerable<SelectListItem> GetWaistSizes() {
            var list = new List<SelectListItem>();
            list.Add(new SelectListItem() { Value = "0", Text = "Don't Know" });
            for(int i = 26; i <= 40; i++) {
                list.Add(new SelectListItem() { Value = i.ToString(), Text = i.ToString() });
            }
            return list;
        }
        private IEnumerable<SelectListItem> GetShoesSizes() {
            var list = new List<SelectListItem>();
            list.Add(new SelectListItem() { Value = "0", Text = "Don't Know" });
            for(int i = 6; i <= 12; i++) {
                list.Add(new SelectListItem() { Value = i.ToString(), Text = $"UK-{i.ToString()}" });
            }
            return list;
        }
        private IEnumerable<SelectListItem> GetJacketSizes() {
            var list = new List<SelectListItem>();
            list.Add(new SelectListItem() { Value = "0", Text = "Don't Know" });
            for(int i = 32; i <= 46; i = i + 2) {
                list.Add(new SelectListItem() { Value = i.ToString(), Text = i.ToString() });
            }
            return list;
        }
    }
}
