using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_1_403.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Missions()
        {
            
            return View();
        }

        public ActionResult MissionFAQ(string mission, string display)
        {
            ViewBag.MissionCode = mission;
            ViewBag.MissionName = mission;
            //display = String.Format("{0}", Request.Form["display"]);
            ViewBag.MissionName = "";
            if (display == "none")
            {
                ViewBag.hide = "none";
            }
            else if (display == "reply")
            {
                ViewBag.hide = "normal";
            }
            if (mission == "Alabama")
            {
                ViewBag.MissionName = "Alabama Birmingham";
                ViewBag.MissionPresident = "President Stanford C. Sainsbury";  //Add an image
                ViewBag.MissionStreetAddress = "3100 Lorna Road, Suite 107";
                ViewBag.MissionRestofAddress = "Birmingham, AL 35216";
                ViewBag.MissionLanguage = "English";
                ViewBag.MissionClimate = "Hot and Humid"; //Could be an iframe showing weather.com
                ViewBag.MissionReligion = "Southern Baptist";
                ViewBag.MissionFlag = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5c/Flag_of_Alabama.svg/2000px-Flag_of_Alabama.svg.png";
                ViewBag.WeatherURL = "http://www.accuweather.com/en/us/birmingham-al/35203/weather-forecast/346630";
            }
            else if (mission == "Los Angeles")
            {
                ViewBag.MissionName = "California Los Angeles";
                ViewBag.MissionPresident = "President Robert M. Haynie";  //Add an image
                ViewBag.MissionStreetAddress = "1591 E. Temple Way";
                ViewBag.MissionRestofAddress = "Los Angeles, CA 90024";
                ViewBag.MissionLanguage = "English";
                ViewBag.MissionClimate = "Sunny and between 50-70 year round"; //Could be an iframe showing weather.com
                ViewBag.MissionReligion = "Catholic";
                ViewBag.MissionFlag = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/01/Flag_of_California.svg/2000px-Flag_of_California.svg.png";
            }
            else if (mission == "Tallahassee")
            {
                ViewBag.MissionName = "Florida Tallahassee";
                ViewBag.MissionPresident = "President Clint W. Smith";  //Add an image
                ViewBag.MissionStreetAddress = "1535 Killearn Center Blvd Suite C-3";
                ViewBag.MissionRestofAddress = "Tallahassee, FL 32309";
                ViewBag.MissionLanguage = "English";
                ViewBag.MissionClimate = "Hot and Humid"; //Could be an iframe showing weather.com
                ViewBag.MissionReligion = "Christian";
                ViewBag.MissionFlag = "http://www.usa4kids.com/images/bigflags/florida.gif";
            }

            return View();
        }

        public ActionResult About(string name)
        {
            name = "YOUR NAME HERE";
            ViewBag.MissionaryName = name;
            name = String.Format("{0}", Request.Form["name"]);

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}