using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Net.NetworkInformation; //Include this

namespace Attendance.Controllers
{
    public class HomeController : Controller
    {
       [Authorize()]
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            Session["userip"] = HttpContext.Server;
           //=============================================

            string[] devs = {
                                
                     "192.168.1.43",
                     "192.168.1.44",
                     "192.168.1.45",
                     "192.168.1.68",
                     "192.168.1.69",
                     "192.168.1.70",
       
                            
                            
                            
                            
                            
                            };


            string[] devsnames = { 
                                 
            "FLOOR 2-->LEADERS",
            "FLOOR 8-->LEADERS",
            "FLOOR 8-->EMPLOYEES",
            "FLOOR 11-->EMPLOYEES",
            "FLOOR 11-->LEADERS",
            "FLOOR 2-->EMPLOYEES",
        
                                 
                                 
                                 };


            int i = 0;
            string[] success = new string[13];
            string[] failures = new string[13];
            foreach (var dev in devs.Zip(devsnames, Tuple.Create))
            {
                Ping myPing = new Ping();
                PingReply reply = myPing.Send(dev.Item1, 3000);
                if (reply.Status == IPStatus.Success)
                {
                    success[i] = dev.Item2;
                }
                else
                {
                    failures[i] = dev.Item2;
                }

                i = i + 1;
            }
            ViewBag.successful = success;
            ViewBag.failure = failures;







           //============================================
            return View();
        }
                        [Authorize()]
                public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }
                        [Authorize()]

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
