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
            MyServiceLib.MyServiceClient client = new MyServiceLib.MyServiceClient("BasicHttpBinding_IMyService");
            ViewBag.employee= client.GetPerson(new MyServiceLib.Employee { Name = "Madhv", EmpCode = "007" });// base class can hold derived class instance

            return View();
        }
    }
}