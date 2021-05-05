using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Archero
{
    public partial class Form_Register : Form
    {
        public Form_Register(Form form)
        {
            InitializeComponent();

            formLogin = form;

            QueriesTableAdapter = new DataSet_AccountsTableAdapters.QueriesTableAdapter();
        }

        Form formLogin;

        private void Form_Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            formLogin.Show();
        }

        private void textBox_Username_Click(object sender, EventArgs e)
        {
            if (textBox_Username.Text == "User Name" && textBox_Username.ForeColor == Color.Silver)
            {
                textBox_Username.Text = "";
                textBox_Username.ForeColor = Color.Black;
            }
        }

        private void textBox_Email_Click(object sender, EventArgs e)
        {
            if (textBox_Email.Text == "Email" && textBox_Email.ForeColor == Color.Silver)
            {
                textBox_Email.Text = "";
                textBox_Email.ForeColor = Color.Black;
            }
        }

        private void textBox_Password_Click(object sender, EventArgs e)
        {
            if (textBox_Password.Text == "Password" && textBox_Password.ForeColor == Color.Silver)
            {
                textBox_Password.Text = "";
                textBox_Password.ForeColor = Color.Black;
                textBox_Password.PasswordChar = '●';
            }
        }

        private void textBox_Password2_Click(object sender, EventArgs e)
        {
            if (textBox_Password2.Text == "Confirm Password" && textBox_Password2.ForeColor == Color.Silver)
            {
                textBox_Password2.Text = "";
                textBox_Password2.ForeColor = Color.Black;
                textBox_Password2.PasswordChar = '●';
            }
        }

        private void pictureBox_ShowPassword_Click(object sender, EventArgs e)
        {
            if (textBox_Password.PasswordChar == '●')
            {
                textBox_Password.PasswordChar = '\0';
            }
            else
            {
                textBox_Password.PasswordChar = '●';
            }
        }

        private void pictureBox_ShowPassword2_Click(object sender, EventArgs e)
        {
            if (textBox_Password2.PasswordChar == '●')
            {
                textBox_Password2.PasswordChar = '\0';
            }
            else
            {
                textBox_Password2.PasswordChar = '●';
            }
        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {
            label_WrongPassword.Visible = textBox_Password2.Text != "Confirm Password" && textBox_Password.Text != textBox_Password2.Text;
        }

        private void textBox_Password2_TextChanged(object sender, EventArgs e)
        {
            label_WrongPassword.Visible = textBox_Password.Text != "Confirm Password" && textBox_Password.Text != textBox_Password2.Text;
        }

        DataSet_AccountsTableAdapters.QueriesTableAdapter QueriesTableAdapter;

        bool CheckEmail(string text)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(text);

                return addr.Address == text;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            label_WrongUserName.Visible = textBox_Username.Text == "" || textBox_Username.Text == "User Name";

            label_WrongEmail.Visible = !CheckEmail(textBox_Email.Text);


            label_WrongPassword.Visible = (textBox_Password.Text == "" || 
                                           textBox_Password.Text == "Password") || 
                                           (textBox_Password2.Text == "" || 
                                           textBox_Password2.Text == "Confirm Password");

            if (!label_WrongUserName.Visible && !label_WrongEmail.Visible && !label_WrongPassword.Visible)
            {
                DataSet_AccountsTableAdapters.AccountsTableAdapter queriesTableAdapter = new DataSet_AccountsTableAdapters.AccountsTableAdapter();

                queriesTableAdapter.Insert(textBox_Username.Text, textBox_Email.Text, textBox_Password.Text, 0, 0);

                int Id = (int)QueriesTableAdapter.GetIdUser_ByEmail(textBox_Email.Text);

                QueriesTableAdapter.Insert_User(Id);

                Form_DoneRegister form = new Form_DoneRegister(formLogin);

                form.Show();

                Close();
                formLogin.Hide();
            }
        }
    }
}
