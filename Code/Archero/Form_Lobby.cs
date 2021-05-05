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
using System.Resources;
using System.Reflection.Emit;
using System.Drawing.Text;
using Archero.DataSet_AccountsTableAdapters;

namespace Archero
{
    public partial class Form_Lobby : Form
    {
        public Form_Lobby(Form form, int Id_User)
        {
            InitializeComponent(); ;

            this.Id_User = Id_User;

            form_Login = form;

            queriesTableAdapter = new DataSet_AccountsTableAdapters.QueriesTableAdapter();

            Punctaj = (int)queriesTableAdapter.GetScore(Id_User);
            UserName = queriesTableAdapter.GetUserName(Id_User);

            label_Salut.Text = "Bine ai revenit " + UserName + "!";

            label_Salut.Location = new Point((Width - label_Salut.Width) / 2, label_Salut.Location.Y);
        }

        DataSet_Accounts.AccountsDataTable dataTable;
        DataSet_Accounts.AccountsDataTable dataTable2;

        QueriesTableAdapter queriesTableAdapter;

        Form form_Login;

        int Id_User;

        public int Punctaj;
        public string UserName;

        private void button1_Click(object sender, EventArgs e)
        {
            Form_DoneRegister form = new Form_DoneRegister(this);

            this.Hide();
            form.Show();
        }

        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Play_Click(object sender, EventArgs e)
        {
            Class_Bow bow = new Class_Bow(Properties.Resources.Bow, 200, 660);

            Form_Game form_Game = new Form_Game(bow, this, Id_User);
            Hide();
            form_Game.ShowDialog();
            Show();

            int nrMeciuri = (int)queriesTableAdapter.Get_NrMeciuri(Id_User);
            queriesTableAdapter.Update_NrMeciuri(nrMeciuri + 1, Id_User);
        }

        bool Stop = true;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DetaliiTableAdapter detaliiTableAdapter = new DetaliiTableAdapter();
            detaliiTableAdapter.UpdateQuery(false, 0);

            form_Login.Show();
            Stop = false;

            Close();
        }

        private void Form_Lobby_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Stop) Application.Exit();
        }

        private void tabPage_Statistici_Click(object sender, EventArgs e)
        {

        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

            dataTable = new DataSet_Accounts.AccountsDataTable();
            AccountsTableAdapter accountsTableAdapter = new AccountsTableAdapter();
            accountsTableAdapter.FillBy_ScoreMax(dataTable);

            dataTable2 = new DataSet_Accounts.AccountsDataTable();
            accountsTableAdapter.FillBy_Score(dataTable2);

            if (tabControl.SelectedIndex == 1)
            {
                textBox_MeciuriJucate.Text = queriesTableAdapter.Get_NrMeciuri(Id_User).ToString();
                textBox_Gaini.Text = queriesTableAdapter.Get_NrGaini(Id_User).ToString();
                textBox_ScorMaxim.Text = queriesTableAdapter.Get_ScoreMax(Id_User).ToString();
                textBox_Pui.Text = queriesTableAdapter.Get_NrPui(Id_User).ToString();
                textBox_Sageti.Text = queriesTableAdapter.Get_NrSageti(Id_User).ToString();


                bool ok = true;
                for(int i = 0; i < dataTable.Rows.Count && ok; i++)
                {
                    if(dataTable[i]["Id_User"].ToString() == Id_User.ToString())
                    {
                        textBox_RankScoreMax.Text = (i + 1).ToString();
                        ok = false;
                    }
                }

                ok = true;
                for (int i = 0; i < dataTable2.Rows.Count && ok; i++)
                {
                    if (dataTable2[i]["Id_User"].ToString() == Id_User.ToString())
                    {
                        textBox_RankScor.Text = (i + 1).ToString();
                        ok = false;
                    }
                }
            }

            if(tabControl.SelectedIndex == 2)
            {
                //Scor maxim
                textBox1.Text = dataTable.Rows[0][1].ToString();
                textBox2.Text = dataTable.Rows[1][1].ToString();
                textBox3.Text = dataTable.Rows[2][1].ToString();

                textBox7.Text = dataTable.Rows[0][5].ToString();
                textBox8.Text = dataTable.Rows[1][5].ToString();
                textBox9.Text = dataTable.Rows[2][5].ToString();

                //Scor total
                textBox4.Text = dataTable2.Rows[0][1].ToString();
                textBox5.Text = dataTable2.Rows[1][1].ToString();
                textBox6.Text = dataTable2.Rows[2][1].ToString();

                textBox10.Text = dataTable2.Rows[0][4].ToString();
                textBox11.Text = dataTable2.Rows[1][4].ToString();
                textBox12.Text = dataTable2.Rows[2][4].ToString();
            }
        }
    }
}
