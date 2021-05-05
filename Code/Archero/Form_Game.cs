using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Archero
{
    public partial class Form_Game : Form
    {
        public Form_Game(Class_Bow bow, Form form, int Id_User)
        {
            InitializeComponent();

            this.bow = bow;

            aim = new Class_Aim(bow.X + bow.Width / 2 - 7, 430);

            form_Start = form;

            this.Id_User = Id_User;

            arrow = new Class_Arrow();

            frec = new int[9];

            for (int i = 1; i <= 8; i++) frec[i] = 0;

            rnd = new Random();
            chickens = new List<Class_Chicken>();

            soundPlayer_Chicken_Hurt = new SoundPlayer(Properties.Resources.Sound_chicken_Hurt);
            soundPlayer_Chicken_Spawn = new SoundPlayer(Properties.Resources.Shound_Chicken_Spawn);
        }

        bool Sound = true;

        SoundPlayer soundPlayer_Chicken_Hurt;
        SoundPlayer soundPlayer_Chicken_Spawn;

        Class_Bow bow;
        Class_Aim aim;
        Class_Arrow arrow;

        Random rnd;

        List<Class_Chicken> chickens;
        int[] frec;

        int Id_User, Score = 0;

        bool Trage = false;

        Form form_Start;

        int nivel = 1, nrGaini = 0, nrSageti = 3;

        private void Form_Game_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                if (nivel == 1)
                {
                    if (bow.X == 70) bow.X = 140;
                    else if (bow.X == 140) bow.X = 200;
                    else if (bow.X == 200) bow.X = 250;
                }
                if (nivel == 2)
                {
                    if (bow.X == 90) bow.X = 145;
                    else if (bow.X == 145) bow.X = 200;
                    else if (bow.X == 200) bow.X = 240;
                }
            }
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                if (nivel == 1)
                {
                    if (bow.X == 250) bow.X = 200;
                    else if (bow.X == 200) bow.X = 140;
                    else if (bow.X == 140) bow.X = 70;
                }
                if (nivel == 2)
                {
                    if (bow.X == 240) bow.X = 200;
                    else if (bow.X == 200) bow.X = 145;
                    else if (bow.X == 145) bow.X = 90;
                }
            }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                if (nivel == 1) nivel = 2;
                bow.Y = 600;

                if (bow.X == 70) bow.X = 90;
                else if (bow.X == 140) bow.X = 145;
                else if (bow.X == 200) bow.X = 200;
                else if (bow.X == 250) bow.X = 240;
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                if (nivel == 2) nivel = 1;
                bow.Y = 660;

                if (bow.X == 90) bow.X = 70;
                else if (bow.X == 145) bow.X = 140;
                else if (bow.X == 200) bow.X = 200;
                else if (bow.X == 240) bow.X = 250;
            }

            if (nivel == 1) // actualizam locatia sagetii
            {
                aim.X = bow.X + bow.Width / 2 - 7;
                aim.Y = 430;
            }
            if (nivel == 2)
            {
                aim.X = bow.X + bow.Width / 2 - 7;
                aim.Y = 390;
            }

            if (e.KeyCode == Keys.Space) // Incercam sageata
            {
                if (!Trage)
                {
                    bow.image_Bow = Properties.Resources.Bow_Pull;
                }
            }

            pictureBox_Fundal.Refresh();
        }

        private void pictureBox_Fundal_Paint(object sender, PaintEventArgs e)
        {
            bow.Draw(e.Graphics); // Desenam obiectele
            if (Trage) arrow.Draw(e.Graphics);

            foreach (Class_Chicken chicken in chickens)
            {
                chicken.Draw(e.Graphics);
            }

            aim.Draw(e.Graphics);
        }

        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Game_FormClosing(object sender, FormClosingEventArgs e)
        {

            DataSet_AccountsTableAdapters.QueriesTableAdapter queriesTableAdapter = new DataSet_AccountsTableAdapters.QueriesTableAdapter();

            int scorActual = (int)queriesTableAdapter.GetScore(Id_User);

            queriesTableAdapter.UpdateScore(scorActual + Score, Id_User);
            queriesTableAdapter.Update_NrGaini(scorActual + Score, Id_User);

            int numarSageti = (int)queriesTableAdapter.Get_NrSageti(Id_User);
            queriesTableAdapter.Update_NrSageti(numarSageti + (3 - nrSageti), Id_User);

            int ScoreMaxim = (int)queriesTableAdapter.Get_ScoreMax(Id_User);

            if(Score > ScoreMaxim)
            {
                queriesTableAdapter.Update_ScoreMax(Score, Id_User);
            }

            form_Start.Show();

            timer_Arrow.Stop();
            timer_Chicken.Stop();
            timer_Disappear.Stop();

            //actualizeaza scor
        }

        private void Form_Game_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (!Trage)
                {
                    arrow.nivel = nivel;

                    arrow.X = bow.X + bow.Width / 2 - arrow.Width / 2;
                    arrow.Y = bow.Y - 50;

                    Trage = true;

                    timer_Arrow.Start();
                }

                bow.image_Bow = Properties.Resources.Bow;
                pictureBox_Fundal.Refresh();
            }
        }

        private void timer_Arrow_Tick(object sender, EventArgs e)
        {

            if (arrow.nivel == 1)
            {
                if (arrow.Y <= 415)
                {
                    timer_Arrow.Stop();
                    Trage = false;

                    nrSageti--;

                    if (nrSageti == 2) pictureBox_Arrow3.Image = Properties.Resources.Icon_Arrow_Empty;
                    if (nrSageti == 1) pictureBox_Arrow2.Image = Properties.Resources.Icon_Arrow_Empty;
                    if (nrSageti == 0) pictureBox_Arrow1.Image = Properties.Resources.Icon_Arrow_Empty;

                    if (nrSageti == 0)
                    {
                        timer_Arrow.Stop();
                        timer_Chicken.Stop();

                        Hide();

                        Form_GameOver form_GameOver = new Form_GameOver(Score);

                        form_GameOver.ShowDialog();

                        Close();
                    }

                    return;
                }
            }

            if (arrow.nivel == 2)
            {
                if (arrow.Y <= 370)
                {
                    timer_Arrow.Stop();
                    Trage = false;

                    nrSageti--;

                    if (nrSageti == 2) pictureBox_Arrow3.Image = Properties.Resources.Icon_Arrow_Empty;
                    if (nrSageti == 1) pictureBox_Arrow2.Image = Properties.Resources.Icon_Arrow_Empty;
                    if (nrSageti == 0) pictureBox_Arrow1.Image = Properties.Resources.Icon_Arrow_Empty;

                    if (nrSageti == 0)
                    {
                        timer_Arrow.Stop();
                        timer_Chicken.Stop();

                        Hide();

                        Form_GameOver form_GameOver = new Form_GameOver(Score);

                        form_GameOver.ShowDialog();

                        Close();
                    }

                    return;
                }
            }

            HitChicken(arrow);

            arrow.Y -= 10;

            pictureBox_Fundal.Refresh();
        }

        private void pictureBox_Fundal_Click(object sender, EventArgs e)
        {

        }

        private void timer_Disappear_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < chickens.Count; i++)
            {
                if (chickens[i].time == 0)
                {
                    frec[chickens[i].location] = 0;
                    chickens.RemoveAt(i);

                    nrGaini--;
                }
                else
                {
                    chickens[i].time--;
                }
            }
        }

        private void pictureBox_Sound_Click(object sender, EventArgs e)
        {
            Sound = !Sound;

            if (Sound) pictureBox_Sound.Image = Properties.Resources.Icons_Sound_On;
            if (!Sound) pictureBox_Sound.Image = Properties.Resources.Icons_Sound_Off;
        }

        private void pictureBox_Pause_Click(object sender, EventArgs e)
        {
            if (!button_BackToGame.Visible)
            {
                timer_Arrow.Stop();
                timer_Chicken.Stop();
                timer_Disappear.Stop();

                button_BackToGame.Visible = true;
                button_BackToGame.Enabled = true;
                button_Quit.Visible = true;
                button_Quit.Enabled = true;
            }
        }

        private void button_BackToGame_Click(object sender, EventArgs e)
        {
            button_BackToGame.Visible = false;
            button_BackToGame.Enabled = false;
            button_Quit.Visible = false;
            button_Quit.Enabled = false;

            timer_Arrow.Start();
            timer_Chicken.Start();
            timer_Disappear.Start();
        }

        void HitChicken(Class_Arrow arrow)
        {
            if (arrow.nivel == 1)
            {
                for (int i = 0; i < chickens.Count; i++)
                {
                    if (chickens[i].location <= 4)
                    {
                        if (arrow.X >= chickens[i].X && arrow.X <= chickens[i].X + chickens[i].Width)
                        {
                            if (arrow.Y >= chickens[i].Y && arrow.Y <= chickens[i].Y + chickens[i].Height)
                            {
                                if (!chickens[i].Baby)
                                {
                                    Score++;
                                    label_Punctaj.Text = Score.ToString();

                                    frec[chickens[i].location] = 0;
                                    chickens.RemoveAt(i);

                                    timer_Arrow.Stop();
                                    Trage = false;
                                    nrGaini--;

                                    if (Sound) soundPlayer_Chicken_Hurt.Play();
                                }
                                else
                                {
                                    if (Sound) soundPlayer_Chicken_Hurt.Play();

                                    DataSet_AccountsTableAdapters.QueriesTableAdapter queriesTableAdapter = new DataSet_AccountsTableAdapters.QueriesTableAdapter();

                                    int nrPui = (int)queriesTableAdapter.Get_NrPui(Id_User);
                                    queriesTableAdapter.Update_NrPui(nrPui + 1, Id_User);


                                    timer_Arrow.Stop();
                                    timer_Chicken.Stop();

                                    Hide();

                                    Form_GameOver form_GameOver = new Form_GameOver(Score);

                                    form_GameOver.ShowDialog();

                                    Close();
                                }


                            }
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < chickens.Count; i++)
                {
                    if (chickens[i].location >= 5)
                    {
                        if (arrow.X >= chickens[i].X && arrow.X <= chickens[i].X + chickens[i].Width)
                        {
                            if (arrow.Y >= chickens[i].Y && arrow.Y <= chickens[i].Y + chickens[i].Height)
                            {
                                if (!chickens[i].Baby)
                                {
                                    Score++;
                                    label_Punctaj.Text = Score.ToString();

                                    frec[chickens[i].location] = 0;
                                    chickens.RemoveAt(i);

                                    timer_Arrow.Stop();
                                    Trage = false;

                                    nrGaini--;

                                    if (Sound) soundPlayer_Chicken_Hurt.Play();

                                }
                                else
                                {
                                    if (Sound) soundPlayer_Chicken_Hurt.Play();

                                    DataSet_AccountsTableAdapters.QueriesTableAdapter queriesTableAdapter = new DataSet_AccountsTableAdapters.QueriesTableAdapter();

                                    int nrPui = (int)queriesTableAdapter.Get_NrPui(Id_User);
                                    queriesTableAdapter.Update_NrPui(nrPui + 1, Id_User);

                                    timer_Arrow.Stop();
                                    timer_Chicken.Stop();

                                    Hide();

                                    Form_GameOver form_GameOver = new Form_GameOver(Score);

                                    form_GameOver.ShowDialog();

                                    Close();

                                }
                            }
                        }
                    }
                }
            }
        }

        private void timer_Chicken_Tick(object sender, EventArgs e)
        {
            if (nrGaini < 8)
            {
                rnd = new Random();

                int location = rnd.Next(1, 9);

                if (frec[location] == 1)
                {
                    while (frec[location] == 1)
                    {
                        location = rnd.Next(1, 9);

                    }
                }

                frec[location] = 1;

                nrGaini++;

                int age = rnd.Next(1, 5);

                Class_Chicken chicken;


                if (Sound) soundPlayer_Chicken_Spawn.Play();

                if (location == 1)
                {
                    if (age == 4)
                    {
                        chicken = new Class_Chicken(150, 435, Properties.Resources.Chicken_Baby);
                        chicken.Width = 40;
                        chicken.Height = 40;
                        chickens.Add(chicken);
                        chicken.location = location;
                        chicken.Baby = true;

                        chicken.time = rnd.Next(1, 4);
                    }
                    else
                    {
                        chicken = new Class_Chicken(150, 425, Properties.Resources.Chicken);
                        chickens.Add(chicken);
                        chicken.location = location;

                        chicken.time = rnd.Next(1, 4);
                    }
                }
                if (location == 2)
                {
                    if (age == 4)
                    {
                        chicken = new Class_Chicken(220, 430, Properties.Resources.Chicken_Baby);
                        chickens.Add(chicken);
                        chicken.Width = 40;
                        chicken.Height = 40;
                        chicken.location = location;
                        chicken.Baby = true;

                        chicken.time = rnd.Next(1, 4);
                    }
                    else
                    {
                        chicken = new Class_Chicken(220, 420, Properties.Resources.Chicken);
                        chickens.Add(chicken);
                        chicken.location = location;

                        chicken.time = rnd.Next(1, 4);
                    }
                }
                if (location == 3)
                {
                    if (age == 4)
                    {
                        chicken = new Class_Chicken(275, 430, Properties.Resources.Chicken_Baby);
                        chickens.Add(chicken);
                        chicken.Width = 40;
                        chicken.Height = 40;
                        chicken.location = location;
                        chicken.Baby = true;

                        chicken.time = rnd.Next(1, 4);
                    }
                    else
                    {
                        chicken = new Class_Chicken(275, 420, Properties.Resources.Chicken);
                        chickens.Add(chicken);
                        chicken.location = location;

                        chicken.time = rnd.Next(1, 4);
                    }
                }
                if (location == 4)
                {
                    if (age == 4)
                    {
                        chicken = new Class_Chicken(330, 430, Properties.Resources.Chicken_Baby);
                        chickens.Add(chicken);
                        chicken.Width = 40;
                        chicken.Height = 40;
                        chicken.location = location;
                        chicken.Baby = true;

                        chicken.time = rnd.Next(1, 4);
                    }
                    else
                    {
                        chicken = new Class_Chicken(330, 420, Properties.Resources.Chicken);
                        chickens.Add(chicken);
                        chicken.location = location;

                        chicken.time = rnd.Next(1, 4);
                    }
                }
                if (location == 5)
                {
                    if (age == 4)
                    {
                        chicken = new Class_Chicken(155, 380, Properties.Resources.Chicken_Baby);
                        chickens.Add(chicken);
                        chicken.Width = 40;
                        chicken.Height = 40;
                        chicken.location = location;
                        chicken.Baby = true;

                        chicken.time = rnd.Next(1, 4);
                    }
                    else
                    {
                        chicken = new Class_Chicken(155, 370, Properties.Resources.Chicken);
                        chickens.Add(chicken);
                        chicken.location = location;

                        chicken.time = rnd.Next(1, 4);
                    }
                }
                if (location == 6)
                {
                    if (age == 4)
                    {
                        chicken = new Class_Chicken(220, 375, Properties.Resources.Chicken_Baby);
                        chickens.Add(chicken);
                        chicken.Width = 40;
                        chicken.Height = 40;
                        chicken.location = location;
                        chicken.Baby = true;

                        chicken.time = rnd.Next(1, 4);
                    }
                    else
                    {
                        chicken = new Class_Chicken(220, 365, Properties.Resources.Chicken);
                        chickens.Add(chicken);
                        chicken.location = location;

                        chicken.time = rnd.Next(1, 4);
                    }
                }
                if (location == 7)
                {
                    if (age == 4)
                    {
                        chicken = new Class_Chicken(275, 375, Properties.Resources.Chicken_Baby);
                        chickens.Add(chicken);
                        chicken.Width = 40;
                        chicken.Height = 40;
                        chicken.location = location;
                        chicken.Baby = true;

                        chicken.time = rnd.Next(1, 4);
                    }
                    else
                    {
                        chicken = new Class_Chicken(275, 365, Properties.Resources.Chicken);
                        chickens.Add(chicken);
                        chicken.location = location;

                        chicken.time = rnd.Next(1, 4);
                    }
                }
                if (location == 8)
                {
                    if (age == 4)
                    {
                        chicken = new Class_Chicken(320, 375, Properties.Resources.Chicken_Baby);
                        chickens.Add(chicken);
                        chicken.Width = 40;
                        chicken.Height = 40;
                        chicken.location = location;
                        chicken.Baby = true;

                        chicken.time = rnd.Next(1, 4);
                    }
                    else
                    {
                        chicken = new Class_Chicken(320, 365, Properties.Resources.Chicken);
                        chickens.Add(chicken);
                        chicken.location = location;

                        chicken.time = rnd.Next(1, 4);
                    }
                }

                pictureBox_Fundal.Refresh();
            }
        }
    }
}
