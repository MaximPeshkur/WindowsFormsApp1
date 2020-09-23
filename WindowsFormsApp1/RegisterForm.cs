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

namespace WindowsFormsApp1
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            this.PassField.AutoSize = false;
            this.PassField.Size = new Size(this.PassField.Size.Width, 60);
            UserNameField.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))) ;
            UserNameField.Text = "Введите Имя";
            UserNameField.ForeColor = Color.Gray;
            UserSurnameField.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            UserSurnameField.Text = "Введите Фамилию";
            UserSurnameField.ForeColor = Color.Gray;
            LoginField.Text = "Логин";
            LoginField.ForeColor = Color.Gray;
            PassField.Text = "Пароль";
            PassField.ForeColor = Color.Gray;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseButton_MouseMove(object sender, MouseEventArgs e)
        {
            CloseButton.BackColor = Color.Red;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.BackColor = Color.Black;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
           {
               this.Left += e.X - lastPoint.X;
               this.Top += e.Y - lastPoint.Y;
           }
        }

        Point lastPoint;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void UserNameField_Enter(object sender, EventArgs e)
        {

            if (UserNameField.Text == "Введите Имя")
            {
                UserNameField.Text = "";
                UserNameField.ForeColor = Color.Black;
            }
        }

        private void UserNameField_Leave(object sender, EventArgs e)
        {
            if (UserNameField.Text == "")
            {
                UserNameField.Text = "Введите Имя";
                UserNameField.ForeColor = Color.Red;
            }
        }

        private void UserSurnameField_Enter(object sender, EventArgs e)
        {
            if (UserSurnameField.Text == "Введите Фамилию")
            {
                UserSurnameField.Text = "";
                UserSurnameField.ForeColor = Color.Black;
            }
        }

        private void UserSurnameField_Leave(object sender, EventArgs e)
        {
            if (UserSurnameField.Text == "")
            {
                UserSurnameField.Text = "Введите Фамилию";
                UserSurnameField.ForeColor = Color.Red;
            }
        }

        private void LoginField_Enter(object sender, EventArgs e)
        {
            if (LoginField.Text == "Логин")
            {
                LoginField.Text = "";
                LoginField.ForeColor = Color.Black;
            }
        }

        private void LoginField_Leave(object sender, EventArgs e)
        {
            if (LoginField.Text == "")
            {
                LoginField.Text = "Логин";
                LoginField.ForeColor = Color.Red;
            }
        }

        private void PassField_Enter(object sender, EventArgs e)
        {
            if (LoginField.Text != "")
            {
                PassField.Text = "";
                PassField.ForeColor = Color.Black;
            }
        }

        private void PassField_Leave(object sender, EventArgs e)
        {
            if (PassField.Text == "")
            {
                PassField.Text = "Пароль";
                PassField.ForeColor = Color.Red;
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (UserNameField.Text == "Введите Имя")
            {
                MessageBox.Show("Введите имя");
                return;
            }

            if (UserSurnameField.Text == "Введите Фамилию")
            {
                MessageBox.Show("Введите Фамилию");
                return;
            }

            if (LoginField.Text == "Логин")
            {
                MessageBox.Show("Введите логин");
                return;
            }

            if (PassField.Text == "Пароль")
            {
                MessageBox.Show("Введите Пароль");
                return;
            }

            if (isUserExists())
                return;

            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `Name`, `Surname`) VALUES (@login, @password, @name, @surname)", db.GetConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = LoginField.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = PassField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = UserNameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = UserSurnameField.Text;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Регистрация прошла успешно");
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
                MessageBox.Show("Ошибка при регистрации");

            db.CloseConnection();
        }

        public bool isUserExists()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL ", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Логин занят. Пожалуйста, введите другой");
                return true;
            }
            else
                return false;
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
