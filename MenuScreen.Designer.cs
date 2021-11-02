
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
            this.pictureFilter = new System.Windows.Forms.PictureBox();
            this.pictureList = new System.Windows.Forms.PictureBox();
            this.pictureGrid = new System.Windows.Forms.PictureBox();
            this.pictureBug = new System.Windows.Forms.PictureBox();
            this.pictureSettings = new System.Windows.Forms.PictureBox();
            this.pictureSearch = new System.Windows.Forms.PictureBox();
            this.pictureLogout = new System.Windows.Forms.PictureBox();
            this.panelDraggable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDraggable
            // 
            this.panelDraggable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(156)))), ((int)(((byte)(68)))));
            this.panelDraggable.Controls.Add(this.labelUserRole);
            this.panelDraggable.Controls.Add(this.pictureUser);
            this.panelDraggable.Controls.Add(this.pictureMaximize);
            this.panelDraggable.Controls.Add(this.pictureRestore);
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
            this.labelUserRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelUserRole.Location = new System.Drawing.Point(66, 30);
            this.labelUserRole.Name = "labelUserRole";
            this.labelUserRole.Size = new System.Drawing.Size(187, 23);
            this.labelUserRole.TabIndex = 13;
            this.labelUserRole.Text = "Database Manager";
            this.labelUserRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureUser
            // 
            this.pictureUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureUser.Image")));
            this.pictureUser.Location = new System.Drawing.Point(0, 0);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(60, 60);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
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
            this.pictureRestore.Visible = false;
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
            this.labelUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelUser.Location = new System.Drawing.Point(66, 3);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(226, 27);
            this.labelUser.TabIndex = 8;
            this.labelUser.Text = "Joaquim Albert Gooijer";
            this.labelUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.panelLeft.Controls.Add(this.pictureSearch);
            this.panelLeft.Controls.Add(this.pictureLogout);
            this.panelLeft.Controls.Add(this.pictureSettings);
            this.panelLeft.Controls.Add(this.pictureBug);
            this.panelLeft.Controls.Add(this.pictureGrid);
            this.panelLeft.Controls.Add(this.pictureList);
            this.panelLeft.Controls.Add(this.pictureFilter);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 60);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(60, 440);
            this.panelLeft.TabIndex = 10;
            // 
            // pictureFilter
            // 
            this.pictureFilter.Image = ((System.Drawing.Image)(resources.GetObject("pictureFilter.Image")));
            this.pictureFilter.Location = new System.Drawing.Point(5, 92);
            this.pictureFilter.Name = "pictureFilter";
            this.pictureFilter.Size = new System.Drawing.Size(50, 50);
            this.pictureFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureFilter.TabIndex = 11;
            this.pictureFilter.TabStop = false;
            // 
            // pictureList
            // 
            this.pictureList.Image = ((System.Drawing.Image)(resources.GetObject("pictureList.Image")));
            this.pictureList.Location = new System.Drawing.Point(5, 148);
            this.pictureList.Name = "pictureList";
            this.pictureList.Size = new System.Drawing.Size(50, 50);
            this.pictureList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureList.TabIndex = 12;
            this.pictureList.TabStop = false;
            // 
            // pictureGrid
            // 
            this.pictureGrid.Image = ((System.Drawing.Image)(resources.GetObject("pictureGrid.Image")));
            this.pictureGrid.Location = new System.Drawing.Point(5, 204);
            this.pictureGrid.Name = "pictureGrid";
            this.pictureGrid.Size = new System.Drawing.Size(50, 50);
            this.pictureGrid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureGrid.TabIndex = 13;
            this.pictureGrid.TabStop = false;
            // 
            // pictureBug
            // 
            this.pictureBug.Image = ((System.Drawing.Image)(resources.GetObject("pictureBug.Image")));
            this.pictureBug.Location = new System.Drawing.Point(5, 260);
            this.pictureBug.Name = "pictureBug";
            this.pictureBug.Size = new System.Drawing.Size(50, 50);
            this.pictureBug.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBug.TabIndex = 14;
            this.pictureBug.TabStop = false;
            // 
            // pictureSettings
            // 
            this.pictureSettings.Image = ((System.Drawing.Image)(resources.GetObject("pictureSettings.Image")));
            this.pictureSettings.Location = new System.Drawing.Point(5, 316);
            this.pictureSettings.Name = "pictureSettings";
            this.pictureSettings.Size = new System.Drawing.Size(50, 50);
            this.pictureSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureSettings.TabIndex = 15;
            this.pictureSettings.TabStop = false;
            // 
            // pictureSearch
            // 
            this.pictureSearch.Image = ((System.Drawing.Image)(resources.GetObject("pictureSearch.Image")));
            this.pictureSearch.Location = new System.Drawing.Point(5, 36);
            this.pictureSearch.Name = "pictureSearch";
            this.pictureSearch.Size = new System.Drawing.Size(50, 50);
            this.pictureSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureSearch.TabIndex = 12;
            this.pictureSearch.TabStop = false;
            // 
            // pictureLogout
            // 
            this.pictureLogout.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogout.Image")));
            this.pictureLogout.Location = new System.Drawing.Point(5, 372);
            this.pictureLogout.Name = "pictureLogout";
            this.pictureLogout.Size = new System.Drawing.Size(50, 50);
            this.pictureLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureLogout.TabIndex = 13;
            this.pictureLogout.TabStop = false;
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelDraggable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "MenuScreen";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelDraggable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogout)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.PictureBox pictureFilter;
        private System.Windows.Forms.PictureBox pictureSearch;
        private System.Windows.Forms.PictureBox pictureLogout;
        private System.Windows.Forms.PictureBox pictureSettings;
        private System.Windows.Forms.PictureBox pictureBug;
        private System.Windows.Forms.PictureBox pictureGrid;
        private System.Windows.Forms.PictureBox pictureList;
    }
}