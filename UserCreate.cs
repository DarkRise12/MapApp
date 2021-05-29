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
    public partial class UserCreate : Form
    {
        public UserCreate()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "Введите логин" || string.IsNullOrEmpty(textBoxLogin.Text))
            {
                label5.Text = "Неправильный логин";
                return;
            }
            if (string.IsNullOrEmpty(textBoxPwd.Text))
            {
                label5.Text = "Неправильный пароль";
                return;
            }
            if (textBoxName.Text == "Введите имя" || string.IsNullOrEmpty(textBoxName.Text))
            {
                label5.Text = "Неправильное имя";
                return;
            }

            if (isUserExist())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users`(`login`, `pwd`, `type`, `name`) VALUES (@login, @pwd, @type, @name)", db.getCon());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = textBoxLogin.Text;
            command.Parameters.Add("@pwd", MySqlDbType.VarChar).Value = textBoxPwd.Text;
            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = comboBoxType.SelectedItem;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBoxName.Text;

            db.openCon();

            if (command.ExecuteNonQuery() == 1)
            {
                label5.Text = "";
                this.Close();
            }
            else
                label5.Text = "Возникла ошибка при создании пользователя";

            db.closeCon();
        }

        public bool isUserExist()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE `login` = @lU", db.getCon());
            command.Parameters.AddWithValue("@lU", textBoxLogin.Text);

            adapter.SelectCommand = command;
            adapter.Fill(table);


            if (table.Rows.Count > 0)
            {
                label5.Text = "Логин занят";
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
