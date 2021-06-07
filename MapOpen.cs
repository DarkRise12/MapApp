using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using MapApp.MapFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapApp
{
    public partial class MapOpen : Form
    {
        List<string> lines = new List<string>();
        GMapOverlay mapOverlay = new GMapOverlay("markers");
        List<PointLatLng> points = new List<PointLatLng>();

        public MapOpen()
        {
            InitializeComponent();
        }

        private void MapOpen_Load(object sender, EventArgs e)
        {
            DialogResult result;
            string file;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                result = openFileDialog.ShowDialog();
                file = openFileDialog.FileName;
                using (StreamReader streamReader = new StreamReader(file))
                {
                    this.Text += file;
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                }
            }

            string[] latlng = lines[9].Split('|');
            double lat = Convert.ToDouble(latlng[0]);
            double lng = Convert.ToDouble(latlng[1]);


            gMapControl1.MaxZoom = 50;
            gMapControl1.MinZoom = 0;
            gMapControl1.Zoom = 17;
            gMapControl1.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gMapControl1.Position = new PointLatLng(lat, lng);


            for(int start_pos = 13; start_pos < lines.Count - 1;start_pos++)
            {
                DataGridViewRow row = new DataGridViewRow();
                string[] data = lines[start_pos].Split('/');
                dataGridView1.Rows.Add(data);
            }

            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                PointLatLng pll = new PointLatLng(Convert.ToDouble(row.Cells[2].Value), Convert.ToDouble(row.Cells[3].Value));
                points.Add(pll);
                GMarkerGoogle marker = new GMarkerGoogle(pll, GMarkerGoogleType.green);
                mapOverlay.Markers.Add(marker);
                gMapControl1.Overlays.Add(mapOverlay);
            }
        }
    }
}
