using CovidTracking.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Net;
using System.Collections.Specialized;

namespace CovidTracking.Service
{
    public class CovidTrackerService
    {
        public Object GetStatisticsData()
        {
            var uri = Util.getStatisticsUrl();
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    webClient.Headers.Add("X-Rapidapi-Key", "489d8d5129msh11d52d52e84ff0ep1509bcjsn18d2c3a4d897");
                    webClient.Headers.Add("X-Rapidapi-Host", "covid-193.p.rapidapi.com");
                    webClient.Headers.Add("Host", "covid-193.p.rapidapi.com");

                    var webContent = webClient.DownloadString(uri);
                    JObject get = JObject.Parse(webContent);
                    
                    IEnumerable<Object> myResul = (IEnumerable<Object>)JObject.Parse(webContent)["response"].ToObject<Object>();
                    return myResul;
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e);
                }

                return null;
            }
        }
       
        public Object GetStatisticsDataByCountry(string country)
        {
            var uri = Util.getStatisticsUrl();
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    webClient.Headers.Add("X-Rapidapi-Key", "489d8d5129msh11d52d52e84ff0ep1509bcjsn18d2c3a4d897");
                    webClient.Headers.Add("X-Rapidapi-Host", "covid-193.p.rapidapi.com");
                    webClient.Headers.Add("Host", "covid-193.p.rapidapi.com");

                    NameValueCollection myQueryStringCollection = new NameValueCollection();

                    myQueryStringCollection.Add("country", country);
                    webClient.QueryString = myQueryStringCollection;

                    var webContent = webClient.DownloadString(uri);
                    JObject get = JObject.Parse(webContent);

                    IEnumerable<Object> myResul = (IEnumerable<Object>)JObject.Parse(webContent)["response"].ToObject<Object>();
                    return myResul;
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e);
                }
                return null;
            }
        }

        public Object GetHistoryData(String country,String day)
        {
            var uri = Util.getHistoryUrl();
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    webClient.Headers.Add("X-Rapidapi-Key", "489d8d5129msh11d52d52e84ff0ep1509bcjsn18d2c3a4d897");
                    webClient.Headers.Add("X-Rapidapi-Host", "covid-193.p.rapidapi.com");
                    webClient.Headers.Add("Host", "covid-193.p.rapidapi.com");
                    webClient.Headers.Add("useQueryString", "true");

                    NameValueCollection myQueryStringCollection = new NameValueCollection();

                    myQueryStringCollection.Add("country", country);
                    myQueryStringCollection.Add("day", day);
                  

                    webClient.QueryString = myQueryStringCollection;

                    var webContent = webClient.DownloadString(uri);
                    JObject get = JObject.Parse(webContent);

                    IEnumerable<Object> myResul = (IEnumerable<Object>)JObject.Parse(webContent)["response"].ToObject<Object>();
                    return myResul;
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e);
                }

                return null;
            }
        }
    }
}