using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClinetApp.MyService;

namespace ClinetApp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            MyServiceClient client = new MyServiceClient();
            ViewBag.Welcome = client.Welcome();
            return View();
        }
        [HttpPost]
        public ActionResult Index(string name)
        {
            MyServiceClient client = new MyServiceClient();
            ViewBag.Name = client.MyName(name);
            ViewBag.Welcome = client.Welcome();
            return View();
        }

    }
}
