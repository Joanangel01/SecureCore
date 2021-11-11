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
namespace Sprint2
{
    public partial class MenuScreen : Form
    {
        DataSet dts;
        private bool mouseDown;
        private Point lastLocation;
        
        class ConnectionToDB : Connection
        {

        }

        public MenuScreen()
        {
            InitializeComponent();
        }
        private void borrar()
        {
            Connection connexio = new ConnectionToDB();

            connexio.Conectar();
            dts = connexio.PortarPerConsulta("select * from UserOption order by idOption desc", dts);

            int i = 0;
            foreach (DataRow row in dts.Tables[0].Rows)
            {
                AppLauncher picture = new AppLauncher()
                {
                    Form = "LoginScreen",
                    Classe = "Sprint2",
                    LabelText = row[1].ToString(),
                    ImageUrl = row[2].ToString(),
                    Width = 50,
                    Height = 50,
                    //SizeMode = PictureBoxSizeMode.Zoom,
                    Dock = DockStyle.Top
                    //Padding = new Padding(10)
                   
                };

                panelLeft.Controls.Add(picture);

                i++;
            }
        }

        private void MenuScreen_Load(object sender, EventArgs e)
        {
            labelUser.Text = LoginScreen.nomComplert;
            pictureUser.ImageLocation = LoginScreen.urlPhoto;

            labelWelcome.Text = "Welcome " + LoginScreen.nomComplert;
            borrar();
            labelUserRole.Text = portarCategoria();
        }

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

        private void pictureLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginScreen login = new LoginScreen();
            login.ShowDialog();
            this.Close();
        }

        private string portarCategoria()
        {
            string categoria = "";

            Connection connexio = new ConnectionToDB();
            connexio.Conectar();

            dts = connexio.PortarPerConsulta("select * from usercategories where idUserCategory = " + LoginScreen.idUserCategory, dts);

            foreach (DataRow item in dts.Tables[0].Rows)
            {
                categoria = item[2].ToString();
            }

            return categoria;
        }
    }
}
