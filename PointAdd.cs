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
    public partial class PointAdd : Form
    {
        public string Name;
        public string Lat;
        public string Lng;
        public string Rate;
        public string Type;
        public PointAdd()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            if (string.IsNullOrEmpty(textbox.Text) || string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text))
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Name = textBox1.Text;
            Lat = textBox2.Text;
            Lng = textBox3.Text;
            Rate = textBox4.Text;
            Type = textBox5.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
