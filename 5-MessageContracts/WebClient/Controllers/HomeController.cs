using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebClient.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            MyServicesRef.MyServicesClient client = new MyServicesRef.MyServicesClient("BasicHttpBinding_IMyServices");
            string Name = "Madhv";
            ViewBag.Result= client.GetEmployeeInfo(out Name);
            return View();
        }
    }
}