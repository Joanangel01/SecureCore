using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SecureCore
{
    partial class SplashScreen
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codi dels Elements del Cuadre de Eines
        
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.blackPanel = new System.Windows.Forms.Panel();
            this.SecureCore = new System.Windows.Forms.PictureBox();
            this.Lighsaber = new System.Windows.Forms.PictureBox();
            this.textLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SecureCore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lighsaber)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // blackPanel
            // 
            this.blackPanel.BackColor = System.Drawing.Color.Black;
            this.blackPanel.Location = new System.Drawing.Point(389, 131);
            this.blackPanel.Name = "blackPanel";
            this.blackPanel.Size = new System.Drawing.Size(659, 300);
            this.blackPanel.TabIndex = 2;
            // 
            // SecureCore
            // 
            this.SecureCore.Image = ((System.Drawing.Image)(resources.GetObject("SecureCore.Image")));
            this.SecureCore.Location = new System.Drawing.Point(158, -31);
            this.SecureCore.Name = "SecureCore";
            this.SecureCore.Size = new System.Drawing.Size(856, 289);
            this.SecureCore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SecureCore.TabIndex = 3;
            this.SecureCore.TabStop = false;
            // 
            // Lighsaber
            // 
            this.Lighsaber.BackColor = System.Drawing.Color.Transparent;
            this.Lighsaber.Image = ((System.Drawing.Image)(resources.GetObject("Lighsaber.Image")));
            this.Lighsaber.Location = new System.Drawing.Point(146, 158);
            this.Lighsaber.Name = "Lighsaber";
            this.Lighsaber.Size = new System.Drawing.Size(902, 430);
            this.Lighsaber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Lighsaber.TabIndex = 1;
            this.Lighsaber.TabStop = false;
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(156)))), ((int)(((byte)(68)))));
            this.textLabel.Location = new System.Drawing.Point(435, 667);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(320, 55);
            this.textLabel.TabIndex = 4;
            this.textLabel.Text = "Version 1.0.2";
            this.textLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.SecureCore);
            this.Controls.Add(this.blackPanel);
            this.Controls.Add(this.Lighsaber);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secure Core - Loading...";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SecureCore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lighsaber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Timer Timer;
        private PictureBox Lighsaber;
        private Panel blackPanel;
        private PictureBox SecureCore;
        private Label textLabel;
    }
}

