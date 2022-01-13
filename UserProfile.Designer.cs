
namespace SecureCore
{
    partial class UserProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfile));
            this.button1 = new System.Windows.Forms.Button();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblRank = new System.Windows.Forms.Label();
            this.lblSpecie = new System.Windows.Forms.Label();
            this.lblPlanet = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.closeProfile = new System.Windows.Forms.Panel();
            this.closeImg = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblResult = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.closeProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeImg)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(322, 484);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Change Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.lblSurname.ForeColor = System.Drawing.Color.White;
            this.lblSurname.Location = new System.Drawing.Point(684, 236);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(181, 46);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "Surname";
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.lblRank.ForeColor = System.Drawing.Color.White;
            this.lblRank.Location = new System.Drawing.Point(684, 280);
            this.lblRank.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(113, 46);
            this.lblRank.TabIndex = 4;
            this.lblRank.Text = "Rank";
            // 
            // lblSpecie
            // 
            this.lblSpecie.AutoSize = true;
            this.lblSpecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.lblSpecie.ForeColor = System.Drawing.Color.White;
            this.lblSpecie.Location = new System.Drawing.Point(684, 322);
            this.lblSpecie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpecie.Name = "lblSpecie";
            this.lblSpecie.Size = new System.Drawing.Size(143, 46);
            this.lblSpecie.TabIndex = 5;
            this.lblSpecie.Text = "Specie";
            // 
            // lblPlanet
            // 
            this.lblPlanet.AutoSize = true;
            this.lblPlanet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.lblPlanet.ForeColor = System.Drawing.Color.White;
            this.lblPlanet.Location = new System.Drawing.Point(684, 373);
            this.lblPlanet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlanet.Name = "lblPlanet";
            this.lblPlanet.Size = new System.Drawing.Size(133, 46);
            this.lblPlanet.TabIndex = 6;
            this.lblPlanet.Text = "Planet";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(222, 119);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 331);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(684, 189);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(148, 46);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name: ";
            // 
            // closeProfile
            // 
            this.closeProfile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeProfile.Controls.Add(this.closeImg);
            this.closeProfile.Location = new System.Drawing.Point(1110, 12);
            this.closeProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.closeProfile.Name = "closeProfile";
            this.closeProfile.Size = new System.Drawing.Size(36, 44);
            this.closeProfile.TabIndex = 7;
            // 
            // closeImg
            // 
            this.closeImg.Image = ((System.Drawing.Image)(resources.GetObject("closeImg.Image")));
            this.closeImg.Location = new System.Drawing.Point(0, 5);
            this.closeImg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.closeImg.Name = "closeImg";
            this.closeImg.Size = new System.Drawing.Size(36, 38);
            this.closeImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeImg.TabIndex = 0;
            this.closeImg.TabStop = false;
            this.closeImg.Click += new System.EventHandler(this.CloseImg_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.lblResult);
            this.panel1.Controls.Add(this.closeProfile);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblPlanet);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblSpecie);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblRank);
            this.panel1.Controls.Add(this.lblSurname);
            this.panel1.Location = new System.Drawing.Point(6, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1188, 694);
            this.panel1.TabIndex = 8;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(326, 517);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 33);
            this.lblResult.TabIndex = 8;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(671, 484);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 53);
            this.button2.TabIndex = 9;
            this.button2.Text = "Print Card";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(156)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserProfile";
            this.Load += new System.EventHandler(this.UserProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.closeProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeImg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Label lblSpecie;
        private System.Windows.Forms.Label lblPlanet;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel closeProfile;
        private System.Windows.Forms.PictureBox closeImg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button button2;
    }
}