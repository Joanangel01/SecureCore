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

        private void MenuScreen_Load(object sender, EventArgs e)
        {
            Image StartImage;

            labelUser.Text = LoginScreen.nomComplert;
            labelWelcome.Text = "Welcome " + LoginScreen.nomComplert;
            showMenuOptions();
            labelUserRole.Text = portarCategoria();

            using (WebClient webClient = new WebClient())
            {
                byte[] data = webClient.DownloadData(LoginScreen.urlPhoto);

                using (MemoryStream mem = new MemoryStream(data))
                {
                    StartImage = Image.FromStream(mem);
                }
            }

            Image RoundedImage = ClipToCircle(StartImage, new PointF(StartImage.Width / 2, StartImage.Height / 2), StartImage.Width / 2, 
                                              Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(156)))), ((int)(((byte)(68))))));
            pictureUser.Image = RoundedImage;
            pictureUser.BorderStyle = BorderStyle.None;
        }

        public Image ClipToCircle(Image srcImage, PointF center, float radius, Color backGround)
        {
            Image dstImage = new Bitmap(srcImage.Width, srcImage.Height, srcImage.PixelFormat);

            using (Graphics grafic = Graphics.FromImage(dstImage))
            {
                RectangleF objecte = new RectangleF(center.X - radius, center.Y - radius,
                                                         radius * 2, radius * 2);
                grafic.SmoothingMode = SmoothingMode.AntiAlias;

                using (Brush brush = new SolidBrush(backGround))
                {
                    grafic.FillRectangle(brush, 0, 0, dstImage.Width, dstImage.Height);
                }

                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(objecte);
                grafic.SetClip(path);
                grafic.DrawImage(srcImage, 0, 0);

                return dstImage;
            }
        }

        private void showMenuOptions()
        {
            Connection connexio = new ConnectionToDB();

            connexio.Conectar();
            dts = connexio.PortarPerConsulta("SELECT * FROM UserOption ORDER BY idOption DESC", dts);

            foreach (DataRow row in dts.Tables[0].Rows)
            {
                AppLauncher appLauncher = new AppLauncher()
                {
                    Form = row[3].ToString(),
                    Classe = "Sprint2",
                    LabelText = row[1].ToString(),
                    ImageUrl = row[2].ToString(),
                    Width = 50,
                    Height = 50,
                    Dock = DockStyle.Top
                };

                panelLeft.Controls.Add(appLauncher);   
            }
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

            dts = connexio.PortarPerConsulta("SELECT * FROM UserCategories WHERE idUserCategory = " + LoginScreen.idUserCategory, dts);

            foreach (DataRow row in dts.Tables[0].Rows)
            {
                categoria = row[2].ToString();
            }

            return categoria;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginScreen login = new LoginScreen();
            login.ShowDialog();
            this.Close();
        }

        private void exitButton_MouseEnter(object sender, EventArgs e)
        {
            exitLabel.ForeColor = Color.White;
            Cursor = Cursors.Hand;
        }

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            exitLabel.ForeColor = Color.Black;
            Cursor = Cursors.Default;
        }

    }
}
