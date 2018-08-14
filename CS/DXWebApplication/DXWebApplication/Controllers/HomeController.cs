using DevExpress.Web;
using DevExpress.Web.Mvc;
using DXWebApplication;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace DXWebApplication {
    [ValidateInput(false)]
    public class HomeController : Controller {
        public string Name { get { return "Common"; } }

        public ActionResult Index() {
            return RedirectToAction("ModelValidation");
        }
        public ActionResult jQueryValidation() {
            return View("jQueryValidation", new JQueryValidationData());
        }
        [HttpPost]
        public ActionResult jQueryValidation(JQueryValidationData validationData) {
            if(Request.Params["btnUpdate"] == null) {
                ModelState.Clear();
                return View("jQueryValidation", validationData);
            }

            if(ModelState.IsValid) {
                return View("_ValidationSuccess");
            }
            return View("jQueryValidation", validationData);
        }
        public JsonResult CheckReleaseDate(DateTime? ReleaseDate) {
            return Json(ReleaseDate != null && ReleaseDate >= DateTime.Today, JsonRequestBehavior.AllowGet);
        }
    }

    
}