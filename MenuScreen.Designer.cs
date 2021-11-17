
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
            this.pictureRestore = new System.Windows.Forms.PictureBox();
            this.circleProfile = new System.Windows.Forms.PictureBox();
            this.labelUserRole = new System.Windows.Forms.Label();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.pictureMaximize = new System.Windows.Forms.PictureBox();
            this.pictureMinimize = new System.Windows.Forms.PictureBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.exitPanel = new System.Windows.Forms.Panel();
            this.exitLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.panelDraggable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.exitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.panelMain.SuspendLayout();
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
            this.panelDraggable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelDraggable.Name = "panelDraggable";
            this.panelDraggable.Size = new System.Drawing.Size(1350, 94);
            this.panelDraggable.TabIndex = 9;
            this.panelDraggable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelDraggable_MouseDown);
            this.panelDraggable.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelDraggable_MouseMove);
            this.panelDraggable.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelDraggable_MouseUp);
            // 
            // pictureRestore
            // 
            this.pictureRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureRestore.Image = ((System.Drawing.Image)(resources.GetObject("pictureRestore.Image")));
            this.pictureRestore.Location = new System.Drawing.Point(1264, 0);
            this.pictureRestore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureRestore.Name = "pictureRestore";
            this.pictureRestore.Size = new System.Drawing.Size(45, 47);
            this.pictureRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureRestore.TabIndex = 11;
            this.pictureRestore.TabStop = false;
            this.pictureRestore.Click += new System.EventHandler(this.PictureRestore_Click);
            this.pictureRestore.MouseLeave += new System.EventHandler(this.PictureRestore_MouseLeave);
            this.pictureRestore.MouseHover += new System.EventHandler(this.PictureRestore_MouseHover);
            // 
            // circleProfile
            // 
            this.circleProfile.Image = ((System.Drawing.Image)(resources.GetObject("circleProfile.Image")));
            this.circleProfile.Location = new System.Drawing.Point(-19, 0);
            this.circleProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.circleProfile.Name = "circleProfile";
            this.circleProfile.Size = new System.Drawing.Size(106, 83);
            this.circleProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circleProfile.TabIndex = 14;
            this.circleProfile.TabStop = false;
            // 
            // labelUserRole
            // 
            this.labelUserRole.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserRole.ForeColor = System.Drawing.Color.White;
            this.labelUserRole.Location = new System.Drawing.Point(116, 47);
            this.labelUserRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserRole.Name = "labelUserRole";
            this.labelUserRole.Size = new System.Drawing.Size(514, 36);
            this.labelUserRole.TabIndex = 13;
            this.labelUserRole.Text = "User Category";
            this.labelUserRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureUser
            // 
            this.pictureUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(156)))), ((int)(((byte)(68)))));
            this.pictureUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureUser.Image")));
            this.pictureUser.Location = new System.Drawing.Point(19, 5);
            this.pictureUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(68, 78);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureUser.TabIndex = 12;
            this.pictureUser.TabStop = false;
            // 
            // pictureMaximize
            // 
            this.pictureMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureMaximize.Image = ((System.Drawing.Image)(resources.GetObject("pictureMaximize.Image")));
            this.pictureMaximize.Location = new System.Drawing.Point(1264, 0);
            this.pictureMaximize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureMaximize.Name = "pictureMaximize";
            this.pictureMaximize.Size = new System.Drawing.Size(45, 47);
            this.pictureMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMaximize.TabIndex = 9;
            this.pictureMaximize.TabStop = false;
            this.pictureMaximize.Visible = false;
            this.pictureMaximize.Click += new System.EventHandler(this.PictureMaximize_Click);
            this.pictureMaximize.MouseLeave += new System.EventHandler(this.PictureMaximize_MouseLeave);
            this.pictureMaximize.MouseHover += new System.EventHandler(this.PictureMaximize_MouseHover);
            // 
            // pictureMinimize
            // 
            this.pictureMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pictureMinimize.Image")));
            this.pictureMinimize.Location = new System.Drawing.Point(1224, 0);
            this.pictureMinimize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureMinimize.Name = "pictureMinimize";
            this.pictureMinimize.Size = new System.Drawing.Size(45, 47);
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
            this.labelUser.Location = new System.Drawing.Point(116, 5);
            this.labelUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(514, 42);
            this.labelUser.TabIndex = 8;
            this.labelUser.Text = "[Username]";
            this.labelUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureClose
            // 
            this.pictureClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureClose.Image")));
            this.pictureClose.Location = new System.Drawing.Point(1305, 0);
            this.pictureClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(45, 47);
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
            this.panelLeft.Location = new System.Drawing.Point(0, 94);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(218, 687);
            this.panelLeft.TabIndex = 10;
            // 
            // exitPanel
            // 
            this.exitPanel.BackColor = System.Drawing.Color.Transparent;
            this.exitPanel.Controls.Add(this.exitLabel);
            this.exitPanel.Controls.Add(this.exitButton);
            this.exitPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitPanel.Location = new System.Drawing.Point(0, 540);
            this.exitPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitPanel.Name = "exitPanel";
            this.exitPanel.Size = new System.Drawing.Size(218, 147);
            this.exitPanel.TabIndex = 2;
            this.exitPanel.Click += new System.EventHandler(this.ExitPanel_Click);
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.Location = new System.Drawing.Point(114, 53);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(84, 42);
            this.exitLabel.TabIndex = 1;
            this.exitLabel.Text = "Exit";
            this.exitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // exitButton
            // 
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(0, 27);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(153, 83);
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
            this.panelMain.Location = new System.Drawing.Point(225, 102);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1125, 680);
            this.panelMain.TabIndex = 12;
            // 
            // labelWelcome
            // 
            this.labelWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.White;
            this.labelWelcome.Location = new System.Drawing.Point(208, 31);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(666, 73);
            this.labelWelcome.TabIndex = 11;
            this.labelWelcome.Text = "Welcome [Username]";
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1350, 781);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelDraggable);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1350, 781);
            this.Name = "MenuScreen";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuScreen_Load);
            this.SizeChanged += new System.EventHandler(this.MenuScreen_SizeChanged);
            this.panelDraggable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.exitPanel.ResumeLayout(false);
            this.exitPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
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