using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using MapApp.MapFolder;

namespace MapApp
{
    public partial class Map : Form
    {
        List<PointLatLng> points = new List<PointLatLng>();
        public Map()
        {
            InitializeComponent();
        }

        private void Map_Load(object sender, EventArgs e)
        {
            gMapControl1.MaxZoom = 50;
            gMapControl1.MinZoom = 0;
            gMapControl1.Zoom = 17;
            gMapControl1.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gMapControl1.Position = MapInfo.CityPoint;

            string inf = ApiGet.GetPlaceApi(MapInfo.Radius.ToString(), MapInfo.CityPoint.Lng.ToString().Replace(",","."), MapInfo.CityPoint.Lat.ToString().Replace(",", ".")).ToString();
            string[] rtb = inf.Split('\n');
            
            if (rtb.Length < MapInfo.Amount)
                MapInfo.Amount = rtb.Length;
            for(int i = 0; i < MapInfo.Amount;i++)
            {
                string[] ord = rtb[i].Split('|');
                dataGridView1.Rows.Add(ord);
            }

            foreach (DataGridViewRow i in dataGridView1.Rows)
            {
                PointLatLng pll = new PointLatLng(Convert.ToDouble(i.Cells[1].Value), Convert.ToDouble(i.Cells[2].Value));
                points.Add(pll);
                GMapOverlay mapOverlay = new GMapOverlay("markers");
                GMarkerGoogle marker = new GMarkerGoogle(pll, GMarkerGoogleType.green);
                mapOverlay.Markers.Add(marker);
                gMapControl1.Overlays.Add(mapOverlay);
            }
        }
    }
}
