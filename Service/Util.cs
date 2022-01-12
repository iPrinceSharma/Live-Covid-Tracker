using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CovidTracking.Service
{
    public class Util
    {
        public static string getRootUri()
        {
            var uri = "http://localhost:7734/";
            return uri;
        }

        public static string getServiceUri(string srv)
        {
            return getRootUri() + "api/" + srv;
        }

        public static String getStatisticsUrl ()
        {
            return "https://covid-193.p.rapidapi.com/statistics";
        }

        public static String getHistoryUrl()
        {
            return "https://covid-193.p.rapidapi.com/history";
        }
    }
}

