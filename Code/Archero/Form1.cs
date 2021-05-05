using Archero.DataSet_AccountsTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace Archero
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();

            

            
        }

        bool conectat;

        DetaliiTableAdapter detaliiTableAdapter;
        private void label_CreateAccount_Click(object sender, EventArgs e)
        {
            Form_Register form = new Form_Register(this);

            this.Hide();
            form.Show();
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

        private void button_Login_Click(object sender, EventArgs e)
        {
            QueriesTableAdapter queriesTableAdapter = new QueriesTableAdapter();

            int ok = (int)queriesTableAdapter.GetAccountExistence(textBox_Email.Text, textBox_Password.Text);

            if (ok == 0)
            {
                MessageBox.Show(text: "Datele introduse sunt incorecte!",
                                caption: "Atentie!",
                                buttons: MessageBoxButtons.OK,
                                icon: MessageBoxIcon.Warning);
            }
            else
            {
                int Id_User = (int)queriesTableAdapter.GetIdUser_ByEmail(textBox_Email.Text);

                textBox_Email.Text = "";
                textBox_Password.Text = "";

                if (checkBox_RememberMe.Checked)
                {
                    detaliiTableAdapter.UpdateQuery(checkBox_RememberMe.Checked, Id_User);
                }

                Form_Lobby form = new Form_Lobby(this, Id_User);

                Hide();

                form.Show();
            }
        }

        private void Form_Login_Activated(object sender, EventArgs e)
        {

            QueriesTableAdapter queriesTableAdapter = new QueriesTableAdapter();

            detaliiTableAdapter = new DetaliiTableAdapter();

            conectat = (bool)queriesTableAdapter.Get_Conectat();

            if (conectat)
            {
                int Id_User = (int)queriesTableAdapter.Get_Id_User();

                Form_Lobby form = new Form_Lobby(this, Id_User);

                Hide();

                form.Show();
            }
        }
    }
}
