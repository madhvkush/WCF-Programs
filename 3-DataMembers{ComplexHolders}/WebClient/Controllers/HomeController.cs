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
            MyServiceInWeb.MyServiceClient client = new MyServiceInWeb.MyServiceClient("BasicHttpBinding_IMyService");
            //GetDataUsingDataContract method return a complex object holder
            ViewBag.PInfo = client.GetDataUsingDataContract(new MyServiceInWeb.ComplexInfoHolder { Name="Madhv",Email="mk@email.com"
                //NotSerialized this porperty is not showing here beacuse it is not decorated by [DataMember]
            });

            return View();
        }
    }
}