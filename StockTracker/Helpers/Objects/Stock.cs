using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace StockTracker.Helpers.Objects
{
    public class Stock
    {
        public string Ticker { get; set; }
        public string Name { get; set; }
        public string Exchange { get; set; }
        public string Country { get; set; }
        public string Category_Name { get; set; }
        public int Category_Number { get; set; }
    }
}