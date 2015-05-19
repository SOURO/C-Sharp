using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class TestController : Controller
    {
        [NonAction]
        public string GetMessage()
        {
            return "I am learning C#, beleive me it is fun";
        }
        public ActionResult GetView()
        {
            return View("SampleView");

        }
    }
}
