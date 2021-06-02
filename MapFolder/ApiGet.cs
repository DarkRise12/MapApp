using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;

namespace MapApp.MapFolder
{
    class ApiGet
    {
        public static string GetPlaceApi(string radius, string lon, string lat)
        {
            WebRequest req = WebRequest.Create("https://api.opentripmap.com/0.1/ru/places/radius?radius=" + radius +
                 "&lon=" + lon +
                 "&lat=" + lat +
                 "&rate=3&format=json&apikey=5ae2e3f221c38a28845f05b6a0fdc2afdb9324ebdcfd90f743f1a6bf");
            WebResponse resp = req.GetResponse();
            Stream stream = resp.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            string respStr = reader.ReadToEnd();
            string s = "";
            if (respStr != null)
            {
                List<InfoGet> info = JsonConvert.DeserializeObject<List<InfoGet>>(respStr);
                foreach (var i in info)
                {
                    s += i.name + "|" + i.point.lat + "|" + i.point.lon + "|" + i.rate + "|" + i.kinds + "|" + "\n";

                }
            }

            return s;
        }

        public static GMap.NET.PointLatLng GetCityPoint(string city)
        {
            WebRequest req = WebRequest.Create("https://api.opentripmap.com/0.1/ru/places/geoname?name=" + city +
                "&apikey=5ae2e3f221c38a28845f05b6a0fdc2afdb9324ebdcfd90f743f1a6bf");
            WebResponse resp = req.GetResponse();
            Stream stream = resp.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            string respStr = reader.ReadToEnd();
            GMap.NET.PointLatLng point = new GMap.NET.PointLatLng(double.NaN, double.NaN);
            if (respStr != null)
            {
                //List<ForPoint> info = JsonConvert.DeserializeObject<List<ForPoint>>(respStr);
                ForPoint forPoint = JsonConvert.DeserializeObject<ForPoint>(respStr);
                point = new GMap.NET.PointLatLng(forPoint.lat, forPoint.lon);
            }

            return point;
        }

    }
}
