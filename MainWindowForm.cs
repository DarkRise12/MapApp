using MapApp.DBFolder;
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
    }
}
