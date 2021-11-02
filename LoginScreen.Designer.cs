
namespace Sprint2
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelDraggableLeft = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDraggableRight = new System.Windows.Forms.Panel();
            this.pictureMinimize = new System.Windows.Forms.PictureBox();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.labelTitleLogin = new System.Windows.Forms.Label();
            this.panelUserUnderline = new System.Windows.Forms.Panel();
            this.panelPasswordUnderline = new System.Windows.Forms.Panel();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelInvalidCredentialsTitle = new System.Windows.Forms.Label();
            this.labelInvalidCredentialsText = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDraggableRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panelLeft.Controls.Add(this.panelDraggableLeft);
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(200, 500);
            this.panelLeft.TabIndex = 0;
            // 
            // panelDraggableLeft
            // 
            this.panelDraggableLeft.BackColor = System.Drawing.Color.Transparent;
            this.panelDraggableLeft.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelDraggableLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDraggableLeft.Location = new System.Drawing.Point(0, 0);
            this.panelDraggableLeft.Name = "panelDraggableLeft";
            this.panelDraggableLeft.Size = new System.Drawing.Size(200, 40);
            this.panelDraggableLeft.TabIndex = 11;
            this.panelDraggableLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelDraggableLeft_MouseDown);
            this.panelDraggableLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelDraggableLeft_MouseMove);
            this.panelDraggableLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelDraggableLeft_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelDraggableRight
            // 
            this.panelDraggableRight.BackColor = System.Drawing.Color.Transparent;
            this.panelDraggableRight.Controls.Add(this.pictureMinimize);
            this.panelDraggableRight.Controls.Add(this.pictureClose);
            this.panelDraggableRight.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelDraggableRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDraggableRight.Location = new System.Drawing.Point(200, 0);
            this.panelDraggableRight.Name = "panelDraggableRight";
            this.panelDraggableRight.Size = new System.Drawing.Size(700, 40);
            this.panelDraggableRight.TabIndex = 8;
            this.panelDraggableRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelDraggableRight_MouseDown);
            this.panelDraggableRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelDraggableRight_MouseMove);
            this.panelDraggableRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelDraggableRight_MouseUp);
            // 
            // pictureMinimize
            // 
            this.pictureMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pictureMinimize.Image")));
            this.pictureMinimize.Location = new System.Drawing.Point(643, 0);
            this.pictureMinimize.Name = "pictureMinimize";
            this.pictureMinimize.Size = new System.Drawing.Size(30, 30);
            this.pictureMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMinimize.TabIndex = 11;
            this.pictureMinimize.TabStop = false;
            this.pictureMinimize.Click += new System.EventHandler(this.PictureMinimize_Click);
            this.pictureMinimize.MouseLeave += new System.EventHandler(this.PictureMinimize_MouseLeave);
            this.pictureMinimize.MouseHover += new System.EventHandler(this.PictureMinimize_MouseHover);
            // 
            // pictureClose
            // 
            this.pictureClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureClose.Image")));
            this.pictureClose.Location = new System.Drawing.Point(670, 0);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(30, 30);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureClose.TabIndex = 7;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.PictureClose_Click);
            this.pictureClose.MouseLeave += new System.EventHandler(this.PictureClose_MouseLeave);
            this.pictureClose.MouseHover += new System.EventHandler(this.PictureClose_MouseHover);
            // 
            // labelTitleLogin
            // 
            this.labelTitleLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitleLogin.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTitleLogin.Location = new System.Drawing.Point(206, 88);
            this.labelTitleLogin.Name = "labelTitleLogin";
            this.labelTitleLogin.Size = new System.Drawing.Size(682, 66);
            this.labelTitleLogin.TabIndex = 8;
            this.labelTitleLogin.Text = "LOGIN";
            this.labelTitleLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelUserUnderline
            // 
            this.panelUserUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelUserUnderline.Location = new System.Drawing.Point(370, 240);
            this.panelUserUnderline.Name = "panelUserUnderline";
            this.panelUserUnderline.Size = new System.Drawing.Size(377, 5);
            this.panelUserUnderline.TabIndex = 9;
            // 
            // panelPasswordUnderline
            // 
            this.panelPasswordUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelPasswordUnderline.Location = new System.Drawing.Point(370, 302);
            this.panelPasswordUnderline.Name = "panelPasswordUnderline";
            this.panelPasswordUnderline.Size = new System.Drawing.Size(377, 5);
            this.panelPasswordUnderline.TabIndex = 10;
            // 
            // textBoxUser
            // 
            this.textBoxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(156)))), ((int)(((byte)(68)))));
            this.textBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUser.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxUser.Location = new System.Drawing.Point(370, 215);
            this.textBoxUser.MaxLength = 32;
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(377, 27);
            this.textBoxUser.TabIndex = 0;
            this.textBoxUser.Text = "USER";
            this.textBoxUser.Enter += new System.EventHandler(this.TextBoxUser_Enter);
            this.textBoxUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxUser_KeyDown);
            this.textBoxUser.Leave += new System.EventHandler(this.TextBoxUser_Leave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(156)))), ((int)(((byte)(68)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxPassword.Location = new System.Drawing.Point(370, 277);
            this.textBoxPassword.MaxLength = 32;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(377, 27);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.Text = "PASSWORD";
            this.textBoxPassword.Enter += new System.EventHandler(this.TextBoxPassword_Enter);
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxPassword_KeyDown);
            this.textBoxPassword.Leave += new System.EventHandler(this.TextBoxPassword_Leave);
            // 
            // labelInvalidCredentialsTitle
            // 
            this.labelInvalidCredentialsTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInvalidCredentialsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelInvalidCredentialsTitle.Location = new System.Drawing.Point(218, 346);
            this.labelInvalidCredentialsTitle.Name = "labelInvalidCredentialsTitle";
            this.labelInvalidCredentialsTitle.Size = new System.Drawing.Size(670, 23);
            this.labelInvalidCredentialsTitle.TabIndex = 11;
            this.labelInvalidCredentialsTitle.Text = "Invalid Credentials";
            this.labelInvalidCredentialsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelInvalidCredentialsTitle.Visible = false;
            // 
            // labelInvalidCredentialsText
            // 
            this.labelInvalidCredentialsText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInvalidCredentialsText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelInvalidCredentialsText.Location = new System.Drawing.Point(218, 369);
            this.labelInvalidCredentialsText.Name = "labelInvalidCredentialsText";
            this.labelInvalidCredentialsText.Size = new System.Drawing.Size(670, 23);
            this.labelInvalidCredentialsText.TabIndex = 12;
            this.labelInvalidCredentialsText.Text = "If the problem persists, please contact your Administrator";
            this.labelInvalidCredentialsText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelInvalidCredentialsText.Visible = false;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(156)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.ControlBox = false;
            this.Controls.Add(this.labelInvalidCredentialsText);
            this.Controls.Add(this.labelInvalidCredentialsTitle);
            this.Controls.Add(this.panelDraggableRight);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.panelPasswordUnderline);
            this.Controls.Add(this.panelUserUnderline);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.labelTitleLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "LoginScreen";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secure Core - Login";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDraggableRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelDraggableRight;
        private System.Windows.Forms.PictureBox pictureClose;
        private System.Windows.Forms.Label labelTitleLogin;
        private System.Windows.Forms.Panel panelUserUnderline;
        private System.Windows.Forms.Panel panelPasswordUnderline;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Panel panelDraggableLeft;
        private System.Windows.Forms.Label labelInvalidCredentialsTitle;
        private System.Windows.Forms.Label labelInvalidCredentialsText;
        private System.Windows.Forms.PictureBox pictureMinimize;
    }
}