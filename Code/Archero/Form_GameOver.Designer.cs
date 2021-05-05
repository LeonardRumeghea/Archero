namespace Archero
{
    partial class Form_GameOver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_GameOver));
            this.label_Text = new System.Windows.Forms.Label();
            this.pictureBox_Chicken = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Chicken)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Text
            // 
            this.label_Text.AutoSize = true;
            this.label_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Text.ForeColor = System.Drawing.Color.White;
            this.label_Text.Location = new System.Drawing.Point(25, 243);
            this.label_Text.Name = "label_Text";
            this.label_Text.Size = new System.Drawing.Size(279, 78);
            this.label_Text.TabIndex = 31;
            this.label_Text.Text = "Ai reusit sa omori\r\n0 Gaini!";
            this.label_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_Chicken
            // 
            this.pictureBox_Chicken.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Chicken.Image = global::Archero.Properties.Resources.Angry_Chicken;
            this.pictureBox_Chicken.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_Chicken.Name = "pictureBox_Chicken";
            this.pictureBox_Chicken.Size = new System.Drawing.Size(306, 219);
            this.pictureBox_Chicken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Chicken.TabIndex = 30;
            this.pictureBox_Chicken.TabStop = false;
            // 
            // Form_GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(170)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(330, 333);
            this.Controls.Add(this.label_Text);
            this.Controls.Add(this.pictureBox_Chicken);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_GameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Over";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Chicken)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Text;
        private System.Windows.Forms.PictureBox pictureBox_Chicken;
    }
}