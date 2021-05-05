namespace Archero
{
    partial class Form_Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Game));
            this.pictureBox_Fundal = new System.Windows.Forms.PictureBox();
            this.pictureBox_Arrow3 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Arrow2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Arrow1 = new System.Windows.Forms.PictureBox();
            this.label_Punctaj = new System.Windows.Forms.Label();
            this.pictureBox_Score = new System.Windows.Forms.PictureBox();
            this.timer_Arrow = new System.Windows.Forms.Timer(this.components);
            this.timer_Chicken = new System.Windows.Forms.Timer(this.components);
            this.timer_Disappear = new System.Windows.Forms.Timer(this.components);
            this.button_Quit = new System.Windows.Forms.Button();
            this.button_BackToGame = new System.Windows.Forms.Button();
            this.pictureBox_Pause = new System.Windows.Forms.PictureBox();
            this.pictureBox_Sound = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Fundal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Arrow3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Arrow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Arrow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Sound)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Fundal
            // 
            this.pictureBox_Fundal.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Fundal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Fundal.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Fundal.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_Fundal.Name = "pictureBox_Fundal";
            this.pictureBox_Fundal.Size = new System.Drawing.Size(550, 750);
            this.pictureBox_Fundal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_Fundal.TabIndex = 2;
            this.pictureBox_Fundal.TabStop = false;
            this.pictureBox_Fundal.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Fundal_Paint);
            // 
            // pictureBox_Arrow3
            // 
            this.pictureBox_Arrow3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Arrow3.Image = global::Archero.Properties.Resources.Icon_Arrow;
            this.pictureBox_Arrow3.Location = new System.Drawing.Point(108, 11);
            this.pictureBox_Arrow3.Name = "pictureBox_Arrow3";
            this.pictureBox_Arrow3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_Arrow3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Arrow3.TabIndex = 36;
            this.pictureBox_Arrow3.TabStop = false;
            // 
            // pictureBox_Arrow2
            // 
            this.pictureBox_Arrow2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Arrow2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Arrow2.Image")));
            this.pictureBox_Arrow2.Location = new System.Drawing.Point(58, 11);
            this.pictureBox_Arrow2.Name = "pictureBox_Arrow2";
            this.pictureBox_Arrow2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_Arrow2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Arrow2.TabIndex = 35;
            this.pictureBox_Arrow2.TabStop = false;
            // 
            // pictureBox_Arrow1
            // 
            this.pictureBox_Arrow1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Arrow1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Arrow1.Image")));
            this.pictureBox_Arrow1.Location = new System.Drawing.Point(8, 11);
            this.pictureBox_Arrow1.Name = "pictureBox_Arrow1";
            this.pictureBox_Arrow1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_Arrow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Arrow1.TabIndex = 34;
            this.pictureBox_Arrow1.TabStop = false;
            // 
            // label_Punctaj
            // 
            this.label_Punctaj.AutoSize = true;
            this.label_Punctaj.BackColor = System.Drawing.Color.Transparent;
            this.label_Punctaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Punctaj.ForeColor = System.Drawing.Color.White;
            this.label_Punctaj.Location = new System.Drawing.Point(63, 80);
            this.label_Punctaj.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Punctaj.Name = "label_Punctaj";
            this.label_Punctaj.Size = new System.Drawing.Size(43, 46);
            this.label_Punctaj.TabIndex = 33;
            this.label_Punctaj.Text = "0";
            // 
            // pictureBox_Score
            // 
            this.pictureBox_Score.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Score.Image = global::Archero.Properties.Resources.Chicken_Cooked;
            this.pictureBox_Score.Location = new System.Drawing.Point(8, 76);
            this.pictureBox_Score.Name = "pictureBox_Score";
            this.pictureBox_Score.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_Score.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Score.TabIndex = 32;
            this.pictureBox_Score.TabStop = false;
            // 
            // timer_Arrow
            // 
            this.timer_Arrow.Interval = 20;
            this.timer_Arrow.Tick += new System.EventHandler(this.timer_Arrow_Tick);
            // 
            // timer_Chicken
            // 
            this.timer_Chicken.Enabled = true;
            this.timer_Chicken.Interval = 1000;
            this.timer_Chicken.Tick += new System.EventHandler(this.timer_Chicken_Tick);
            // 
            // timer_Disappear
            // 
            this.timer_Disappear.Enabled = true;
            this.timer_Disappear.Interval = 1000;
            this.timer_Disappear.Tick += new System.EventHandler(this.timer_Disappear_Tick);
            // 
            // button_Quit
            // 
            this.button_Quit.BackColor = System.Drawing.Color.Transparent;
            this.button_Quit.Enabled = false;
            this.button_Quit.FlatAppearance.BorderSize = 4;
            this.button_Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Quit.ForeColor = System.Drawing.Color.White;
            this.button_Quit.Location = new System.Drawing.Point(114, 348);
            this.button_Quit.Margin = new System.Windows.Forms.Padding(2);
            this.button_Quit.Name = "button_Quit";
            this.button_Quit.Size = new System.Drawing.Size(325, 93);
            this.button_Quit.TabIndex = 40;
            this.button_Quit.Text = "Quit";
            this.button_Quit.UseVisualStyleBackColor = false;
            this.button_Quit.Visible = false;
            this.button_Quit.Click += new System.EventHandler(this.pictureBox_Close_Click);
            // 
            // button_BackToGame
            // 
            this.button_BackToGame.BackColor = System.Drawing.Color.Transparent;
            this.button_BackToGame.Enabled = false;
            this.button_BackToGame.FlatAppearance.BorderSize = 4;
            this.button_BackToGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_BackToGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BackToGame.ForeColor = System.Drawing.Color.White;
            this.button_BackToGame.Location = new System.Drawing.Point(114, 240);
            this.button_BackToGame.Margin = new System.Windows.Forms.Padding(2);
            this.button_BackToGame.Name = "button_BackToGame";
            this.button_BackToGame.Size = new System.Drawing.Size(325, 93);
            this.button_BackToGame.TabIndex = 39;
            this.button_BackToGame.Text = "Back to Game";
            this.button_BackToGame.UseVisualStyleBackColor = false;
            this.button_BackToGame.Visible = false;
            this.button_BackToGame.Click += new System.EventHandler(this.button_BackToGame_Click);
            // 
            // pictureBox_Pause
            // 
            this.pictureBox_Pause.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Pause.Image = global::Archero.Properties.Resources.Icons_Pause;
            this.pictureBox_Pause.Location = new System.Drawing.Point(262, 12);
            this.pictureBox_Pause.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_Pause.Name = "pictureBox_Pause";
            this.pictureBox_Pause.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_Pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Pause.TabIndex = 38;
            this.pictureBox_Pause.TabStop = false;
            this.pictureBox_Pause.Click += new System.EventHandler(this.pictureBox_Pause_Click);
            // 
            // pictureBox_Sound
            // 
            this.pictureBox_Sound.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Sound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Sound.Image = global::Archero.Properties.Resources.Icons_Sound_On;
            this.pictureBox_Sound.Location = new System.Drawing.Point(501, 12);
            this.pictureBox_Sound.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_Sound.Name = "pictureBox_Sound";
            this.pictureBox_Sound.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_Sound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Sound.TabIndex = 37;
            this.pictureBox_Sound.TabStop = false;
            this.pictureBox_Sound.Click += new System.EventHandler(this.pictureBox_Sound_Click);
            // 
            // Form_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Archero.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(550, 750);
            this.Controls.Add(this.pictureBox_Arrow3);
            this.Controls.Add(this.pictureBox_Arrow2);
            this.Controls.Add(this.pictureBox_Arrow1);
            this.Controls.Add(this.label_Punctaj);
            this.Controls.Add(this.pictureBox_Score);
            this.Controls.Add(this.button_Quit);
            this.Controls.Add(this.button_BackToGame);
            this.Controls.Add(this.pictureBox_Pause);
            this.Controls.Add(this.pictureBox_Sound);
            this.Controls.Add(this.pictureBox_Fundal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archero";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Game_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form_Game_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Fundal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Arrow3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Arrow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Arrow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Sound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Fundal;
        private System.Windows.Forms.PictureBox pictureBox_Arrow3;
        private System.Windows.Forms.PictureBox pictureBox_Arrow2;
        private System.Windows.Forms.PictureBox pictureBox_Arrow1;
        private System.Windows.Forms.Label label_Punctaj;
        private System.Windows.Forms.PictureBox pictureBox_Score;
        private System.Windows.Forms.Timer timer_Arrow;
        private System.Windows.Forms.Timer timer_Chicken;
        private System.Windows.Forms.Timer timer_Disappear;
        private System.Windows.Forms.Button button_Quit;
        private System.Windows.Forms.Button button_BackToGame;
        private System.Windows.Forms.PictureBox pictureBox_Pause;
        private System.Windows.Forms.PictureBox pictureBox_Sound;
    }
}