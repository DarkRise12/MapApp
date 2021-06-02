using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapApp.MapFolder
{
    class InfoGet
    {
        public string kinds { get; set; }
        public Point point { get; set; }
        public string xid { get; set; }
        public string rate { get; set; }
        public string name { get; set; }
        public string wikidata { get; set; }
    }

    class ForPoint
    {
        public string name { get; set; }
        public string country { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
        public string population { get; set; }
        public string timezone { get; set; }
        public string status { get; set; }
    }
}
