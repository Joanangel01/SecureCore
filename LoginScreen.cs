using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectionLibrary;
using System.Security.Cryptography;
namespace Sprint2
{
    public partial class LoginScreen : Form
    {
        private const int SaltByteSize = 24;
        private const int HashByteSize = 24;
        private const int HasingIterationsCount = 10101;
        class ConnectionToDB : Connection
        {

        }

        DataSet dts;
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

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            this.ActiveControl = labelTitleLogin;

            
        }

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
                textBoxPassword.PasswordChar = '\0';
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
                Validate();
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            byte[] passwordHash;
            Connection connexio = new ConnectionToDB();

            dts = connexio.Val(dts, textBoxUser.Text, textBoxPassword.Text);

            //bool validacio = connexio.Validate(dts, queryUser, queryPass, textBoxUser.Text, textBoxPassword.Text);
            string passIntroduitStr ="";
            foreach (DataRow item in dts.Tables[0].Rows)
            {
                passIntroduitStr = (string)item[4];
            }

            byte[] passwordSalt = Encoding.ASCII.GetBytes(passIntroduitStr);
            
            passwordHash = ComputeHash(textBoxPassword.Text, passwordSalt, HasingIterationsCount, HashByteSize);

            textBox1.Text = BitConverter.ToString(passwordHash);
            textBox2.Text =passIntroduitStr;
            bool  validacio = false;
            if (validacio)
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
                textBoxPassword.PasswordChar = '\0';
            }
        }

        private void viewPassword_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxPassword.PasswordChar = '\0';
        }

        private void viewPassword_MouseUp(object sender, MouseEventArgs e)
        {
            textBoxPassword.PasswordChar = '●';
        }
        public static byte[] ComputeHash(string password, byte[] salt,
    int iterations = HasingIterationsCount, int hashByteSize = HashByteSize)
        {
            Rfc2898DeriveBytes hashGenerator = new Rfc2898DeriveBytes(password, salt);
            hashGenerator.IterationCount = iterations;

            return hashGenerator.GetBytes(hashByteSize);
        }
        public static byte[] GenerateSalt(int saltByteSize = SaltByteSize)
        {
            RNGCryptoServiceProvider saltGenerator = new
            RNGCryptoServiceProvider();

            byte[] salt = new byte[saltByteSize];
            saltGenerator.GetBytes(salt);

            return salt;
        }
        public static bool VerifyPassword(string password, byte[] passwordSalt, byte[] passwordHash)
        {

            byte[] computedHash = ComputeHash(password, passwordSalt);

            return AreHashesEqual(computedHash, passwordHash);

        }

        private static bool AreHashesEqual(byte[] firstHash, byte[] secondHash)

        {
            bool correcte = false;
            if (firstHash.Equals(secondHash))
            {
                correcte = true;
            }
            return correcte;
        }

    }
}
