using MapApp.DBFolder;
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

namespace MapApp
{
    public partial class MainWindowForm : Form
    {
        string Name = string.Empty;
        string Type = string.Empty;
        public MainWindowForm()
        {
            InitializeComponent();
            labelType.Text = Type = UserData.UserType;
            labelName.Text = Name = UserData.UserName;

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm loginForm = new MainForm();
            loginForm.Show();
        }

        private void buttonUserCreate_Click(object sender, EventArgs e)
        {
            UserCreate userCreate = new UserCreate();
            userCreate.Show();
        }

        private void buttonDBWorkers_Click(object sender, EventArgs e)
        {
            WorkersDBForm workersDBForm = new WorkersDBForm();
            workersDBForm.Show();
        }

        private void buttonMap_Click(object sender, EventArgs e)
        {
            GMap.NET.PointLatLng pointNull = new GMap.NET.PointLatLng(double.NaN, double.NaN);
            MapInfo.City = null;
            MapInfo.CityPoint = pointNull;
            MapInfo.Contact = null;
            MapInfo.FileName = null;
            MapInfo.Radius = 0;
            MapInfo.Amount = 0;
            MapInfo.Name = null;

            MapInitForm mapInitForm = new MapInitForm();
            mapInitForm.Show();
        }

        private void buttonDBClient_Click(object sender, EventArgs e)
        {

        }
    }
}
