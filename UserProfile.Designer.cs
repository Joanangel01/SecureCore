
namespace Sprint2
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.closeProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeImg)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(214, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 34);
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
            this.lblSurname.Location = new System.Drawing.Point(456, 151);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(92, 25);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "Surname";
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.lblRank.ForeColor = System.Drawing.Color.White;
            this.lblRank.Location = new System.Drawing.Point(456, 179);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(57, 25);
            this.lblRank.TabIndex = 4;
            this.lblRank.Text = "Rank";
            // 
            // lblSpecie
            // 
            this.lblSpecie.AutoSize = true;
            this.lblSpecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.lblSpecie.ForeColor = System.Drawing.Color.White;
            this.lblSpecie.Location = new System.Drawing.Point(456, 206);
            this.lblSpecie.Name = "lblSpecie";
            this.lblSpecie.Size = new System.Drawing.Size(73, 25);
            this.lblSpecie.TabIndex = 5;
            this.lblSpecie.Text = "Specie";
            // 
            // lblPlanet
            // 
            this.lblPlanet.AutoSize = true;
            this.lblPlanet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.lblPlanet.ForeColor = System.Drawing.Color.White;
            this.lblPlanet.Location = new System.Drawing.Point(456, 239);
            this.lblPlanet.Name = "lblPlanet";
            this.lblPlanet.Size = new System.Drawing.Size(67, 25);
            this.lblPlanet.TabIndex = 6;
            this.lblPlanet.Text = "Planet";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(148, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(456, 121);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 25);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name: ";
            // 
            // closeProfile
            // 
            this.closeProfile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeProfile.Controls.Add(this.closeImg);
            this.closeProfile.Location = new System.Drawing.Point(740, 8);
            this.closeProfile.Name = "closeProfile";
            this.closeProfile.Size = new System.Drawing.Size(24, 28);
            this.closeProfile.TabIndex = 7;
            // 
            // closeImg
            // 
            this.closeImg.Image = ((System.Drawing.Image)(resources.GetObject("closeImg.Image")));
            this.closeImg.Location = new System.Drawing.Point(0, 3);
            this.closeImg.Name = "closeImg";
            this.closeImg.Size = new System.Drawing.Size(24, 24);
            this.closeImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeImg.TabIndex = 0;
            this.closeImg.TabStop = false;
            this.closeImg.Click += new System.EventHandler(this.CloseImg_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lblResult);
            this.panel1.Controls.Add(this.closeProfile);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblPlanet);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblSpecie);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblRank);
            this.panel1.Controls.Add(this.lblSurname);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 444);
            this.panel1.TabIndex = 8;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(217, 331);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 18);
            this.lblResult.TabIndex = 8;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(156)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
    }
}