using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HtmlHelperExample.Models;

namespace HtmlHelperExample.Controllers
{
    public class TestController : Controller
    {
        public ActionResult Index(bool isValid = false)
        {
            var model = new TestModel 
            { 
                IsValid = isValid,
                Value = isValid ? "I am valid" : "I am invalid.  Please correct me"
            };

            return View(model);
        }
    }
}
