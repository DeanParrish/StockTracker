using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockTracker.Helpers.Objects
{
    public class Bond
    {
        public string Ticker { get; set; }
        public string Name { get; set; }
        public string Exchange { get; set; }
        public string Country { get; set; }
    }
}