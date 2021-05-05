namespace Archero
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.button_Useless = new System.Windows.Forms.Button();
            this.button_Login = new System.Windows.Forms.Button();
            this.label_CreateAccount = new System.Windows.Forms.Label();
            this.label_Text = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.pictureBox_ShowPassword = new System.Windows.Forms.PictureBox();
            this.pictureBox_Password = new System.Windows.Forms.PictureBox();
            this.pictureBox_Email = new System.Windows.Forms.PictureBox();
            this.pictureBox_Chicken = new System.Windows.Forms.PictureBox();
            this.checkBox_RememberMe = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ShowPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Chicken)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Useless
            // 
            this.button_Useless.BackColor = System.Drawing.Color.Transparent;
            this.button_Useless.FlatAppearance.BorderSize = 0;
            this.button_Useless.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Useless.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Useless.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Useless.Location = new System.Drawing.Point(547, 582);
            this.button_Useless.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Useless.Name = "button_Useless";
            this.button_Useless.Size = new System.Drawing.Size(11, 12);
            this.button_Useless.TabIndex = 35;
            this.button_Useless.UseVisualStyleBackColor = false;
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.Color.Transparent;
            this.button_Login.FlatAppearance.BorderSize = 4;
            this.button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login.ForeColor = System.Drawing.Color.White;
            this.button_Login.Location = new System.Drawing.Point(193, 479);
            this.button_Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(180, 70);
            this.button_Login.TabIndex = 43;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // label_CreateAccount
            // 
            this.label_CreateAccount.AutoSize = true;
            this.label_CreateAccount.BackColor = System.Drawing.Color.Transparent;
            this.label_CreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_CreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CreateAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(80)))), ((int)(((byte)(79)))));
            this.label_CreateAccount.Location = new System.Drawing.Point(349, 570);
            this.label_CreateAccount.Name = "label_CreateAccount";
            this.label_CreateAccount.Size = new System.Drawing.Size(150, 25);
            this.label_CreateAccount.TabIndex = 39;
            this.label_CreateAccount.Text = "Create one now";
            this.label_CreateAccount.Click += new System.EventHandler(this.label_CreateAccount_Click);
            // 
            // label_Text
            // 
            this.label_Text.AutoSize = true;
            this.label_Text.BackColor = System.Drawing.Color.Transparent;
            this.label_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Text.Location = new System.Drawing.Point(37, 570);
            this.label_Text.Name = "label_Text";
            this.label_Text.Size = new System.Drawing.Size(283, 25);
            this.label_Text.TabIndex = 38;
            this.label_Text.Text = "Don\'t have a Archero Account?";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password.ForeColor = System.Drawing.Color.Silver;
            this.textBox_Password.Location = new System.Drawing.Point(121, 383);
            this.textBox_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(367, 36);
            this.textBox_Password.TabIndex = 37;
            this.textBox_Password.Text = "Password";
            this.textBox_Password.Click += new System.EventHandler(this.textBox_Password_Click);
            // 
            // textBox_Email
            // 
            this.textBox_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Email.ForeColor = System.Drawing.Color.Silver;
            this.textBox_Email.Location = new System.Drawing.Point(121, 297);
            this.textBox_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(367, 36);
            this.textBox_Email.TabIndex = 36;
            this.textBox_Email.Text = "Email";
            this.textBox_Email.Click += new System.EventHandler(this.textBox_Email_Click);
            // 
            // pictureBox_ShowPassword
            // 
            this.pictureBox_ShowPassword.Image = global::Archero.Properties.Resources.Icon_ShowPassword;
            this.pictureBox_ShowPassword.Location = new System.Drawing.Point(508, 384);
            this.pictureBox_ShowPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_ShowPassword.Name = "pictureBox_ShowPassword";
            this.pictureBox_ShowPassword.Size = new System.Drawing.Size(36, 36);
            this.pictureBox_ShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ShowPassword.TabIndex = 44;
            this.pictureBox_ShowPassword.TabStop = false;
            this.pictureBox_ShowPassword.Click += new System.EventHandler(this.pictureBox_ShowPassword_Click);
            // 
            // pictureBox_Password
            // 
            this.pictureBox_Password.Image = global::Archero.Properties.Resources.Icon_Password;
            this.pictureBox_Password.Location = new System.Drawing.Point(55, 361);
            this.pictureBox_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_Password.Name = "pictureBox_Password";
            this.pictureBox_Password.Size = new System.Drawing.Size(60, 60);
            this.pictureBox_Password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Password.TabIndex = 42;
            this.pictureBox_Password.TabStop = false;
            // 
            // pictureBox_Email
            // 
            this.pictureBox_Email.Image = global::Archero.Properties.Resources.Icon_Email;
            this.pictureBox_Email.Location = new System.Drawing.Point(55, 273);
            this.pictureBox_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_Email.Name = "pictureBox_Email";
            this.pictureBox_Email.Size = new System.Drawing.Size(60, 60);
            this.pictureBox_Email.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Email.TabIndex = 41;
            this.pictureBox_Email.TabStop = false;
            // 
            // pictureBox_Chicken
            // 
            this.pictureBox_Chicken.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox_Chicken.Image = global::Archero.Properties.Resources.Background_Login;
            this.pictureBox_Chicken.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Chicken.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_Chicken.Name = "pictureBox_Chicken";
            this.pictureBox_Chicken.Size = new System.Drawing.Size(571, 250);
            this.pictureBox_Chicken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Chicken.TabIndex = 40;
            this.pictureBox_Chicken.TabStop = false;
            // 
            // checkBox_RememberMe
            // 
            this.checkBox_RememberMe.AutoSize = true;
            this.checkBox_RememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_RememberMe.ForeColor = System.Drawing.Color.White;
            this.checkBox_RememberMe.Location = new System.Drawing.Point(121, 427);
            this.checkBox_RememberMe.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_RememberMe.Name = "checkBox_RememberMe";
            this.checkBox_RememberMe.Size = new System.Drawing.Size(207, 33);
            this.checkBox_RememberMe.TabIndex = 45;
            this.checkBox_RememberMe.Text = "Remember me";
            this.checkBox_RememberMe.UseVisualStyleBackColor = true;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(170)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(571, 608);
            this.Controls.Add(this.checkBox_RememberMe);
            this.Controls.Add(this.button_Useless);
            this.Controls.Add(this.pictureBox_ShowPassword);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.pictureBox_Password);
            this.Controls.Add(this.pictureBox_Email);
            this.Controls.Add(this.pictureBox_Chicken);
            this.Controls.Add(this.label_CreateAccount);
            this.Controls.Add(this.label_Text);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Activated += new System.EventHandler(this.Form_Login_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ShowPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Chicken)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Useless;
        private System.Windows.Forms.PictureBox pictureBox_ShowPassword;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.PictureBox pictureBox_Password;
        private System.Windows.Forms.PictureBox pictureBox_Email;
        private System.Windows.Forms.PictureBox pictureBox_Chicken;
        private System.Windows.Forms.Label label_CreateAccount;
        private System.Windows.Forms.Label label_Text;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.CheckBox checkBox_RememberMe;
    }
}

