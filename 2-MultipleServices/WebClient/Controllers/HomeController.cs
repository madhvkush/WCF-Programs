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
            CompServiceInWeb.CompanyPublicServiceClient client = new CompServiceInWeb.CompanyPublicServiceClient("BasicHttpBinding_ICompanyPublicService");
           ViewBag.Public=  client.GetPublicInformation(); // confidential information is not accessible  

            CompServiceInWeb.CompanyConfidentialServiceClient client2 = new CompServiceInWeb.CompanyConfidentialServiceClient("NetTcpBinding_ICompanyConfidentialService");
            ViewBag.Private = client2.GetConfidentialInformation();
            return View();
        }
    }
}