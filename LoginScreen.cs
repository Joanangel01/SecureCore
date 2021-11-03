using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprint2
{
    public partial class LoginScreen : Form
    {
        readonly private String user = "admin";
        readonly private String password = "admin1234";

        string hola = "Data Source=DESKTOP-V27T8O4\\SQLEXPRESS;Initial Catalog=SecureCore;Integrated Security=True";

        MenuScreen menuScreen = new MenuScreen();
        private bool mouseDown;
        private Point lastLocation;

        public LoginScreen()
        {
            InitializeComponent();
        }

        #region Panel Draggable

        private void PanelDraggableLeft_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown(e);
        }

        private void PanelDraggableLeft_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(e);
        }

        private void PanelDraggableLeft_MouseUp(object sender, MouseEventArgs e)
        {
            MouseUp();
        }

        private void PanelDraggableRight_MouseUp(object sender, MouseEventArgs e)
        {
            MouseUp();
        }

        private void PanelDraggableRight_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(e);
        }

        private void PanelDraggableRight_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown(e);
        }

        #endregion

        #region Panel Buttons

        private void PictureClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureClose_MouseHover(object sender, EventArgs e)
        {
            pictureClose.BackColor = Color.LightGreen;
        }

        private void PictureClose_MouseLeave(object sender, EventArgs e)
        {
            pictureClose.BackColor = Color.Transparent;
        }

        private void PictureMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PictureMinimize_MouseHover(object sender, EventArgs e)
        {
            pictureMinimize.BackColor = Color.LightGreen;
        }

        private void PictureMinimize_MouseLeave(object sender, EventArgs e)
        {
            pictureMinimize.BackColor = Color.Transparent;
        }

        #endregion

        private void TextBoxUser_Enter(object sender, EventArgs e)
        {
            labelInvalidCredentialsTitle.Visible = false;
            labelInvalidCredentialsText.Visible = false;
            if (textBoxUser.Text == "USER")
            {
                textBoxUser.Text = "";
            }
        }

        private void TextBoxUser_Leave(object sender, EventArgs e)
        {
            if(textBoxUser.Text == "")
            {
                textBoxUser.Text = "USER";
            }
        }

        private void TextBoxPassword_Enter(object sender, EventArgs e)
        {
            labelInvalidCredentialsTitle.Visible = false;
            labelInvalidCredentialsText.Visible = false;
            if (textBoxPassword.Text == "PASSWORD")
            {
                textBoxPassword.Text = "";
                textBoxPassword.PasswordChar = '●';
            }
            viewPassword.Visible = true;
        }

        private void TextBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "PASSWORD";
                textBoxPassword.UseSystemPasswordChar = false;
            }
        }

        private new void MouseUp()
        {
            mouseDown = false;
        }

        private new void MouseMove(MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private new void MouseDown(MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void TextBoxUser_KeyDown(object sender, KeyEventArgs e)
        {
            CheckCredentials(e);
        }

        private void TextBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            CheckCredentials(e);
        }       

        private void CheckCredentials(KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (textBoxUser.Text.Equals(user) && textBoxPassword.Text.Equals(password))
                {
                    this.Hide();
                    menuScreen.ShowDialog();
                    this.Close();
                }
                else
                {
                    labelInvalidCredentialsTitle.Visible = true;
                    labelInvalidCredentialsText.Visible = true;
                    this.ActiveControl = labelTitleLogin;
                    textBoxUser.Text = "USER";
                    textBoxPassword.Text = "PASSWORD";
                    textBoxPassword.UseSystemPasswordChar = false;
                }
            }
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            this.ActiveControl = labelTitleLogin;
        }

        private void viewPassword_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxPassword.PasswordChar = '\0';
        }

        private void viewPassword_MouseUp(object sender, MouseEventArgs e)
        {
            textBoxPassword.PasswordChar = '●';
        }

        private void panelDraggableRight_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
