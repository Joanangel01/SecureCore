﻿
namespace Sprint2
{
    partial class MenuScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuScreen));
            this.panelDraggable = new System.Windows.Forms.Panel();
            this.labelUserRole = new System.Windows.Forms.Label();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.pictureMaximize = new System.Windows.Forms.PictureBox();
            this.pictureRestore = new System.Windows.Forms.PictureBox();
            this.pictureMinimize = new System.Windows.Forms.PictureBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.exitPanel = new System.Windows.Forms.Panel();
            this.exitLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.circleProfile = new System.Windows.Forms.PictureBox();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.panelDraggable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.exitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circleProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDraggable
            // 
            this.panelDraggable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(156)))), ((int)(((byte)(68)))));
            this.panelDraggable.Controls.Add(this.pictureRestore);
            this.panelDraggable.Controls.Add(this.circleProfile);
            this.panelDraggable.Controls.Add(this.labelUserRole);
            this.panelDraggable.Controls.Add(this.pictureUser);
            this.panelDraggable.Controls.Add(this.pictureMaximize);
            this.panelDraggable.Controls.Add(this.pictureMinimize);
            this.panelDraggable.Controls.Add(this.labelUser);
            this.panelDraggable.Controls.Add(this.pictureClose);
            this.panelDraggable.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelDraggable.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDraggable.Location = new System.Drawing.Point(0, 0);
            this.panelDraggable.Name = "panelDraggable";
            this.panelDraggable.Size = new System.Drawing.Size(900, 60);
            this.panelDraggable.TabIndex = 9;
            this.panelDraggable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelDraggable_MouseDown);
            this.panelDraggable.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelDraggable_MouseMove);
            this.panelDraggable.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelDraggable_MouseUp);
            // 
            // labelUserRole
            // 
            this.labelUserRole.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserRole.ForeColor = System.Drawing.Color.White;
            this.labelUserRole.Location = new System.Drawing.Point(77, 30);
            this.labelUserRole.Name = "labelUserRole";
            this.labelUserRole.Size = new System.Drawing.Size(343, 23);
            this.labelUserRole.TabIndex = 13;
            this.labelUserRole.Text = "User Category";
            this.labelUserRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureUser
            // 
            this.pictureUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(156)))), ((int)(((byte)(68)))));
            this.pictureUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureUser.Image")));
            this.pictureUser.Location = new System.Drawing.Point(16, 3);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(45, 50);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureUser.TabIndex = 12;
            this.pictureUser.TabStop = false;
            // 
            // pictureMaximize
            // 
            this.pictureMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureMaximize.Image = ((System.Drawing.Image)(resources.GetObject("pictureMaximize.Image")));
            this.pictureMaximize.Location = new System.Drawing.Point(843, 0);
            this.pictureMaximize.Name = "pictureMaximize";
            this.pictureMaximize.Size = new System.Drawing.Size(30, 30);
            this.pictureMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMaximize.TabIndex = 9;
            this.pictureMaximize.TabStop = false;
            this.pictureMaximize.Visible = false;
            this.pictureMaximize.Click += new System.EventHandler(this.PictureMaximize_Click);
            this.pictureMaximize.MouseLeave += new System.EventHandler(this.PictureMaximize_MouseLeave);
            this.pictureMaximize.MouseHover += new System.EventHandler(this.PictureMaximize_MouseHover);
            // 
            // pictureRestore
            // 
            this.pictureRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureRestore.Image = ((System.Drawing.Image)(resources.GetObject("pictureRestore.Image")));
            this.pictureRestore.Location = new System.Drawing.Point(843, 0);
            this.pictureRestore.Name = "pictureRestore";
            this.pictureRestore.Size = new System.Drawing.Size(30, 30);
            this.pictureRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureRestore.TabIndex = 11;
            this.pictureRestore.TabStop = false;
            this.pictureRestore.Click += new System.EventHandler(this.PictureRestore_Click);
            this.pictureRestore.MouseLeave += new System.EventHandler(this.PictureRestore_MouseLeave);
            this.pictureRestore.MouseHover += new System.EventHandler(this.PictureRestore_MouseHover);
            // 
            // pictureMinimize
            // 
            this.pictureMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pictureMinimize.Image")));
            this.pictureMinimize.Location = new System.Drawing.Point(816, 0);
            this.pictureMinimize.Name = "pictureMinimize";
            this.pictureMinimize.Size = new System.Drawing.Size(30, 30);
            this.pictureMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMinimize.TabIndex = 10;
            this.pictureMinimize.TabStop = false;
            this.pictureMinimize.Click += new System.EventHandler(this.PictureMinimize_Click);
            this.pictureMinimize.MouseLeave += new System.EventHandler(this.PictureMinimize_MouseLeave);
            this.pictureMinimize.MouseHover += new System.EventHandler(this.PictureMinimize_MouseHover);
            // 
            // labelUser
            // 
            this.labelUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.Black;
            this.labelUser.Location = new System.Drawing.Point(77, 3);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(343, 27);
            this.labelUser.TabIndex = 8;
            this.labelUser.Text = "[Username]";
            this.labelUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureClose
            // 
            this.pictureClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureClose.Image")));
            this.pictureClose.Location = new System.Drawing.Point(870, 0);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(30, 30);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureClose.TabIndex = 7;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.PictureClose_Click);
            this.pictureClose.MouseLeave += new System.EventHandler(this.PictureClose_MouseLeave);
            this.pictureClose.MouseHover += new System.EventHandler(this.PictureClose_MouseHover);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(156)))), ((int)(((byte)(68)))));
            this.panelLeft.Controls.Add(this.exitPanel);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 60);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(145, 440);
            this.panelLeft.TabIndex = 10;
            // 
            // exitPanel
            // 
            this.exitPanel.BackColor = System.Drawing.Color.Transparent;
            this.exitPanel.Controls.Add(this.exitLabel);
            this.exitPanel.Controls.Add(this.exitButton);
            this.exitPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitPanel.Location = new System.Drawing.Point(0, 346);
            this.exitPanel.Name = "exitPanel";
            this.exitPanel.Size = new System.Drawing.Size(145, 94);
            this.exitPanel.TabIndex = 2;
            this.exitPanel.Click += new System.EventHandler(this.ExitPanel_Click);
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.Location = new System.Drawing.Point(76, 34);
            this.exitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(56, 29);
            this.exitLabel.TabIndex = 1;
            this.exitLabel.Text = "Exit";
            this.exitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // exitButton
            // 
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(0, 17);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(102, 53);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitButton.TabIndex = 0;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.exitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.exitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            // 
            // panelMain
            // 
            this.panelMain.AutoSize = true;
            this.panelMain.BackColor = System.Drawing.Color.Black;
            this.panelMain.Controls.Add(this.labelWelcome);
            this.panelMain.Location = new System.Drawing.Point(150, 65);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(750, 435);
            this.panelMain.TabIndex = 12;
            // 
            // circleProfile
            // 
            this.circleProfile.Image = ((System.Drawing.Image)(resources.GetObject("circleProfile.Image")));
            this.circleProfile.Location = new System.Drawing.Point(-10, 0);
            this.circleProfile.Name = "circleProfile";
            this.circleProfile.Size = new System.Drawing.Size(71, 53);
            this.circleProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circleProfile.TabIndex = 14;
            this.circleProfile.TabStop = false;
            // 
            // labelWelcome
            // 
            this.labelWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.White;
            this.labelWelcome.Location = new System.Drawing.Point(139, 20);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(422, 46);
            this.labelWelcome.TabIndex = 11;
            this.labelWelcome.Text = "Welcome [Username]";
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelDraggable);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "MenuScreen";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuScreen_Load);
            this.SizeChanged += new System.EventHandler(this.MenuScreen_SizeChanged);
            this.panelDraggable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.exitPanel.ResumeLayout(false);
            this.exitPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circleProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDraggable;
        private System.Windows.Forms.PictureBox pictureClose;
        private System.Windows.Forms.PictureBox pictureRestore;
        private System.Windows.Forms.PictureBox pictureMinimize;
        private System.Windows.Forms.PictureBox pictureMaximize;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.Label labelUserRole;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel exitPanel;
        private System.Windows.Forms.PictureBox circleProfile;
        private System.Windows.Forms.Label labelWelcome;
    }
}