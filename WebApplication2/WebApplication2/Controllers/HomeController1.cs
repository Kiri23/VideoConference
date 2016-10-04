using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using clickMeetingStandalone.Models;


namespace clickMeetingStandalone.Controllers
{
    
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            var api = new api();
            api.getConference("active");
            return View(api);
        }

        

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }



    }
}