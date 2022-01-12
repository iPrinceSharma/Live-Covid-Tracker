using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CovidTracking.Models
{
    public class CovidDetail
    {
        public string continent { get; set; }
        public string country { get; set; }
        public string population { get; set; }
        public Cases cases { get; set; }
        public Deaths deaths { get; set; }
        public String day { get; set; }
        public DateTime time { get; set; }
       
        public CovidDetail()
        {

        } 

    }
}