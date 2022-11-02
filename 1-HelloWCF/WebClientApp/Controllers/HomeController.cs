using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebClientApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            HelloServiceInWeb.HelloServiceClient client = new HelloServiceInWeb.HelloServiceClient("BasicHttpBinding_IHelloService"); // use http binding
            ViewBag.Msg= client.GetMessage("Madhv");
            return View();
        }
    }
}