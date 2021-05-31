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
    public partial class WorkersDBForm : Form
    {
        public WorkersDBForm()
        {
            InitializeComponent();
            buttonFilter.Text += UserData.UserType;
            restartTable("all");
            if(UserData.UserType == "Менеджер")
            {
                buttonDelete.Hide();
                buttonAdd.Hide();
            }
        }

        public void restartTable(string filter)
        {
            string comm = "SELECT * FROM users";
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            if (filter != "all")
            {
                comm = "SELECT * FROM users WHERE `type` = @types";
            }
            MySqlCommand command = new MySqlCommand(comm, db.getCon());
            command.Parameters.AddWithValue("@types", UserData.UserType);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            table.Columns.Remove("pwd");
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = table;

            dataGridView1.DataSource = bindingSource;
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            restartTable("all");
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            restartTable(UserData.UserType);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            UserCreate userCreate = new UserCreate();
            userCreate.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                string comm = "DELETE FROM `users` WHERE `id` = @ids";
                MySqlCommand command = new MySqlCommand(comm, db.getCon());
                command.Parameters.AddWithValue("@ids", row.Cells[0].Value);
                db.openCon();
                command.ExecuteNonQuery();
                db.closeCon();
            }
        }
    }
}
