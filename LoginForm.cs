using MapApp.DBFolder;
using MySql.Data.MySqlClient;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            loginInfo.Hide();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string loginUser = pwdBox.Text;
            string pwdUser = loginBox.Text;
            string type = string.Empty;
            string name = string.Empty;

            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE `login` = @lU AND `pwd` = @pU", db.getCon());
            command.Parameters.AddWithValue("@lU", loginUser);
            command.Parameters.AddWithValue("@pU", pwdUser);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count == 1)
            {
                loginInfo.Hide();
                this.Hide();
                UserData.UserType = table.Rows[0].Field<string>(3);
                UserData.UserName = table.Rows[0].Field<string>(4);
                MainWindowForm mainWindowForm = new MainWindowForm();
                mainWindowForm.Show();
            }
            else
            {
                loginInfo.Show();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }
    }
}
