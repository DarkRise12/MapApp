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
    public partial class ClientsDBForm : Form
    {
        public ClientsDBForm()
        {
            InitializeComponent();

            string comm = "SELECT * FROM clients";
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            if(UserData.UserType == "Менеджер")
            {
                comm = "SELECT * FROM clients WHERE `empl_name` = @names";
                MySqlCommand command = new MySqlCommand(comm, db.getCon());
                command.Parameters.AddWithValue("@names", UserData.UserName);
                adapter.SelectCommand = command;
            }    
            else
            {
                comm = "SELECT * FROM clients";
                MySqlCommand command = new MySqlCommand(comm, db.getCon());
                adapter.SelectCommand = command;
            }
            
            adapter.Fill(table);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = table;

            dataGridView1.DataSource = bindingSource;
        }


    }
}
