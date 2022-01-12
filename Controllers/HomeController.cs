using CovidTracking.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace CovidTracking.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Home()
        {
            return View("Home");
        }

        public ActionResult Index()
        {
            var covidService = new CovidTrackerService();
            var myResult = covidService.GetStatisticsData();
            ViewBag.result = myResult;
            return View("Index");
        }

        public ActionResult GetHistroyData()
        {
            var covidService = new CovidTrackerService();

            // Default Params
            var country = "India";
            var date = "2020-12-24";

            var myResult = covidService.GetHistoryData(country, date);
            ViewBag.historyResult = myResult;
            return View("History");
        }


        public ActionResult GetHistroyDataCountryWise(String country,String date)
        {
            var covidService = new CovidTrackerService();
            var myResult = covidService.GetHistoryData(country,date);

            ViewBag.historyResult = myResult;
            return View("History",ViewBag.historyResult);
        }

        public ActionResult MapView()
        {
            return View("Map");
        }

    }
}