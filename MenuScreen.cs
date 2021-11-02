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
    public partial class MenuScreen : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public MenuScreen()
        {
            InitializeComponent();
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
    }
}
