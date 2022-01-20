using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ConnectionLibrary;
using CustomControls;
using System.Drawing.Drawing2D;
using System.Net;
using System.IO;

namespace SecureCore
{
    public partial class MenuScreen : Form
    {
        DataSet dts;
        private bool mouseDown;
        private Point lastLocation;
        UserCard userCard = new UserCard();
        
        class ConnectionToDB : Connection
        {

        }

        public MenuScreen()
        {
            InitializeComponent();
        }

        #region Pannel Draggable

        private void PanelDraggable_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown(e);
        }

        private void PanelDraggable_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(e);
        }

        private void PanelDraggable_MouseUp(object sender, MouseEventArgs e)
        {
            MouseUp();
        }

        #endregion

        #region Pannel Buttons

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

        private void PictureMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            panelMain.Height = panelMain.Parent.Height - panelDraggable.Height;
            panelMain.Width = panelMain.Parent.Width - panelLeft.Width;
            pictureMaximize.Visible = false;
            pictureRestore.Visible = true;
        }

        private void PictureMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PictureRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureMaximize.Visible = true;
            pictureRestore.Visible = false;
        }

        private void PictureMaximize_MouseHover(object sender, EventArgs e)
        {
            pictureMaximize.BackColor = Color.LightGreen;
        }

        private void PictureMaximize_MouseLeave(object sender, EventArgs e)
        {
            pictureMaximize.BackColor = Color.Transparent;
        }

        private void PictureRestore_MouseHover(object sender, EventArgs e)
        {
            pictureRestore.BackColor = Color.LightGreen;
        }

        private void PictureRestore_MouseLeave(object sender, EventArgs e)
        {
            pictureRestore.BackColor = Color.Transparent;
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

        #region Mouse Actions

        private new void MouseUp()
        {
            mouseDown = false;
        }

        private new void MouseMove(MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private new void MouseDown(MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        #endregion

        private void CarregarBenvinguda()
        {
            labelUser.Text = LoginScreen.nomComplert;
            labelWelcome.Text = "Welcome " + LoginScreen.nomComplert;
        }
        private void CarregarUsuari()
        {
            labelUserRole.Text = PortarCategoria();
            pictureUser.ImageLocation = LoginScreen.urlPhoto;
            circleProfile.BackColor = Color.Transparent;
            circleProfile.Parent = pictureUser;

        }
        private void MenuScreen_Load(object sender, EventArgs e)
        {
            panelMain.Height = panelMain.Parent.Height - panelDraggable.Height;
            panelMain.Width = panelMain.Parent.Width - panelLeft.Width;
            CarregarBenvinguda();

            ShowMenuOptions();
            CarregarUsuari();
        }

        private void ShowMenuOptions()
        {
            Connection connexio = new ConnectionToDB();

            connexio.Conectar();
            dts = connexio.PortarPerConsulta("SELECT * FROM UserOptions ORDER BY idOption DESC");

            foreach (DataRow row in dts.Tables[0].Rows)
            {
                AppLauncher appLauncher = new AppLauncher()
                {
                    Form = row[3].ToString(),
                    Classe = row[6].ToString(),
                    LabelText = row[1].ToString(),
                    ImageUrl = row[2].ToString(),
                    NomTaula = row[4].ToString(),
                    Width = 50,
                    Height = 50,
                    Dock = DockStyle.Top
                };

                panelLeft.Controls.Add(appLauncher);   
            }
        }

        private void PictureLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginScreen login = new LoginScreen();
            login.ShowDialog();
            this.Close();
        }

        private string PortarCategoria()
        {
            string categoria = "";

            Connection connexio = new ConnectionToDB();
            connexio.Conectar();

            dts = connexio.PortarPerConsulta("SELECT * FROM UserCategories WHERE idUserCategory = " + LoginScreen.idUserCategory);

            foreach (DataRow row in dts.Tables[0].Rows)
            {
                categoria = row[2].ToString();
            }

            return categoria;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginScreen login = new LoginScreen();
            login.ShowDialog();
            this.Close();
        }

        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            exitLabel.ForeColor = Color.White;
            Cursor = Cursors.Hand;
        }

        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            exitLabel.ForeColor = Color.Black;
            Cursor = Cursors.Default;
        }

        private void ExitPanel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginScreen login = new LoginScreen();
            login.ShowDialog();
            this.Close();
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginScreen login = new LoginScreen();
            login.ShowDialog();
            this.Close();
        }

        private void MenuScreen_SizeChanged(object sender, EventArgs e)
        {
            panelMain.Height = panelMain.Parent.Height - panelDraggable.Height;
            panelMain.Width = panelMain.Parent.Width - panelLeft.Width;
            labelWelcome.Anchor = AnchorStyles.Top;

            /*
             * NO BORRAR - Arreglat que quan canvii el tamany de la finestra es vegi una icona diferent
            if (pictureMaximize.Visible)
            {
                this.WindowState = FormWindowState.Maximized;
                pictureMaximize.Visible = false;
                pictureRestore.Visible = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                pictureMaximize.Visible = true;
                pictureRestore.Visible = false;
            }
            */
        }

        private void LabelUserRole_Click(object sender, EventArgs e)
        {

        }

        private void CircleProfile_Click(object sender, EventArgs e)
        {
            UserProfile screen = new UserProfile();
            
            screen.Show();
        }
    }
}
