using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Sprint2
{
    public partial class SplashScreen : Form
    {
        
        LoginScreen login = new LoginScreen();
        public const int SEGONS = 5;
        int valX;

        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            Timer.Enabled = true;
            Timer.Start();
            Timer.Interval = 1;
            valX = blackPanel.Location.X;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (blackPanel.Location != new Point(560, 100))
            {
                valX++;
                blackPanel.Location = new Point(valX, 100);

                if (blackPanel.Location == new Point(380, 100)) this.textLabel.Text = "   Loading...";
            }
            else
            {
                Timer.Stop();

                this.Hide();
                //System.Diagnostics.Process.Start(@"CommandConsoles.exe", @"/k ../../CommandConsoles/bin/debug/");
                login.ShowDialog();
                this.Close();
            }
            
        }
    }
}
