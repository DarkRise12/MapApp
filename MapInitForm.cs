using MapApp.MapFolder;
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

namespace MapApp
{
    public partial class MapInitForm : Form
    {
        GMapOverlay mapOverlay = new GMapOverlay("markers");
        public MapInitForm()
        {
            InitializeComponent();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            gMapControl1.MaxZoom = 50;
            gMapControl1.MinZoom = 0;
            gMapControl1.Zoom = 15;
            gMapControl1.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            //gMapControl1.Position = new PointLatLng(54.9860956, 82.9050593);
        }

        private void cityBox1_TextChanged(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            if(string.IsNullOrEmpty(textbox.Text))
            {
                next1.Enabled = false;
            }
            else
            {
                next1.Enabled = true;
            }
        }

        private void next1_Click(object sender, EventArgs e)
        {
            MapInfo.City = cityBox1.Text;
            MapInfo.CityPoint = ApiGet.GetCityPoint(MapInfo.City);
            gMapControl1.Position = MapInfo.CityPoint;
            GMarkerGoogle marker = new GMarkerGoogle(MapInfo.CityPoint, GMarkerGoogleType.green);
            mapOverlay.Markers.Add(marker);
            gMapControl1.Overlays.Add(mapOverlay);
            tabControl1.SelectedTab = tabPage2;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                next2.Enabled = true;
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
            }
                
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void back2_Click(object sender, EventArgs e)
        {
            gMapControl1.Overlays.Clear();
            tabControl1.SelectedTab = tabPage1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                next2.Enabled = false;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            if (string.IsNullOrEmpty(textbox.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                next2.Enabled = false;
            }
            else
            {
                next2.Enabled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            if (string.IsNullOrEmpty(textbox.Text) || string.IsNullOrEmpty(textBox1.Text))
            {
                next2.Enabled = false;
            }
            else
            {
                next2.Enabled = true;
            }
        }

        private void next2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                MapInfo.CityPoint = new PointLatLng(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            tabControl1.SelectedTab = tabPage3;
        }

        private void back3_Click(object sender, EventArgs e)
        {
            amountUpDown1.Value = 1;
            radiusUpDown2.Value = 1000;
            tabControl1.SelectedTab = tabPage2;
        }

        private void next3_Click(object sender, EventArgs e)
        {
            MapInfo.Radius = Convert.ToInt32(radiusUpDown2.Value);
            MapInfo.Amount = Convert.ToInt32(amountUpDown1.Value);
            tabControl1.SelectedTab = tabPage4;
        }

        private void back4_Click(object sender, EventArgs e)
        {
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            tabControl1.SelectedTab = tabPage3;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            if (string.IsNullOrEmpty(textbox.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text))
            {
                makemapButton.Enabled = false;
            }
            else
            {
                makemapButton.Enabled = true;
            }
        }

        private void makemapButton_Click(object sender, EventArgs e)
        {
            MapInfo.Name = textBox3.Text;
            MapInfo.Contact = textBox4.Text;
            Map map = new Map();
            map.Show();
            this.Close();
        }
    }
}
