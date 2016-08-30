using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LaunchDarkly.Client;

namespace CloudApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            LdClient ldClient = new LdClient("sdk-0020a10d-45cd-4be2-94fd-87d70780248f");

            User user = LaunchDarkly.Client.User.WithKey(User.Identity.Name);
            bool showFeature = ldClient.BoolVariation("new-home", user, false);
            if (showFeature)
            {
                // application code to show the feature 
                return View("NewHome");
            }
            else
            {
                // the code to run if the feature is off
                return View();
            }



            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page 3.";

            return View();
        }
    }
}