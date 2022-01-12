using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CovidTracking.Models
{
    public class Cases
    {
        public int @new {get;set;}
        public int active {get;set;}
        public int critical {get;set;}
        public int recovered {get;set;}
        public string oneM_pop {get;set;}
        public int total { get; set; }

        public Cases() { }
    }
}